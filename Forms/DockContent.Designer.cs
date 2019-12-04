using System.Windows.Forms;


namespace DockPanel.WinFormUi
{
    public partial class DockContent
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
            this.FormControl = new System.Windows.Forms.UserControl();
            this.SuspendLayout();
            // 
            // FormFontrol
            // 
            this.FormControl.AutoSize = true;
            this.FormControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormControl.Location = new System.Drawing.Point(0, 0);
            this.FormControl.Name = "FormFontrol";
            this.FormControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormControl.Size = new System.Drawing.Size(1000, 563);
            this.FormControl.TabIndex = 0;
            // 
            // DockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormControl);
            this.Name = "DockContent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DockContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

  
  
    }
}