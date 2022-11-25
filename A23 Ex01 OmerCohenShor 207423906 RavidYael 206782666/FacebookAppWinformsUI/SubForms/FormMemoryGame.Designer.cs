
namespace BasicFacebookFeatures.SubForms
{
    partial class FormMemoryGame
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
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelLevelButtons = new System.Windows.Forms.Panel();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.timerWrongPair = new System.Windows.Forms.Timer(this.components);
            this.timerGoodPair = new System.Windows.Forms.Timer(this.components);
            this.panelTimer.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.panelLevelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTimeLeft.Location = new System.Drawing.Point(12, 20);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(193, 46);
            this.labelTimeLeft.TabIndex = 0;
            this.labelTimeLeft.Text = "Time left:";
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTimer.Location = new System.Drawing.Point(211, 20);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(101, 46);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "3:45";
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.Transparent;
            this.panelTimer.Controls.Add(this.labelTimeLeft);
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(800, 78);
            this.panelTimer.TabIndex = 6;
            this.panelTimer.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResult.Location = new System.Drawing.Point(294, 46);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(219, 46);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Win / Lose";
            this.labelResult.Visible = false;
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.panelLevelButtons);
            this.panelGame.Controls.Add(this.labelResult);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 78);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(800, 372);
            this.panelGame.TabIndex = 7;
            // 
            // panelLevelButtons
            // 
            this.panelLevelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLevelButtons.Controls.Add(this.buttonHard);
            this.panelLevelButtons.Controls.Add(this.buttonMedium);
            this.panelLevelButtons.Controls.Add(this.buttonEasy);
            this.panelLevelButtons.Location = new System.Drawing.Point(302, 129);
            this.panelLevelButtons.Name = "panelLevelButtons";
            this.panelLevelButtons.Size = new System.Drawing.Size(199, 206);
            this.panelLevelButtons.TabIndex = 3;
            // 
            // buttonHard
            // 
            this.buttonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHard.Location = new System.Drawing.Point(3, 139);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(192, 62);
            this.buttonHard.TabIndex = 2;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMedium.Location = new System.Drawing.Point(3, 71);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(192, 62);
            this.buttonMedium.TabIndex = 1;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEasy.Location = new System.Drawing.Point(3, 3);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(192, 62);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // timerWrongPair
            // 
            this.timerWrongPair.Interval = 500;
            this.timerWrongPair.Tick += new System.EventHandler(this.timerWrongPair_Tick);
            // 
            // timerGoodPair
            // 
            this.timerGoodPair.Interval = 500;
            this.timerGoodPair.Tick += new System.EventHandler(this.timerGoodPair_Tick);
            // 
            // FormMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelTimer);
            this.Name = "FormMemoryGame";
            this.Text = "FormMemoryGame";
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelLevelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelLevelButtons;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Timer timerWrongPair;
        private System.Windows.Forms.Timer timerGoodPair;
    }
}