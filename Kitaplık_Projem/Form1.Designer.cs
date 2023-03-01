namespace Kitaplık_Projem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.rchkullanılmıs = new System.Windows.Forms.RadioButton();
            this.rchsıfır = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkitapara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ıd :";
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Location = new System.Drawing.Point(187, 9);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(207, 28);
            this.txtıd.TabIndex = 2;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(187, 122);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(207, 28);
            this.txtsayfa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayfa :";
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(187, 87);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(207, 28);
            this.txtyazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(187, 46);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(207, 28);
            this.txtad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kitap ad :";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Lime;
            this.btnkaydet.Location = new System.Drawing.Point(419, 8);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(111, 41);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.Yellow;
            this.btngüncelle.Location = new System.Drawing.Point(419, 150);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(111, 42);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlistele.Location = new System.Drawing.Point(419, 55);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(111, 41);
            this.btnlistele.TabIndex = 11;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Location = new System.Drawing.Point(419, 102);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(111, 41);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tür :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Durum :";
            // 
            // cmbtur
            // 
            this.cmbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "Hikaye",
            "Şiir ",
            "Tiyatro",
            "Roman"});
            this.cmbtur.Location = new System.Drawing.Point(187, 157);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(207, 30);
            this.cmbtur.TabIndex = 15;
            // 
            // rchkullanılmıs
            // 
            this.rchkullanılmıs.AutoSize = true;
            this.rchkullanılmıs.Location = new System.Drawing.Point(187, 193);
            this.rchkullanılmıs.Name = "rchkullanılmıs";
            this.rchkullanılmıs.Size = new System.Drawing.Size(131, 26);
            this.rchkullanılmıs.TabIndex = 16;
            this.rchkullanılmıs.TabStop = true;
            this.rchkullanılmıs.Text = "Paketi Açık";
            this.rchkullanılmıs.UseVisualStyleBackColor = true;
            this.rchkullanılmıs.CheckedChanged += new System.EventHandler(this.rchkullanılmıs_CheckedChanged);
            // 
            // rchsıfır
            // 
            this.rchsıfır.AutoSize = true;
            this.rchsıfır.Location = new System.Drawing.Point(327, 193);
            this.rchsıfır.Name = "rchsıfır";
            this.rchsıfır.Size = new System.Drawing.Size(67, 26);
            this.rchsıfır.TabIndex = 17;
            this.rchsıfır.TabStop = true;
            this.rchsıfır.Text = "Sıfır";
            this.rchsıfır.UseVisualStyleBackColor = true;
            this.rchsıfır.CheckedChanged += new System.EventHandler(this.rchsıfır_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(580, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "KÜTÜPHANEM";
            // 
            // txtkitapara
            // 
            this.txtkitapara.Location = new System.Drawing.Point(639, 171);
            this.txtkitapara.Name = "txtkitapara";
            this.txtkitapara.Size = new System.Drawing.Size(147, 28);
            this.txtkitapara.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kitap ad :";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Fuchsia;
            this.btnara.Location = new System.Drawing.Point(670, 202);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(76, 31);
            this.btnara.TabIndex = 23;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(793, 407);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtkitapara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rchsıfır);
            this.Controls.Add(this.rchkullanılmıs);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.RadioButton rchkullanılmıs;
        private System.Windows.Forms.RadioButton rchsıfır;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkitapara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnara;
    }
}

