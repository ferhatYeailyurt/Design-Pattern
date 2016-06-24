namespace odevDeneme
{
    partial class stadyumPenWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.dgListele = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtdigerstd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdLigiCombo = new System.Windows.Forms.ComboBox();
            this.stdLigiLabel = new System.Windows.Forms.Label();
            this.txtstdsehir = new System.Windows.Forms.TextBox();
            this.txtstdAdi = new System.Windows.Forms.TextBox();
            this.stdSehir = new System.Windows.Forms.Label();
            this.SporcuAdilabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaraStadSoay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtarastd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLigistd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.duzenleGoster = new System.Windows.Forms.Button();
            this.dgDuzenleGoster = new System.Windows.Forms.DataGridView();
            this.duzenleSil = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListele)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDuzenleGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 544);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.btnlistele);
            this.tabPage1.Controls.Add(this.dgListele);
            this.tabPage1.Controls.Add(this.btnekle);
            this.tabPage1.Controls.Add(this.txtdigerstd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.stdLigiCombo);
            this.tabPage1.Controls.Add(this.stdLigiLabel);
            this.tabPage1.Controls.Add(this.txtstdsehir);
            this.tabPage1.Controls.Add(this.txtstdAdi);
            this.tabPage1.Controls.Add(this.stdSehir);
            this.tabPage1.Controls.Add(this.SporcuAdilabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(216, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(135, 125);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 18;
            this.btnlistele.Text = "Göster";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // dgListele
            // 
            this.dgListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListele.Location = new System.Drawing.Point(6, 166);
            this.dgListele.Name = "dgListele";
            this.dgListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListele.Size = new System.Drawing.Size(694, 346);
            this.dgListele.TabIndex = 17;
            this.dgListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListele_CellContentClick);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(54, 125);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtdigerstd
            // 
            this.txtdigerstd.Location = new System.Drawing.Point(384, 98);
            this.txtdigerstd.Name = "txtdigerstd";
            this.txtdigerstd.Size = new System.Drawing.Size(133, 20);
            this.txtdigerstd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Diğer:";
            // 
            // stdLigiCombo
            // 
            this.stdLigiCombo.FormattingEnabled = true;
            this.stdLigiCombo.Location = new System.Drawing.Point(89, 98);
            this.stdLigiCombo.Name = "stdLigiCombo";
            this.stdLigiCombo.Size = new System.Drawing.Size(121, 21);
            this.stdLigiCombo.TabIndex = 5;
            // 
            // stdLigiLabel
            // 
            this.stdLigiLabel.AutoSize = true;
            this.stdLigiLabel.Location = new System.Drawing.Point(28, 106);
            this.stdLigiLabel.Name = "stdLigiLabel";
            this.stdLigiLabel.Size = new System.Drawing.Size(23, 13);
            this.stdLigiLabel.TabIndex = 4;
            this.stdLigiLabel.Text = "Ligi";
            // 
            // txtstdsehir
            // 
            this.txtstdsehir.Location = new System.Drawing.Point(384, 16);
            this.txtstdsehir.Name = "txtstdsehir";
            this.txtstdsehir.Size = new System.Drawing.Size(133, 20);
            this.txtstdsehir.TabIndex = 3;
            // 
            // txtstdAdi
            // 
            this.txtstdAdi.Location = new System.Drawing.Point(89, 16);
            this.txtstdAdi.Name = "txtstdAdi";
            this.txtstdAdi.Size = new System.Drawing.Size(121, 20);
            this.txtstdAdi.TabIndex = 2;
            // 
            // stdSehir
            // 
            this.stdSehir.AutoSize = true;
            this.stdSehir.Location = new System.Drawing.Point(325, 19);
            this.stdSehir.Name = "stdSehir";
            this.stdSehir.Size = new System.Drawing.Size(34, 13);
            this.stdSehir.TabIndex = 1;
            this.stdSehir.Text = "Şehir:";
            // 
            // SporcuAdilabel
            // 
            this.SporcuAdilabel.AutoSize = true;
            this.SporcuAdilabel.Location = new System.Drawing.Point(28, 19);
            this.SporcuAdilabel.Name = "SporcuAdilabel";
            this.SporcuAdilabel.Size = new System.Drawing.Size(25, 13);
            this.SporcuAdilabel.TabIndex = 0;
            this.SporcuAdilabel.Text = "Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.txtDiger);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbLigistd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSehir);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.duzenleGoster);
            this.tabPage2.Controls.Add(this.dgDuzenleGoster);
            this.tabPage2.Controls.Add(this.duzenleSil);
            this.tabPage2.Controls.Add(this.txtAdi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Düzenleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaraStadSoay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtarastd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(576, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 130);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txtaraStadSoay
            // 
            this.txtaraStadSoay.Location = new System.Drawing.Point(55, 64);
            this.txtaraStadSoay.Name = "txtaraStadSoay";
            this.txtaraStadSoay.Size = new System.Drawing.Size(100, 20);
            this.txtaraStadSoay.TabIndex = 49;
            this.txtaraStadSoay.TextChanged += new System.EventHandler(this.txtaraStad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Lig Ara:";
            // 
            // txtarastd
            // 
            this.txtarastd.Location = new System.Drawing.Point(55, 28);
            this.txtarastd.Name = "txtarastd";
            this.txtarastd.Size = new System.Drawing.Size(100, 20);
            this.txtarastd.TabIndex = 46;
            this.txtarastd.TextChanged += new System.EventHandler(this.txtarastd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(278, 27);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(394, 141);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(133, 20);
            this.txtDiger.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Diğer:";
            // 
            // cmbLigistd
            // 
            this.cmbLigistd.FormattingEnabled = true;
            this.cmbLigistd.Location = new System.Drawing.Point(138, 141);
            this.cmbLigistd.Name = "cmbLigistd";
            this.cmbLigistd.Size = new System.Drawing.Size(121, 21);
            this.cmbLigistd.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ligi";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(394, 80);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(133, 20);
            this.txtSehir.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Şehir:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Adı:";
            // 
            // duzenleGoster
            // 
            this.duzenleGoster.Location = new System.Drawing.Point(178, 27);
            this.duzenleGoster.Name = "duzenleGoster";
            this.duzenleGoster.Size = new System.Drawing.Size(75, 23);
            this.duzenleGoster.TabIndex = 37;
            this.duzenleGoster.Text = "Göster";
            this.duzenleGoster.UseVisualStyleBackColor = true;
            this.duzenleGoster.Click += new System.EventHandler(this.duzenleGoster_Click);
            // 
            // dgDuzenleGoster
            // 
            this.dgDuzenleGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDuzenleGoster.Location = new System.Drawing.Point(28, 188);
            this.dgDuzenleGoster.Name = "dgDuzenleGoster";
            this.dgDuzenleGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDuzenleGoster.Size = new System.Drawing.Size(655, 315);
            this.dgDuzenleGoster.TabIndex = 36;
            this.dgDuzenleGoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDuzenleGoster_CellClick);
            this.dgDuzenleGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDuzenleGoster_CellContentClick);
            this.dgDuzenleGoster.DoubleClick += new System.EventHandler(this.dgDuzenleGoster_DoubleClick);
            // 
            // duzenleSil
            // 
            this.duzenleSil.Location = new System.Drawing.Point(83, 27);
            this.duzenleSil.Name = "duzenleSil";
            this.duzenleSil.Size = new System.Drawing.Size(75, 23);
            this.duzenleSil.TabIndex = 35;
            this.duzenleSil.Text = "Sil";
            this.duzenleSil.UseVisualStyleBackColor = true;
            this.duzenleSil.Click += new System.EventHandler(this.duzenleSil_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(138, 80);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 34;
            // 
            // stadyumPenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "stadyumPenWindow";
            this.Text = "Stadyum Penceresi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListele)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDuzenleGoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dgListele;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtdigerstd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stdLigiLabel;
        private System.Windows.Forms.TextBox txtstdsehir;
        private System.Windows.Forms.TextBox txtstdAdi;
        private System.Windows.Forms.Label stdSehir;
        private System.Windows.Forms.Label SporcuAdilabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLigistd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button duzenleGoster;
        private System.Windows.Forms.DataGridView dgDuzenleGoster;
        private System.Windows.Forms.Button duzenleSil;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtarastd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaraStadSoay;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox stdLigiCombo;
    }
}