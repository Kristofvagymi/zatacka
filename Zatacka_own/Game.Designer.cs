namespace Zatacka_own
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(622, 380);
            this.Controls.Add(this.button1);
            this.Name = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

