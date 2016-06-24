namespace odevDeneme
{
    partial class welcomeWindow
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
            this.hosG = new System.Windows.Forms.Label();
            this.sayacForumAcilis = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hosG
            // 
            this.hosG.AutoSize = true;
            this.hosG.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosG.Location = new System.Drawing.Point(54, 84);
            this.hosG.Name = "hosG";
            this.hosG.Size = new System.Drawing.Size(295, 55);
            this.hosG.TabIndex = 1;
            this.hosG.Text = "Hoş Geldiniz";
            // 
            // sayacForumAcilis
            // 
            this.sayacForumAcilis.Tick += new System.EventHandler(this.sayacForumAcilis_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 245);
            this.Controls.Add(this.hosG);
            this.Name = "Form1";
            this.Text = "Hoş Geldiniz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hosG;
        private System.Windows.Forms.Timer sayacForumAcilis;
    }
}

