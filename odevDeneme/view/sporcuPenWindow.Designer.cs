namespace odevDeneme
{
    partial class sporcuPenWindow
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
            this.listele = new System.Windows.Forms.Button();
            this.dgListele = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdigersporcu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sporcuLigiCombo = new System.Windows.Forms.ComboBox();
            this.sporcuLigiLabel = new System.Windows.Forms.Label();
            this.txtsporcuSoyAdi = new System.Windows.Forms.TextBox();
            this.txtsporcuAdi = new System.Windows.Forms.TextBox();
            this.soyadiSporculabel = new System.Windows.Forms.Label();
            this.SporcuAdilabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsoyadara = new System.Windows.Forms.TextBox();
            this.txtaraSprocu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStadyum = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLigi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 544);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.listele);
            this.tabPage1.Controls.Add(this.dgListele);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtdigersporcu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sporcuLigiCombo);
            this.tabPage1.Controls.Add(this.sporcuLigiLabel);
            this.tabPage1.Controls.Add(this.txtsporcuSoyAdi);
            this.tabPage1.Controls.Add(this.txtsporcuAdi);
            this.tabPage1.Controls.Add(this.soyadiSporculabel);
            this.tabPage1.Controls.Add(this.SporcuAdilabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(135, 125);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(75, 23);
            this.listele.TabIndex = 18;
            this.listele.Text = "Göster";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgListele
            // 
            this.dgListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListele.Location = new System.Drawing.Point(6, 166);
            this.dgListele.Name = "dgListele";
            this.dgListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListele.Size = new System.Drawing.Size(694, 346);
            this.dgListele.TabIndex = 17;
            this.dgListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListele_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdigersporcu
            // 
            this.txtdigersporcu.Location = new System.Drawing.Point(384, 98);
            this.txtdigersporcu.Name = "txtdigersporcu";
            this.txtdigersporcu.Size = new System.Drawing.Size(133, 20);
            this.txtdigersporcu.TabIndex = 7;
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
            // sporcuLigiCombo
            // 
            this.sporcuLigiCombo.FormattingEnabled = true;
            this.sporcuLigiCombo.Location = new System.Drawing.Point(89, 98);
            this.sporcuLigiCombo.Name = "sporcuLigiCombo";
            this.sporcuLigiCombo.Size = new System.Drawing.Size(121, 21);
            this.sporcuLigiCombo.TabIndex = 5;
            // 
            // sporcuLigiLabel
            // 
            this.sporcuLigiLabel.AutoSize = true;
            this.sporcuLigiLabel.Location = new System.Drawing.Point(28, 106);
            this.sporcuLigiLabel.Name = "sporcuLigiLabel";
            this.sporcuLigiLabel.Size = new System.Drawing.Size(23, 13);
            this.sporcuLigiLabel.TabIndex = 4;
            this.sporcuLigiLabel.Text = "Ligi";
            // 
            // txtsporcuSoyAdi
            // 
            this.txtsporcuSoyAdi.Location = new System.Drawing.Point(384, 16);
            this.txtsporcuSoyAdi.Name = "txtsporcuSoyAdi";
            this.txtsporcuSoyAdi.Size = new System.Drawing.Size(133, 20);
            this.txtsporcuSoyAdi.TabIndex = 3;
            // 
            // txtsporcuAdi
            // 
            this.txtsporcuAdi.Location = new System.Drawing.Point(89, 16);
            this.txtsporcuAdi.Name = "txtsporcuAdi";
            this.txtsporcuAdi.Size = new System.Drawing.Size(121, 20);
            this.txtsporcuAdi.TabIndex = 2;
            this.txtsporcuAdi.BackColorChanged += new System.EventHandler(this.txtsporcuAdi_BackColorChanged);
            // 
            // soyadiSporculabel
            // 
            this.soyadiSporculabel.AutoSize = true;
            this.soyadiSporculabel.Location = new System.Drawing.Point(325, 19);
            this.soyadiSporculabel.Name = "soyadiSporculabel";
            this.soyadiSporculabel.Size = new System.Drawing.Size(42, 13);
            this.soyadiSporculabel.TabIndex = 1;
            this.soyadiSporculabel.Text = "Soyadı:";
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
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnStadyum);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.txtDiger);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbLigi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSoyadi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.duzenleGoster);
            this.tabPage2.Controls.Add(this.dgDuzenleGoster);
            this.tabPage2.Controls.Add(this.duzenleSil);
            this.tabPage2.Controls.Add(this.txtAdi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Düzenleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 62;
            this.button3.Text = "Eşleşme Gör";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtsoyadara);
            this.groupBox1.Controls.Add(this.txtaraSprocu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(601, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Soyadı";
            // 
            // txtsoyadara
            // 
            this.txtsoyadara.Location = new System.Drawing.Point(94, 66);
            this.txtsoyadara.Name = "txtsoyadara";
            this.txtsoyadara.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadara.TabIndex = 49;
            this.txtsoyadara.TextChanged += new System.EventHandler(this.txtsoyadara_TextChanged);
            // 
            // txtaraSprocu
            // 
            this.txtaraSprocu.Location = new System.Drawing.Point(94, 29);
            this.txtaraSprocu.Name = "txtaraSprocu";
            this.txtaraSprocu.Size = new System.Drawing.Size(100, 20);
            this.txtaraSprocu.TabIndex = 47;
            this.txtaraSprocu.TextChanged += new System.EventHandler(this.txtaraSprocu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Adı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 27);
            this.button2.TabIndex = 48;
            this.button2.Text = "Hakem Penceresi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnStadyum
            // 
            this.btnStadyum.Location = new System.Drawing.Point(417, 15);
            this.btnStadyum.Name = "btnStadyum";
            this.btnStadyum.Size = new System.Drawing.Size(122, 27);
            this.btnStadyum.TabIndex = 46;
            this.btnStadyum.Text = "Stadyum Penceresi";
            this.btnStadyum.UseVisualStyleBackColor = true;
            this.btnStadyum.Click += new System.EventHandler(this.btnStadyum_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(336, 17);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(404, 131);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(133, 20);
            this.txtDiger.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Diğer:";
            // 
            // cmbLigi
            // 
            this.cmbLigi.FormattingEnabled = true;
            this.cmbLigi.Location = new System.Drawing.Point(80, 131);
            this.cmbLigi.Name = "cmbLigi";
            this.cmbLigi.Size = new System.Drawing.Size(121, 21);
            this.cmbLigi.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ligi";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(404, 70);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(133, 20);
            this.txtSoyadi.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Adı:";
            // 
            // duzenleGoster
            // 
            this.duzenleGoster.Location = new System.Drawing.Point(236, 17);
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
            this.dgDuzenleGoster.DoubleClick += new System.EventHandler(this.dgDuzenleGoster_DoubleClick);
            // 
            // duzenleSil
            // 
            this.duzenleSil.Location = new System.Drawing.Point(141, 17);
            this.duzenleSil.Name = "duzenleSil";
            this.duzenleSil.Size = new System.Drawing.Size(75, 23);
            this.duzenleSil.TabIndex = 35;
            this.duzenleSil.Text = "Sil";
            this.duzenleSil.UseVisualStyleBackColor = true;
            this.duzenleSil.Click += new System.EventHandler(this.duzenleSil_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(80, 70);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 34;
            // 
            // sporcuPenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "sporcuPenWindow";
            this.Text = "Sporcu Penceresi";
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
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.DataGridView dgListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdigersporcu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sporcuLigiCombo;
        private System.Windows.Forms.Label sporcuLigiLabel;
        private System.Windows.Forms.TextBox txtsporcuSoyAdi;
        private System.Windows.Forms.Label soyadiSporculabel;
        private System.Windows.Forms.Label SporcuAdilabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLigi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button duzenleGoster;
        private System.Windows.Forms.DataGridView dgDuzenleGoster;
        private System.Windows.Forms.Button duzenleSil;
        private System.Windows.Forms.Button btnStadyum;
        private System.Windows.Forms.TextBox txtaraSprocu;
        public System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsoyadara;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsporcuAdi;
        private System.Windows.Forms.Button button3;
    }
}