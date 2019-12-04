using System;
using System.Windows.Forms;


namespace FormsCtrlLib
{
    partial class AboutDialFormCtrl 
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLibVersion = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(240, 184);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DockSample Version:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright 2007, Weifen Luo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DockPanel Suite Version:";
            // 
            // labelLibVersion
            // 
            this.labelLibVersion.Location = new System.Drawing.Point(198, 85);
            this.labelLibVersion.Name = "labelLibVersion";
            this.labelLibVersion.Size = new System.Drawing.Size(97, 13);
            this.labelLibVersion.TabIndex = 4;
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.Location = new System.Drawing.Point(129, 59);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(97, 16);
            this.labelAppVersion.TabIndex = 5;
            // 
            // AboutDialFormCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelLibVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Name = "AboutDialFormCtrl";
            this.Size = new System.Drawing.Size(340, 262);
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void AboutDialog_Load(object sender, EventArgs e)
        {
            //labelAppVersion.Text = typeof(MainForm).Assembly.GetName().Version.ToString();
            //labelLibVersion.Text = typeof(DockPanel).Assembly.GetName().Version.ToString();
        }


        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLibVersion;
        private System.Windows.Forms.Label labelAppVersion;
    }
}
