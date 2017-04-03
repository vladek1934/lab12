namespace PaintPencil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineBtn = new System.Windows.Forms.Button();
            this.freeBtn = new System.Windows.Forms.Button();
            this.Rectbtn = new System.Windows.Forms.Button();
            this.Ellipsebtn = new System.Windows.Forms.Button();
            this.Fillbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(76, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 257);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(14, 68);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(40, 31);
            this.colorBtn.TabIndex = 1;
            this.colorBtn.Text = "color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseLocationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouseLocationLabel
            // 
            this.mouseLocationLabel.Name = "mouseLocationLabel";
            this.mouseLocationLabel.Size = new System.Drawing.Size(89, 17);
            this.mouseLocationLabel.Text = "mouseLocation";
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(14, 114);
            this.lineBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(40, 28);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.Text = "line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // freeBtn
            // 
            this.freeBtn.Location = new System.Drawing.Point(14, 156);
            this.freeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.freeBtn.Name = "freeBtn";
            this.freeBtn.Size = new System.Drawing.Size(40, 28);
            this.freeBtn.TabIndex = 4;
            this.freeBtn.Text = "free";
            this.freeBtn.UseVisualStyleBackColor = true;
            this.freeBtn.Click += new System.EventHandler(this.freeBtn_Click);
            // 
            // Rectbtn
            // 
            this.Rectbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rectbtn.Location = new System.Drawing.Point(14, 202);
            this.Rectbtn.Name = "Rectbtn";
            this.Rectbtn.Size = new System.Drawing.Size(40, 24);
            this.Rectbtn.TabIndex = 5;
            this.Rectbtn.Text = "Rect";
            this.Rectbtn.UseVisualStyleBackColor = true;
            this.Rectbtn.Click += new System.EventHandler(this.Rectbtn_Click);
            // 
            // Ellipsebtn
            // 
            this.Ellipsebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ellipsebtn.Location = new System.Drawing.Point(14, 243);
            this.Ellipsebtn.Name = "Ellipsebtn";
            this.Ellipsebtn.Size = new System.Drawing.Size(57, 24);
            this.Ellipsebtn.TabIndex = 6;
            this.Ellipsebtn.Text = "Ellipse";
            this.Ellipsebtn.UseVisualStyleBackColor = true;
            this.Ellipsebtn.Click += new System.EventHandler(this.Ellipsebtn_Click);
            // 
            // Fillbtn
            // 
            this.Fillbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fillbtn.Location = new System.Drawing.Point(14, 273);
            this.Fillbtn.Name = "Fillbtn";
            this.Fillbtn.Size = new System.Drawing.Size(57, 24);
            this.Fillbtn.TabIndex = 7;
            this.Fillbtn.Text = "Fill";
            this.Fillbtn.UseVisualStyleBackColor = true;
            this.Fillbtn.Click += new System.EventHandler(this.Fillbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.Fillbtn);
            this.Controls.Add(this.Ellipsebtn);
            this.Controls.Add(this.Rectbtn);
            this.Controls.Add(this.freeBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseLocationLabel;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button freeBtn;
        private System.Windows.Forms.Button Rectbtn;
        private System.Windows.Forms.Button Ellipsebtn;
        private System.Windows.Forms.Button Fillbtn;
    }
}

