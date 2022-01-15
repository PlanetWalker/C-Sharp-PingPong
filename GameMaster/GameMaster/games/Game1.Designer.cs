namespace GameMaster
{
    partial class Game1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.horz = new System.Windows.Forms.Timer(this.components);
            this.watchdog = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Interval = 1;
            this.vert.Tag = "";
            this.vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // horz
            // 
            this.horz.Enabled = true;
            this.horz.Interval = 1;
            this.horz.Tag = "";
            this.horz.Tick += new System.EventHandler(this.horz_Tick);
            // 
            // watchdog
            // 
            this.watchdog.Enabled = true;
            this.watchdog.Interval = 10;
            this.watchdog.Tick += new System.EventHandler(this.watchdog_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(12, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(83, 81);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // slider
            // 
            this.slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.slider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slider.Location = new System.Drawing.Point(387, 525);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(252, 10);
            this.slider.TabIndex = 1;
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1022, 547);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game1";
            this.Text = "Game1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ball;
        private Panel slider;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer horz;
        private System.Windows.Forms.Timer watchdog;
    }
}