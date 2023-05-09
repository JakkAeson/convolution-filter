using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvolutionFilter
{
    public partial class Form1 : Form
    {
        private Bitmap sourceImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new()
            {
                Filter = "Image files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp"
            };

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            sourceImage?.Dispose();
            sourceImage = new Bitmap(fileDialog.FileName);

            fileDialog.Dispose();

            if (sourceImage.Width > panel1.Width || sourceImage.Height > panel1.Height)
            {
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                panel1.BackgroundImageLayout = ImageLayout.Center;
            }

            panel1.BackgroundImage?.Dispose();
            panel1.BackgroundImage = sourceImage;
            panel1.Refresh();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            int[][] kernel = new int[][] { new int[3], new int[3], new int[3] };
            try
            {
                kernel[0][0] = int.Parse(textBox00.Text);
                kernel[0][1] = int.Parse(textBox01.Text);
                kernel[0][2] = int.Parse(textBox02.Text);

                kernel[1][0] = int.Parse(textBox10.Text);
                kernel[1][1] = int.Parse(textBox11.Text);
                kernel[1][2] = int.Parse(textBox12.Text);

                kernel[2][0] = int.Parse(textBox20.Text);
                kernel[2][1] = int.Parse(textBox21.Text);
                kernel[2][2] = int.Parse(textBox22.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            double kernelSum = 0;
            foreach (int[] row in kernel)
            {
                kernelSum += row.Sum();
            }
            kernelSum = (kernelSum == 0) ? 1 : kernelSum;

            Bitmap resultImage = new(sourceImage.Width, sourceImage.Height, sourceImage.PixelFormat);

            Stopwatch stopwatch = Stopwatch.StartNew();

            //for (int i = 0; i < sourceImage.Width; i++)
            //{
            //    for (int j = 0; j < sourceImage.Height; j++)
            //    {
            //        resultImage.SetPixel(i, j, ConvolutePixel(sourceImage, i, j, kernel, kernelSum));
            //    }
            //}

            ParallelConvolute(sourceImage, resultImage, kernel, kernelSum);

            stopwatch.Stop();

            if (panel1.BackgroundImage != sourceImage && panel1.BackgroundImage != null)
            {
                panel1.BackgroundImage.Dispose();
            }
            panel1.BackgroundImage = resultImage;
            panel1.Refresh();

            Cursor.Current = Cursors.Default;

            labelTime.Text = $"{stopwatch.ElapsedMilliseconds}ms";
        }

        private static Color ConvolutePixel(Bitmap image, int x, int y, int[][] kernel, double kernelSum)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            int edgeX = (x > 0 && x < image.Width - 1) ? 1 : 0;
            int edgeY = (y > 0 && y < image.Height - 1) ? 1 : 0;

            for (int i = 0; i < kernel.Length; i++)
            {
                y += edgeY * (i - 1);

                for (int j = 0; j < kernel[i].Length; j++)
                {
                    x += edgeX * (j - 1);

                    r += image.GetPixel(x, y).R * kernel[i][j];
                    g += image.GetPixel(x, y).G * kernel[i][j];
                    b += image.GetPixel(x, y).B * kernel[i][j];
                }
            }

            r = Math.Round(Math.Clamp(r / kernelSum, 0, 255));
            g = Math.Round(Math.Clamp(g / kernelSum, 0, 255));
            b = Math.Round(Math.Clamp(b / kernelSum, 0, 255));

            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        private static unsafe void ParallelConvolute(Bitmap image, Bitmap result, int[][] kernel, double kernelSum)
        {
            Rectangle rect = new(0, 0, image.Width, image.Height);

            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);
            BitmapData resultData = result.LockBits(rect, ImageLockMode.WriteOnly, result.PixelFormat);

            byte* imageStartPtr = (byte*)imageData.Scan0;
            byte* resultStartPtr = (byte*)resultData.Scan0;

            int bytesPerPixel = Image.GetPixelFormatSize(image.PixelFormat) / 8;    // 8 bits in a byte
            int widthBytes = image.Width * bytesPerPixel;
            int height = image.Height;
            int stride = imageData.Stride;

            Parallel.For(0, height, y =>
            {
                byte* imageCurrentLine = imageStartPtr + (y * stride);
                byte* resultCurrentLine = resultStartPtr + (y * stride);
                
                int edgeY = (y > 0 && y < height - 1) ? 1 : 0;

                for (int x = 0; x < widthBytes; x += bytesPerPixel)
                {
                    int edgeX = (x > 0 && x < widthBytes - bytesPerPixel) ? 1 : 0;

                    double r = 0;
                    double g = 0;
                    double b = 0;

                    for (int i = 0; i < kernel.Length; i++)
                    {
                        imageCurrentLine += edgeY * (i - 1) * stride;

                        for (int j = 0; j < kernel[i].Length; j++)
                        {
                            x += edgeX * (j - 1) * bytesPerPixel;

                            r += imageCurrentLine[x + 2] * kernel[i][j];
                            g += imageCurrentLine[x + 1] * kernel[i][j];
                            b += imageCurrentLine[x] * kernel[i][j];
                        }
                    }

                    resultCurrentLine[x + 2] = (byte)Math.Round(Math.Clamp(r / kernelSum, 0, 255));
                    resultCurrentLine[x + 1] = (byte)Math.Round(Math.Clamp(g / kernelSum, 0, 255));
                    resultCurrentLine[x] = (byte)Math.Round(Math.Clamp(b / kernelSum, 0, 255));
                }
            });

            image.UnlockBits(imageData);
            result.UnlockBits(resultData);
        }

        private void OnTextBoxSelect(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectAll();
        }

        private void OnTextBoxMouseUp(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectAll();
        }
    }
}
