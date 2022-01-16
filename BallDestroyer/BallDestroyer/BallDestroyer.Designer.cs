namespace BallDestroyer
{
    partial class BallDestroyer
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
            this.components = new System.ComponentModel.Container();
            this.objFormMove = new System.Windows.Forms.Panel();
            this.objTitle = new System.Windows.Forms.Label();
            this.objClose = new System.Windows.Forms.PictureBox();
            this.objSlider = new System.Windows.Forms.Panel();
            this.objHorz = new System.Windows.Forms.Timer(this.components);
            this.objVert = new System.Windows.Forms.Timer(this.components);
            this.objWatchDog = new System.Windows.Forms.Timer(this.components);
            this.objBall = new System.Windows.Forms.PictureBox();
            this.objInfo = new System.Windows.Forms.Label();
            this.objAnnimation = new System.Windows.Forms.Timer(this.components);
            this.objScore = new System.Windows.Forms.Label();
            this.objFormMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objBall)).BeginInit();
            this.SuspendLayout();
            // 
            // objFormMove
            // 
            this.objFormMove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.objFormMove.Controls.Add(this.objScore);
            this.objFormMove.Controls.Add(this.objTitle);
            this.objFormMove.Controls.Add(this.objClose);
            this.objFormMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.objFormMove.Location = new System.Drawing.Point(0, 0);
            this.objFormMove.Name = "objFormMove";
            this.objFormMove.Size = new System.Drawing.Size(1180, 29);
            this.objFormMove.TabIndex = 0;
            this.objFormMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oFormMove_MouseDown);
            this.objFormMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oFormMove_MouseMove);
            this.objFormMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.oFormMove_MouseUp);
            // 
            // objTitle
            // 
            this.objTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objTitle.AutoSize = true;
            this.objTitle.Location = new System.Drawing.Point(525, 9);
            this.objTitle.Name = "objTitle";
            this.objTitle.Size = new System.Drawing.Size(76, 15);
            this.objTitle.TabIndex = 2;
            this.objTitle.Text = "BallDestroyer";
            this.objTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objClose
            // 
            this.objClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.objClose.Image = global::BallDestroyer.Properties.Resources.CloseBlack;
            this.objClose.Location = new System.Drawing.Point(1139, 3);
            this.objClose.Name = "objClose";
            this.objClose.Size = new System.Drawing.Size(38, 23);
            this.objClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.objClose.TabIndex = 1;
            this.objClose.TabStop = false;
            this.objClose.Click += new System.EventHandler(this.objClose_Click);
            this.objClose.MouseEnter += new System.EventHandler(this.objClose_MouseEnter);
            this.objClose.MouseLeave += new System.EventHandler(this.objClose_MouseLeave);
            // 
            // objSlider
            // 
            this.objSlider.BackColor = System.Drawing.Color.DarkViolet;
            this.objSlider.Location = new System.Drawing.Point(451, 639);
            this.objSlider.Name = "objSlider";
            this.objSlider.Size = new System.Drawing.Size(300, 10);
            this.objSlider.TabIndex = 1;
            // 
            // objHorz
            // 
            this.objHorz.Interval = 1;
            this.objHorz.Tick += new System.EventHandler(this.objHorz_Tick);
            // 
            // objVert
            // 
            this.objVert.Interval = 1;
            this.objVert.Tick += new System.EventHandler(this.objVert_Tick);
            // 
            // objWatchDog
            // 
            this.objWatchDog.Interval = 1;
            this.objWatchDog.Tick += new System.EventHandler(this.objWatchDog_Tick);
            // 
            // objBall
            // 
            this.objBall.BackColor = System.Drawing.SystemColors.Control;
            this.objBall.Image = global::BallDestroyer.Properties.Resources.DiscoLights;
            this.objBall.Location = new System.Drawing.Point(560, 581);
            this.objBall.Name = "objBall";
            this.objBall.Size = new System.Drawing.Size(65, 56);
            this.objBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.objBall.TabIndex = 2;
            this.objBall.TabStop = false;
            // 
            // objInfo
            // 
            this.objInfo.AutoSize = true;
            this.objInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.objInfo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objInfo.Location = new System.Drawing.Point(342, 43);
            this.objInfo.Name = "objInfo";
            this.objInfo.Size = new System.Drawing.Size(494, 54);
            this.objInfo.TabIndex = 3;
            this.objInfo.Text = "Hello! You\'re good looking";
            this.objInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.objInfo.Click += new System.EventHandler(this.objInfo_Click);
            // 
            // objAnnimation
            // 
            this.objAnnimation.Tick += new System.EventHandler(this.objAnnimation_Tick);
            // 
            // objScore
            // 
            this.objScore.AutoSize = true;
            this.objScore.Location = new System.Drawing.Point(3, 9);
            this.objScore.Name = "objScore";
            this.objScore.Size = new System.Drawing.Size(48, 15);
            this.objScore.TabIndex = 3;
            this.objScore.Text = "Score: 0";
            // 
            // BallDestroyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 649);
            this.Controls.Add(this.objInfo);
            this.Controls.Add(this.objBall);
            this.Controls.Add(this.objSlider);
            this.Controls.Add(this.objFormMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BallDestroyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BallDestroyer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BallDestroyer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BallDestroyer_KeyUp);
            this.objFormMove.ResumeLayout(false);
            this.objFormMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel objFormMove;
        private PictureBox objClose;
        private Label objTitle;
        private Panel objSlider;
        private System.Windows.Forms.Timer objHorz;
        private System.Windows.Forms.Timer objVert;
        private System.Windows.Forms.Timer objWatchDog;
        private PictureBox objBall;
        private Label objInfo;
        private System.Windows.Forms.Timer objAnnimation;
        private Label objScore;
    }
}