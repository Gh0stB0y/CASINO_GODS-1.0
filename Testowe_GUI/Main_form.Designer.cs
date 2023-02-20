namespace Testowe_GUI
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //
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
            this.Main_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(284, 261);
            this.Main_panel.TabIndex = 0;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino God";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel;
    }
}