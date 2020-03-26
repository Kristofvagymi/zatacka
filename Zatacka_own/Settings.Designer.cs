using System;

namespace Zatacka_own
{
    partial class Settings
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
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.turnspeedBar = new System.Windows.Forms.TrackBar();
            this.holesBar = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.holesLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnspeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holesBar)).BeginInit();
            this.SuspendLayout();
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(110, 96);
            this.speedBar.Maximum = 15;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(236, 45);
            this.speedBar.TabIndex = 0;
            this.speedBar.Value = (int)Player.Speed;
            // 
            // turnspeedBar
            // 
            this.turnspeedBar.Location = new System.Drawing.Point(110, 147);
            this.turnspeedBar.Minimum = 1;
            this.turnspeedBar.Name = "turnspeedBar";
            this.turnspeedBar.Size = new System.Drawing.Size(236, 45);
            this.turnspeedBar.TabIndex = 1;
            this.turnspeedBar.Value = Convert.ToInt32(Player.Turn / 0.1);
            // 
            // holesBar
            // 
            this.holesBar.Location = new System.Drawing.Point(110, 199);
            this.holesBar.Name = "holesBar";
            this.holesBar.Size = new System.Drawing.Size(236, 45);
            this.holesBar.TabIndex = 2;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(426, 96);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(426, 147);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(61, 13);
            this.turnLabel.TabIndex = 4;
            this.turnLabel.Text = "Turn speed";
            // 
            // holesLabel
            // 
            this.holesLabel.AutoSize = true;
            this.holesLabel.Location = new System.Drawing.Point(426, 199);
            this.holesLabel.Name = "holesLabel";
            this.holesLabel.Size = new System.Drawing.Size(64, 13);
            this.holesLabel.TabIndex = 5;
            this.holesLabel.Text = "Holes in line";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(265, 25);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(90, 25);
            this.settingsLabel.TabIndex = 6;
            this.settingsLabel.Text = "Settings";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(110, 283);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 57);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(350, 283);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(114, 57);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.holesLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.holesBar);
            this.Controls.Add(this.turnspeedBar);
            this.Controls.Add(this.speedBar);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnspeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holesBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar turnspeedBar;
        private System.Windows.Forms.TrackBar holesBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label holesLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button applyButton;
    }
}