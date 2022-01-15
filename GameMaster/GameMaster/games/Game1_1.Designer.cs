namespace GameMaster.games
{
    partial class Game1_1
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
            this.Ball = new System.Windows.Forms.Panel();
            this.Slider = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Timer(this.components);
            this.Y = new System.Windows.Forms.Timer(this.components);
            this.Watchdog = new System.Windows.Forms.Timer(this.components);
            this.Close = new System.Windows.Forms.PictureBox();
            this.Grabbing = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.AccessibleDescription = "";
            this.Ball.AccessibleName = "";
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(12, 12);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.TabIndex = 0;
            // 
            // Slider
            // 
            this.Slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slider.BackColor = System.Drawing.Color.Lime;
            this.Slider.Location = new System.Drawing.Point(269, 440);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(200, 10);
            this.Slider.TabIndex = 1;
            // 
            // X
            // 
            this.X.Enabled = true;
            this.X.Interval = 1;
            this.X.Tick += new System.EventHandler(this.X_Tick);
            // 
            // Y
            // 
            this.Y.Enabled = true;
            this.Y.Interval = 1;
            this.Y.Tick += new System.EventHandler(this.Y_Tick);
            // 
            // Watchdog
            // 
            this.Watchdog.Enabled = true;
            this.Watchdog.Interval = 1;
            this.Watchdog.Tick += new System.EventHandler(this.Watchdog_Tick);
            // 
            // Close
            // 
            this.Close.Image = global::GameMaster.Properties.Resources.a8e4b441;
            this.Close.Location = new System.Drawing.Point(763, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 30);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Grabbing
            // 
            this.Grabbing.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grabbing.Location = new System.Drawing.Point(-1, 0);
            this.Grabbing.Name = "Grabbing";
            this.Grabbing.Size = new System.Drawing.Size(803, 30);
            this.Grabbing.TabIndex = 3;
            this.Grabbing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grabbing_MouseDown);
            this.Grabbing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grabbing_MouseMove);
            this.Grabbing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Grabbing_MouseUp);
            // 
            // Game1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Grabbing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1_1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game1_1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Ball;
        private Panel Slider;
        private System.Windows.Forms.Timer X;
        private System.Windows.Forms.Timer Y;
        private System.Windows.Forms.Timer Watchdog;
        private PictureBox Close;
        private Panel Grabbing;
    }
}