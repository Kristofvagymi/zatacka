namespace Zatacka_own
{
    partial class AllDeadPopup
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
            this.restart_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(104, 103);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(181, 132);
            this.restart_button.TabIndex = 0;
            this.restart_button.Text = "Restart game";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // button2
            // 
            this.exit_button.Location = new System.Drawing.Point(501, 103);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(177, 132);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // AllDeadPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.restart_button);
            this.Name = "AllDeadPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button exit_button;
    }
}