namespace EdwardWanA1Warehouse
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
            this.components = new System.ComponentModel.Container();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblMovingDistance = new System.Windows.Forms.Label();
            this.lblStoppingTime = new System.Windows.Forms.Label();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picRobot = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picSpring = new System.Windows.Forms.PictureBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblBoxMass = new System.Windows.Forms.Label();
            this.lblSpringDistance = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblReset = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblStartingSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.Location = new System.Drawing.Point(614, 905);
            this.lblUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(255, 25);
            this.lblUp.TabIndex = 2;
            this.lblUp.Text = "↑  or W(Increase Box Mass)";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLeft.Location = new System.Drawing.Point(334, 948);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(284, 25);
            this.lblLeft.TabIndex = 3;
            this.lblLeft.Text = "(Compress The Spring) ← or A";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRight.Location = new System.Drawing.Point(843, 948);
            this.lblRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(243, 25);
            this.lblRight.TabIndex = 4;
            this.lblRight.Text = "→ or D(Stretch the Spring)";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDown.Location = new System.Drawing.Point(614, 998);
            this.lblDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(258, 25);
            this.lblDown.TabIndex = 5;
            this.lblDown.Text = "↓  or S(Decrease Box Mass)";
            // 
            // lblMovingDistance
            // 
            this.lblMovingDistance.AutoSize = true;
            this.lblMovingDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMovingDistance.Location = new System.Drawing.Point(41, 239);
            this.lblMovingDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovingDistance.Name = "lblMovingDistance";
            this.lblMovingDistance.Size = new System.Drawing.Size(160, 25);
            this.lblMovingDistance.TabIndex = 10;
            this.lblMovingDistance.Text = "Moving distance:";
            // 
            // lblStoppingTime
            // 
            this.lblStoppingTime.AutoSize = true;
            this.lblStoppingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStoppingTime.Location = new System.Drawing.Point(41, 290);
            this.lblStoppingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoppingTime.Name = "lblStoppingTime";
            this.lblStoppingTime.Size = new System.Drawing.Size(145, 25);
            this.lblStoppingTime.TabIndex = 11;
            this.lblStoppingTime.Text = "Stopping Time:";
            // 
            // picWall
            // 
            this.picWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picWall.Location = new System.Drawing.Point(18, 402);
            this.picWall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(15, 277);
            this.picWall.TabIndex = 9;
            this.picWall.TabStop = false;
            // 
            // picRobot
            // 
            this.picRobot.Image = global::EdwardWanA1Warehouse.Properties.Resources.Blizcrank1;
            this.picRobot.Location = new System.Drawing.Point(915, 365);
            this.picRobot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picRobot.Name = "picRobot";
            this.picRobot.Size = new System.Drawing.Size(576, 314);
            this.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRobot.TabIndex = 8;
            this.picRobot.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Image = global::EdwardWanA1Warehouse.Properties.Resources.Mystery_Chest;
            this.picBox.Location = new System.Drawing.Point(490, 458);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(213, 206);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // picSpring
            // 
            this.picSpring.Image = global::EdwardWanA1Warehouse.Properties.Resources.Spring;
            this.picSpring.Location = new System.Drawing.Point(18, 511);
            this.picSpring.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSpring.Name = "picSpring";
            this.picSpring.Size = new System.Drawing.Size(464, 85);
            this.picSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpring.TabIndex = 6;
            this.picSpring.TabStop = false;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGoal.Location = new System.Drawing.Point(484, 308);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(392, 29);
            this.lblGoal.TabIndex = 12;
            this.lblGoal.Text = "Let Blitzcrank Grab the Mystery box!";
            // 
            // lblBoxMass
            // 
            this.lblBoxMass.AutoSize = true;
            this.lblBoxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBoxMass.Location = new System.Drawing.Point(45, 62);
            this.lblBoxMass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxMass.Name = "lblBoxMass";
            this.lblBoxMass.Size = new System.Drawing.Size(100, 25);
            this.lblBoxMass.TabIndex = 13;
            this.lblBoxMass.Text = "BoxMass:";
            // 
            // lblSpringDistance
            // 
            this.lblSpringDistance.AutoSize = true;
            this.lblSpringDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpringDistance.Location = new System.Drawing.Point(45, 128);
            this.lblSpringDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpringDistance.Name = "lblSpringDistance";
            this.lblSpringDistance.Size = new System.Drawing.Size(156, 25);
            this.lblSpringDistance.TabIndex = 14;
            this.lblSpringDistance.Text = "Spring Distance:";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReset.Location = new System.Drawing.Point(60, 915);
            this.lblReset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(182, 25);
            this.lblReset.TabIndex = 15;
            this.lblReset.Text = "Reset (BackSapce)";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRelease.Location = new System.Drawing.Point(1240, 909);
            this.lblRelease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(148, 25);
            this.lblRelease.TabIndex = 16;
            this.lblRelease.Text = "Enter (Release)";
            // 
            // lblStartingSpeed
            // 
            this.lblStartingSpeed.AutoSize = true;
            this.lblStartingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartingSpeed.Location = new System.Drawing.Point(45, 188);
            this.lblStartingSpeed.Name = "lblStartingSpeed";
            this.lblStartingSpeed.Size = new System.Drawing.Size(148, 25);
            this.lblStartingSpeed.TabIndex = 17;
            this.lblStartingSpeed.Text = "Starting Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 1038);
            this.Controls.Add(this.lblStartingSpeed);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblSpringDistance);
            this.Controls.Add(this.lblBoxMass);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblStoppingTime);
            this.Controls.Add(this.lblMovingDistance);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.picRobot);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.picSpring);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblUp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Reset (BackSpace)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.PictureBox picSpring;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox picRobot;
        private System.Windows.Forms.PictureBox picWall;
        private System.Windows.Forms.Label lblMovingDistance;
        private System.Windows.Forms.Label lblStoppingTime;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblBoxMass;
        private System.Windows.Forms.Label lblSpringDistance;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblStartingSpeed;
    }
}

