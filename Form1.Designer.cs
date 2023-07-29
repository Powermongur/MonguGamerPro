namespace MonguGamerPro
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
            this.capsLockButton = new System.Windows.Forms.Button();
            this.numLockButton = new System.Windows.Forms.Button();
            this.scrollLockButton = new System.Windows.Forms.Button();
            this.numLockLabel = new System.Windows.Forms.Label();
            this.capsLockLabel = new System.Windows.Forms.Label();
            this.scrollLockLabel = new System.Windows.Forms.Label();
            this.f13Button = new System.Windows.Forms.Button();
            this.f14Button = new System.Windows.Forms.Button();
            this.f15Button = new System.Windows.Forms.Button();
            this.f16Button = new System.Windows.Forms.Button();
            this.f17Button = new System.Windows.Forms.Button();
            this.f18Button = new System.Windows.Forms.Button();
            this.f19Button = new System.Windows.Forms.Button();
            this.f20Button = new System.Windows.Forms.Button();
            this.f21Button = new System.Windows.Forms.Button();
            this.f22Button = new System.Windows.Forms.Button();
            this.f23Button = new System.Windows.Forms.Button();
            this.f24Button = new System.Windows.Forms.Button();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.showClockButton = new System.Windows.Forms.Button();
            this.showCrosshairButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.stopDelayButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // capsLockButton
            // 
            this.capsLockButton.Location = new System.Drawing.Point(19, 131);
            this.capsLockButton.Name = "capsLockButton";
            this.capsLockButton.Size = new System.Drawing.Size(64, 23);
            this.capsLockButton.TabIndex = 0;
            this.capsLockButton.Text = "CAPS";
            this.capsLockButton.UseVisualStyleBackColor = true;
            this.capsLockButton.Click += new System.EventHandler(this.capsLockButton_Click);
            // 
            // numLockButton
            // 
            this.numLockButton.Location = new System.Drawing.Point(19, 102);
            this.numLockButton.Name = "numLockButton";
            this.numLockButton.Size = new System.Drawing.Size(64, 23);
            this.numLockButton.TabIndex = 1;
            this.numLockButton.Text = "NUM";
            this.numLockButton.UseVisualStyleBackColor = true;
            this.numLockButton.Click += new System.EventHandler(this.numLockButton_Click);
            // 
            // scrollLockButton
            // 
            this.scrollLockButton.Location = new System.Drawing.Point(20, 160);
            this.scrollLockButton.Name = "scrollLockButton";
            this.scrollLockButton.Size = new System.Drawing.Size(63, 23);
            this.scrollLockButton.TabIndex = 2;
            this.scrollLockButton.Text = "SCROLL";
            this.scrollLockButton.UseVisualStyleBackColor = true;
            this.scrollLockButton.Click += new System.EventHandler(this.scrolLockButton_Click);
            // 
            // numLockLabel
            // 
            this.numLockLabel.AutoSize = true;
            this.numLockLabel.BackColor = System.Drawing.Color.Red;
            this.numLockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLockLabel.ForeColor = System.Drawing.Color.White;
            this.numLockLabel.Location = new System.Drawing.Point(89, 105);
            this.numLockLabel.Name = "numLockLabel";
            this.numLockLabel.Size = new System.Drawing.Size(36, 16);
            this.numLockLabel.TabIndex = 3;
            this.numLockLabel.Text = "OFF";
            // 
            // capsLockLabel
            // 
            this.capsLockLabel.AutoSize = true;
            this.capsLockLabel.BackColor = System.Drawing.Color.Red;
            this.capsLockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.capsLockLabel.ForeColor = System.Drawing.Color.White;
            this.capsLockLabel.Location = new System.Drawing.Point(89, 134);
            this.capsLockLabel.Name = "capsLockLabel";
            this.capsLockLabel.Size = new System.Drawing.Size(36, 16);
            this.capsLockLabel.TabIndex = 4;
            this.capsLockLabel.Text = "OFF";
            // 
            // scrollLockLabel
            // 
            this.scrollLockLabel.AutoSize = true;
            this.scrollLockLabel.BackColor = System.Drawing.Color.Red;
            this.scrollLockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.scrollLockLabel.ForeColor = System.Drawing.Color.White;
            this.scrollLockLabel.Location = new System.Drawing.Point(90, 163);
            this.scrollLockLabel.Name = "scrollLockLabel";
            this.scrollLockLabel.Size = new System.Drawing.Size(36, 16);
            this.scrollLockLabel.TabIndex = 5;
            this.scrollLockLabel.Text = "OFF";
            // 
            // f13Button
            // 
            this.f13Button.Location = new System.Drawing.Point(19, 22);
            this.f13Button.Name = "f13Button";
            this.f13Button.Size = new System.Drawing.Size(38, 23);
            this.f13Button.TabIndex = 6;
            this.f13Button.Text = "F13";
            this.f13Button.UseVisualStyleBackColor = true;
            this.f13Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f14Button
            // 
            this.f14Button.Location = new System.Drawing.Point(63, 22);
            this.f14Button.Name = "f14Button";
            this.f14Button.Size = new System.Drawing.Size(38, 23);
            this.f14Button.TabIndex = 6;
            this.f14Button.Text = "F14";
            this.f14Button.UseVisualStyleBackColor = true;
            this.f14Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f15Button
            // 
            this.f15Button.Location = new System.Drawing.Point(107, 22);
            this.f15Button.Name = "f15Button";
            this.f15Button.Size = new System.Drawing.Size(38, 23);
            this.f15Button.TabIndex = 6;
            this.f15Button.Text = "F15";
            this.f15Button.UseVisualStyleBackColor = true;
            this.f15Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f16Button
            // 
            this.f16Button.Location = new System.Drawing.Point(151, 22);
            this.f16Button.Name = "f16Button";
            this.f16Button.Size = new System.Drawing.Size(38, 23);
            this.f16Button.TabIndex = 6;
            this.f16Button.Text = "F16";
            this.f16Button.UseVisualStyleBackColor = true;
            this.f16Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f17Button
            // 
            this.f17Button.Location = new System.Drawing.Point(195, 22);
            this.f17Button.Name = "f17Button";
            this.f17Button.Size = new System.Drawing.Size(38, 23);
            this.f17Button.TabIndex = 6;
            this.f17Button.Text = "F17";
            this.f17Button.UseVisualStyleBackColor = true;
            this.f17Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f18Button
            // 
            this.f18Button.Location = new System.Drawing.Point(239, 22);
            this.f18Button.Name = "f18Button";
            this.f18Button.Size = new System.Drawing.Size(38, 23);
            this.f18Button.TabIndex = 6;
            this.f18Button.Text = "F18";
            this.f18Button.UseVisualStyleBackColor = true;
            this.f18Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f19Button
            // 
            this.f19Button.Location = new System.Drawing.Point(283, 22);
            this.f19Button.Name = "f19Button";
            this.f19Button.Size = new System.Drawing.Size(38, 23);
            this.f19Button.TabIndex = 6;
            this.f19Button.Text = "F19";
            this.f19Button.UseVisualStyleBackColor = true;
            this.f19Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f20Button
            // 
            this.f20Button.Location = new System.Drawing.Point(327, 22);
            this.f20Button.Name = "f20Button";
            this.f20Button.Size = new System.Drawing.Size(38, 23);
            this.f20Button.TabIndex = 6;
            this.f20Button.Text = "F20";
            this.f20Button.UseVisualStyleBackColor = true;
            this.f20Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f21Button
            // 
            this.f21Button.Location = new System.Drawing.Point(371, 22);
            this.f21Button.Name = "f21Button";
            this.f21Button.Size = new System.Drawing.Size(38, 23);
            this.f21Button.TabIndex = 6;
            this.f21Button.Text = "F21";
            this.f21Button.UseVisualStyleBackColor = true;
            this.f21Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f22Button
            // 
            this.f22Button.Location = new System.Drawing.Point(415, 22);
            this.f22Button.Name = "f22Button";
            this.f22Button.Size = new System.Drawing.Size(38, 23);
            this.f22Button.TabIndex = 6;
            this.f22Button.Text = "F22";
            this.f22Button.UseVisualStyleBackColor = true;
            this.f22Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f23Button
            // 
            this.f23Button.Location = new System.Drawing.Point(459, 22);
            this.f23Button.Name = "f23Button";
            this.f23Button.Size = new System.Drawing.Size(38, 23);
            this.f23Button.TabIndex = 6;
            this.f23Button.Text = "F23";
            this.f23Button.UseVisualStyleBackColor = true;
            this.f23Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // f24Button
            // 
            this.f24Button.Location = new System.Drawing.Point(503, 22);
            this.f24Button.Name = "f24Button";
            this.f24Button.Size = new System.Drawing.Size(38, 23);
            this.f24Button.TabIndex = 6;
            this.f24Button.Text = "F24";
            this.f24Button.UseVisualStyleBackColor = true;
            this.f24Button.Click += new System.EventHandler(this.fKeyButton_Click);
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(86, 62);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(34, 20);
            this.delayTextBox.TabIndex = 7;
            this.delayTextBox.Text = "0";
            this.delayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(20, 65);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(63, 13);
            this.delayLabel.TabIndex = 8;
            this.delayLabel.Text = "Send delay:";
            // 
            // showClockButton
            // 
            this.showClockButton.Location = new System.Drawing.Point(10, 23);
            this.showClockButton.Name = "showClockButton";
            this.showClockButton.Size = new System.Drawing.Size(102, 23);
            this.showClockButton.TabIndex = 9;
            this.showClockButton.Text = "Show Clock";
            this.showClockButton.UseVisualStyleBackColor = true;
            this.showClockButton.Click += new System.EventHandler(this.showClockButton_Click);
            // 
            // showCrosshairButton
            // 
            this.showCrosshairButton.Location = new System.Drawing.Point(10, 52);
            this.showCrosshairButton.Name = "showCrosshairButton";
            this.showCrosshairButton.Size = new System.Drawing.Size(102, 23);
            this.showCrosshairButton.TabIndex = 9;
            this.showCrosshairButton.Text = "Show Crosshair";
            this.showCrosshairButton.UseVisualStyleBackColor = true;
            this.showCrosshairButton.Click += new System.EventHandler(this.showCrosshairButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showClockButton);
            this.groupBox1.Controls.Add(this.showCrosshairButton);
            this.groupBox1.Location = new System.Drawing.Point(417, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On top overlay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "sec.";
            // 
            // fKeyTimer
            // 
            this.fKeyTimer.Interval = 1000;
            this.fKeyTimer.Tick += new System.EventHandler(this.fKeyTimer_Tick);
            // 
            // stopDelayButton
            // 
            this.stopDelayButton.Location = new System.Drawing.Point(159, 59);
            this.stopDelayButton.Name = "stopDelayButton";
            this.stopDelayButton.Size = new System.Drawing.Size(57, 23);
            this.stopDelayButton.TabIndex = 13;
            this.stopDelayButton.Text = "stop";
            this.stopDelayButton.UseVisualStyleBackColor = true;
            this.stopDelayButton.Click += new System.EventHandler(this.stopDelayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 197);
            this.Controls.Add(this.stopDelayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.f24Button);
            this.Controls.Add(this.f23Button);
            this.Controls.Add(this.f22Button);
            this.Controls.Add(this.f21Button);
            this.Controls.Add(this.f20Button);
            this.Controls.Add(this.f19Button);
            this.Controls.Add(this.f18Button);
            this.Controls.Add(this.f17Button);
            this.Controls.Add(this.f16Button);
            this.Controls.Add(this.f15Button);
            this.Controls.Add(this.f14Button);
            this.Controls.Add(this.f13Button);
            this.Controls.Add(this.scrollLockLabel);
            this.Controls.Add(this.capsLockLabel);
            this.Controls.Add(this.numLockLabel);
            this.Controls.Add(this.scrollLockButton);
            this.Controls.Add(this.numLockButton);
            this.Controls.Add(this.capsLockButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mongu Gamer Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button capsLockButton;
        private System.Windows.Forms.Button numLockButton;
        private System.Windows.Forms.Button scrollLockButton;
        private System.Windows.Forms.Label numLockLabel;
        private System.Windows.Forms.Label capsLockLabel;
        private System.Windows.Forms.Label scrollLockLabel;
        private System.Windows.Forms.Button f13Button;
        private System.Windows.Forms.Button f14Button;
        private System.Windows.Forms.Button f15Button;
        private System.Windows.Forms.Button f16Button;
        private System.Windows.Forms.Button f17Button;
        private System.Windows.Forms.Button f18Button;
        private System.Windows.Forms.Button f19Button;
        private System.Windows.Forms.Button f20Button;
        private System.Windows.Forms.Button f21Button;
        private System.Windows.Forms.Button f22Button;
        private System.Windows.Forms.Button f23Button;
        private System.Windows.Forms.Button f24Button;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Button showClockButton;
        private System.Windows.Forms.Button showCrosshairButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fKeyTimer;
        private System.Windows.Forms.Button stopDelayButton;
    }
}

