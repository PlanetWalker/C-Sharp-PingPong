namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Slider = new System.Windows.Forms.Panel();
            this.Horzontal = new System.Windows.Forms.Timer(this.components);
            this.Vertikal = new System.Windows.Forms.Timer(this.components);
            this.Watchdog = new System.Windows.Forms.Timer(this.components);
            this.Close = new System.Windows.Forms.PictureBox();
            this.FormMove = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Panel();
            this.labelPoints = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.FormMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slider.BackColor = System.Drawing.Color.Aqua;
            this.Slider.Location = new System.Drawing.Point(376, 557);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(243, 11);
            this.Slider.TabIndex = 1;
            // 
            // Horzontal
            // 
            this.Horzontal.Enabled = true;
            this.Horzontal.Interval = 1;
            this.Horzontal.Tick += new System.EventHandler(this.Horzontal_Tick);
            // 
            // Vertikal
            // 
            this.Vertikal.Enabled = true;
            this.Vertikal.Interval = 1;
            this.Vertikal.Tick += new System.EventHandler(this.Vertikal_Tick);
            // 
            // Watchdog
            // 
            this.Watchdog.Enabled = true;
            this.Watchdog.Interval = 1;
            this.Watchdog.Tick += new System.EventHandler(this.Watchdog_Tick);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1048, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 30);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FormMove
            // 
            this.FormMove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormMove.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormMove.Controls.Add(this.Reset);
            this.FormMove.Controls.Add(this.Close);
            this.FormMove.Location = new System.Drawing.Point(0, 0);
            this.FormMove.Name = "FormMove";
            this.FormMove.Size = new System.Drawing.Size(1077, 28);
            this.FormMove.TabIndex = 3;
            this.FormMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.FormMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.FormMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.BackColor = System.Drawing.Color.DarkRed;
            this.Reset.Location = new System.Drawing.Point(972, 3);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 22);
            this.Reset.TabIndex = 10;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(1015, 543);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(25, 13);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "0, 0";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(372, 151);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(129, 24);
            this.info.TabIndex = 5;
            this.info.Text = "There is a Info";
            this.info.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-306, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(376, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 565);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(390, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 222);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(12, 34);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(78, 69);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 9;
            this.Ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 565);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.FormMove);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.FormMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Slider;
        private System.Windows.Forms.Timer Horzontal;
        private System.Windows.Forms.Timer Vertikal;
        private System.Windows.Forms.Timer Watchdog;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel FormMove;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Panel Reset;
    }
}

