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
            this.capsLockButton = new System.Windows.Forms.Button();
            this.numLockButton = new System.Windows.Forms.Button();
            this.scrollLockButton = new System.Windows.Forms.Button();
            this.numLockLabel = new System.Windows.Forms.Label();
            this.capsLockLabel = new System.Windows.Forms.Label();
            this.scrollLockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // capsLockButton
            // 
            this.capsLockButton.Location = new System.Drawing.Point(117, 143);
            this.capsLockButton.Name = "capsLockButton";
            this.capsLockButton.Size = new System.Drawing.Size(75, 23);
            this.capsLockButton.TabIndex = 0;
            this.capsLockButton.Text = "Caps Lock";
            this.capsLockButton.UseVisualStyleBackColor = true;
            this.capsLockButton.Click += new System.EventHandler(this.capsLockButton_Click);
            // 
            // numLockButton
            // 
            this.numLockButton.Location = new System.Drawing.Point(117, 97);
            this.numLockButton.Name = "numLockButton";
            this.numLockButton.Size = new System.Drawing.Size(75, 23);
            this.numLockButton.TabIndex = 1;
            this.numLockButton.Text = "Num Lock";
            this.numLockButton.UseVisualStyleBackColor = true;
            this.numLockButton.Click += new System.EventHandler(this.numLockButton_Click);
            // 
            // scrollLockButton
            // 
            this.scrollLockButton.Location = new System.Drawing.Point(117, 197);
            this.scrollLockButton.Name = "scrollLockButton";
            this.scrollLockButton.Size = new System.Drawing.Size(75, 23);
            this.scrollLockButton.TabIndex = 2;
            this.scrollLockButton.Text = "Scroll Lock";
            this.scrollLockButton.UseVisualStyleBackColor = true;
            this.scrollLockButton.Click += new System.EventHandler(this.scrolLockButton_Click);
            // 
            // numLockLabel
            // 
            this.numLockLabel.AutoSize = true;
            this.numLockLabel.BackColor = System.Drawing.Color.Red;
            this.numLockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLockLabel.ForeColor = System.Drawing.Color.White;
            this.numLockLabel.Location = new System.Drawing.Point(198, 100);
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
            this.capsLockLabel.Location = new System.Drawing.Point(198, 146);
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
            this.scrollLockLabel.Location = new System.Drawing.Point(198, 200);
            this.scrollLockLabel.Name = "scrollLockLabel";
            this.scrollLockLabel.Size = new System.Drawing.Size(36, 16);
            this.scrollLockLabel.TabIndex = 5;
            this.scrollLockLabel.Text = "OFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrollLockLabel);
            this.Controls.Add(this.capsLockLabel);
            this.Controls.Add(this.numLockLabel);
            this.Controls.Add(this.scrollLockButton);
            this.Controls.Add(this.numLockButton);
            this.Controls.Add(this.capsLockButton);
            this.Name = "Form1";
            this.Text = "Mongu Gamer Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

