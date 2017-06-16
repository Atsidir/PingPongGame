namespace PingPongGame
{
    partial class pingpongframe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pingpongframe));
            this.playerBar = new System.Windows.Forms.PictureBox();
            this.ballPict = new System.Windows.Forms.PictureBox();
            this.aiBar = new System.Windows.Forms.PictureBox();
            this.aiscoreLabel = new System.Windows.Forms.Label();
            this.playerscoreLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playerBar
            // 
            this.playerBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerBar.Location = new System.Drawing.Point(752, 90);
            this.playerBar.Name = "playerBar";
            this.playerBar.Size = new System.Drawing.Size(18, 126);
            this.playerBar.TabIndex = 0;
            this.playerBar.TabStop = false;
            // 
            // ballPict
            // 
            this.ballPict.Image = ((System.Drawing.Image)(resources.GetObject("ballPict.Image")));
            this.ballPict.Location = new System.Drawing.Point(372, 124);
            this.ballPict.Name = "ballPict";
            this.ballPict.Size = new System.Drawing.Size(25, 24);
            this.ballPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballPict.TabIndex = 1;
            this.ballPict.TabStop = false;
            // 
            // aiBar
            // 
            this.aiBar.BackColor = System.Drawing.Color.Maroon;
            this.aiBar.Location = new System.Drawing.Point(32, 105);
            this.aiBar.Name = "aiBar";
            this.aiBar.Size = new System.Drawing.Size(18, 126);
            this.aiBar.TabIndex = 2;
            this.aiBar.TabStop = false;
            // 
            // aiscoreLabel
            // 
            this.aiscoreLabel.AutoSize = true;
            this.aiscoreLabel.Location = new System.Drawing.Point(278, 19);
            this.aiscoreLabel.Name = "aiscoreLabel";
            this.aiscoreLabel.Size = new System.Drawing.Size(35, 13);
            this.aiscoreLabel.TabIndex = 3;
            this.aiscoreLabel.Text = "label1";
            // 
            // playerscoreLabel
            // 
            this.playerscoreLabel.AutoSize = true;
            this.playerscoreLabel.Location = new System.Drawing.Point(451, 19);
            this.playerscoreLabel.Name = "playerscoreLabel";
            this.playerscoreLabel.Size = new System.Drawing.Size(35, 13);
            this.playerscoreLabel.TabIndex = 4;
            this.playerscoreLabel.Text = "label2";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(143, 279);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(126, 54);
            this.easyButton.TabIndex = 5;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.Location = new System.Drawing.Point(331, 279);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(126, 54);
            this.normalButton.TabIndex = 6;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(526, 279);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(126, 54);
            this.hardButton.TabIndex = 7;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // pingpongframe
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.playerscoreLabel);
            this.Controls.Add(this.aiscoreLabel);
            this.Controls.Add(this.aiBar);
            this.Controls.Add(this.ballPict);
            this.Controls.Add(this.playerBar);
            this.KeyPreview = true;
            this.Name = "pingpongframe";
            this.Text = "PING PONG MINIGAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerBar;
        private System.Windows.Forms.PictureBox ballPict;
        private System.Windows.Forms.PictureBox aiBar;
        private System.Windows.Forms.Label playerscoreLabel;
        public System.Windows.Forms.Label aiscoreLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button hardButton;
    }
}

