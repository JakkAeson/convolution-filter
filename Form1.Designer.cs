
namespace ConvolutionFilter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kernel :";
            // 
            // textBox02
            // 
            this.textBox02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox02.Location = new System.Drawing.Point(758, 27);
            this.textBox02.MaxLength = 4;
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(30, 23);
            this.textBox02.TabIndex = 4;
            this.textBox02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox02.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(686, 114);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(102, 23);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBox01
            // 
            this.textBox01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox01.Location = new System.Drawing.Point(722, 27);
            this.textBox01.MaxLength = 4;
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(30, 23);
            this.textBox01.TabIndex = 3;
            this.textBox01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox01.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox00
            // 
            this.textBox00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox00.Location = new System.Drawing.Point(686, 27);
            this.textBox00.MaxLength = 4;
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(30, 23);
            this.textBox00.TabIndex = 2;
            this.textBox00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox00.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox00.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(758, 56);
            this.textBox12.MaxLength = 4;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(30, 23);
            this.textBox12.TabIndex = 7;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(722, 56);
            this.textBox11.MaxLength = 4;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(30, 23);
            this.textBox11.TabIndex = 6;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(686, 56);
            this.textBox10.MaxLength = 4;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(30, 23);
            this.textBox10.TabIndex = 5;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox22.Location = new System.Drawing.Point(758, 85);
            this.textBox22.MaxLength = 4;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(30, 23);
            this.textBox22.TabIndex = 10;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox21.Location = new System.Drawing.Point(722, 85);
            this.textBox21.MaxLength = 4;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(30, 23);
            this.textBox21.TabIndex = 9;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox20.Location = new System.Drawing.Point(686, 85);
            this.textBox20.MaxLength = 4;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(30, 23);
            this.textBox20.TabIndex = 8;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.Enter += new System.EventHandler(this.OnTextBoxSelect);
            this.textBox20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseUp);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(686, 143);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(102, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(686, 173);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(29, 15);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "0ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox00);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Convolution Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelTime;
    }
}

