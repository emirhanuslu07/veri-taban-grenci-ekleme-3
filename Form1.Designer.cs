﻿namespace WinFormsApp_EF_iliskiliTablolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl_ana = new TabControl();
            tabPage_OgrListe = new TabPage();
            button1 = new Button();
            comboBox_SnfSec = new ComboBox();
            dataGridView_OgrListe = new DataGridView();
            tabPage_ayarlar = new TabPage();
            tabControl_Ayarlar = new TabControl();
            tabPage_Ayar_Ogr = new TabPage();
            button_Ogr_Kaydet = new Button();
            comboBox_Ayar_Snf = new ComboBox();
            textBox_Ogr_Soyad = new TextBox();
            textBox_Ogr_Ad = new TextBox();
            textBox_Ogr_Okulno = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage_Ayar_Snf = new TabPage();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tabControl_ana.SuspendLayout();
            tabPage_OgrListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_OgrListe).BeginInit();
            tabPage_ayarlar.SuspendLayout();
            tabControl_Ayarlar.SuspendLayout();
            tabPage_Ayar_Ogr.SuspendLayout();
            tabPage_Ayar_Snf.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_ana
            // 
            tabControl_ana.Controls.Add(tabPage_OgrListe);
            tabControl_ana.Controls.Add(tabPage_ayarlar);
            tabControl_ana.Location = new Point(8, 7);
            tabControl_ana.Margin = new Padding(2);
            tabControl_ana.Name = "tabControl_ana";
            tabControl_ana.SelectedIndex = 0;
            tabControl_ana.Size = new Size(640, 314);
            tabControl_ana.TabIndex = 0;
            // 
            // tabPage_OgrListe
            // 
            tabPage_OgrListe.Controls.Add(button1);
            tabPage_OgrListe.Controls.Add(comboBox_SnfSec);
            tabPage_OgrListe.Controls.Add(dataGridView_OgrListe);
            tabPage_OgrListe.Location = new Point(4, 24);
            tabPage_OgrListe.Margin = new Padding(2);
            tabPage_OgrListe.Name = "tabPage_OgrListe";
            tabPage_OgrListe.Padding = new Padding(2);
            tabPage_OgrListe.Size = new Size(632, 286);
            tabPage_OgrListe.TabIndex = 0;
            tabPage_OgrListe.Text = "Sınıf Listeleri";
            tabPage_OgrListe.UseVisualStyleBackColor = true;
            tabPage_OgrListe.Click += tabPage_OgrListe_Click;
            // 
            // button1
            // 
            button1.Location = new Point(528, 3);
            button1.Name = "button1";
            button1.Size = new Size(99, 24);
            button1.TabIndex = 2;
            button1.Text = "Ogrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_SnfSec
            // 
            comboBox_SnfSec.FormattingEnabled = true;
            comboBox_SnfSec.Location = new Point(4, 5);
            comboBox_SnfSec.Margin = new Padding(2);
            comboBox_SnfSec.Name = "comboBox_SnfSec";
            comboBox_SnfSec.Size = new Size(162, 23);
            comboBox_SnfSec.TabIndex = 1;
            comboBox_SnfSec.SelectedIndexChanged += comboBox_SnfSec_SelectedIndexChanged;
            // 
            // dataGridView_OgrListe
            // 
            dataGridView_OgrListe.AllowUserToAddRows = false;
            dataGridView_OgrListe.AllowUserToDeleteRows = false;
            dataGridView_OgrListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_OgrListe.Location = new Point(4, 31);
            dataGridView_OgrListe.Margin = new Padding(2);
            dataGridView_OgrListe.Name = "dataGridView_OgrListe";
            dataGridView_OgrListe.RowHeadersWidth = 62;
            dataGridView_OgrListe.Size = new Size(626, 249);
            dataGridView_OgrListe.TabIndex = 0;
            dataGridView_OgrListe.CellContentClick += dataGridView_OgrListe_CellContentClick;
            dataGridView_OgrListe.CellValueChanged += dataGridView_OgrListe_CellValueChanged;
            // 
            // tabPage_ayarlar
            // 
            tabPage_ayarlar.Controls.Add(tabControl_Ayarlar);
            tabPage_ayarlar.Location = new Point(4, 24);
            tabPage_ayarlar.Margin = new Padding(2);
            tabPage_ayarlar.Name = "tabPage_ayarlar";
            tabPage_ayarlar.Padding = new Padding(2);
            tabPage_ayarlar.Size = new Size(632, 286);
            tabPage_ayarlar.TabIndex = 1;
            tabPage_ayarlar.Text = "Ayarlar";
            tabPage_ayarlar.UseVisualStyleBackColor = true;
            // 
            // tabControl_Ayarlar
            // 
            tabControl_Ayarlar.Controls.Add(tabPage_Ayar_Ogr);
            tabControl_Ayarlar.Controls.Add(tabPage_Ayar_Snf);
            tabControl_Ayarlar.Location = new Point(5, 5);
            tabControl_Ayarlar.Name = "tabControl_Ayarlar";
            tabControl_Ayarlar.SelectedIndex = 0;
            tabControl_Ayarlar.Size = new Size(624, 276);
            tabControl_Ayarlar.TabIndex = 0;
            // 
            // tabPage_Ayar_Ogr
            // 
            tabPage_Ayar_Ogr.Controls.Add(button_Ogr_Kaydet);
            tabPage_Ayar_Ogr.Controls.Add(comboBox_Ayar_Snf);
            tabPage_Ayar_Ogr.Controls.Add(textBox_Ogr_Soyad);
            tabPage_Ayar_Ogr.Controls.Add(textBox_Ogr_Ad);
            tabPage_Ayar_Ogr.Controls.Add(textBox_Ogr_Okulno);
            tabPage_Ayar_Ogr.Controls.Add(label4);
            tabPage_Ayar_Ogr.Controls.Add(label3);
            tabPage_Ayar_Ogr.Controls.Add(label2);
            tabPage_Ayar_Ogr.Controls.Add(label1);
            tabPage_Ayar_Ogr.Location = new Point(4, 24);
            tabPage_Ayar_Ogr.Name = "tabPage_Ayar_Ogr";
            tabPage_Ayar_Ogr.Padding = new Padding(3);
            tabPage_Ayar_Ogr.Size = new Size(616, 248);
            tabPage_Ayar_Ogr.TabIndex = 0;
            tabPage_Ayar_Ogr.Text = "Öğrenci";
            tabPage_Ayar_Ogr.UseVisualStyleBackColor = true;
            // 
            // button_Ogr_Kaydet
            // 
            button_Ogr_Kaydet.Location = new Point(6, 139);
            button_Ogr_Kaydet.Name = "button_Ogr_Kaydet";
            button_Ogr_Kaydet.Size = new Size(163, 23);
            button_Ogr_Kaydet.TabIndex = 8;
            button_Ogr_Kaydet.Text = "KAYDET";
            button_Ogr_Kaydet.UseVisualStyleBackColor = true;
            button_Ogr_Kaydet.Click += button_Ogr_Kaydet_Click;
            // 
            // comboBox_Ayar_Snf
            // 
            comboBox_Ayar_Snf.FormattingEnabled = true;
            comboBox_Ayar_Snf.Location = new Point(69, 101);
            comboBox_Ayar_Snf.Name = "comboBox_Ayar_Snf";
            comboBox_Ayar_Snf.Size = new Size(100, 23);
            comboBox_Ayar_Snf.TabIndex = 7;
            // 
            // textBox_Ogr_Soyad
            // 
            textBox_Ogr_Soyad.Location = new Point(69, 71);
            textBox_Ogr_Soyad.Name = "textBox_Ogr_Soyad";
            textBox_Ogr_Soyad.Size = new Size(100, 23);
            textBox_Ogr_Soyad.TabIndex = 6;
            // 
            // textBox_Ogr_Ad
            // 
            textBox_Ogr_Ad.Location = new Point(69, 43);
            textBox_Ogr_Ad.Name = "textBox_Ogr_Ad";
            textBox_Ogr_Ad.Size = new Size(100, 23);
            textBox_Ogr_Ad.TabIndex = 5;
            // 
            // textBox_Ogr_Okulno
            // 
            textBox_Ogr_Okulno.Location = new Point(69, 15);
            textBox_Ogr_Okulno.Name = "textBox_Ogr_Okulno";
            textBox_Ogr_Okulno.Size = new Size(100, 23);
            textBox_Ogr_Okulno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 101);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Sınıf :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 46);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Okul No :";
            // 
            // tabPage_Ayar_Snf
            // 
            tabPage_Ayar_Snf.Controls.Add(button2);
            tabPage_Ayar_Snf.Controls.Add(textBox2);
            tabPage_Ayar_Snf.Controls.Add(textBox1);
            tabPage_Ayar_Snf.Controls.Add(label6);
            tabPage_Ayar_Snf.Controls.Add(label5);
            tabPage_Ayar_Snf.Location = new Point(4, 24);
            tabPage_Ayar_Snf.Name = "tabPage_Ayar_Snf";
            tabPage_Ayar_Snf.Padding = new Padding(3);
            tabPage_Ayar_Snf.Size = new Size(616, 248);
            tabPage_Ayar_Snf.TabIndex = 1;
            tabPage_Ayar_Snf.Text = "Sınıf";
            tabPage_Ayar_Snf.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 58);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 1;
            label6.Text = "Şube :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 20);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 0;
            label5.Text = "Seviye :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 325);
            Controls.Add(tabControl_ana);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Ogrenci Otomasyonu";
            Load += Form1_Load;
            tabControl_ana.ResumeLayout(false);
            tabPage_OgrListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_OgrListe).EndInit();
            tabPage_ayarlar.ResumeLayout(false);
            tabControl_Ayarlar.ResumeLayout(false);
            tabPage_Ayar_Ogr.ResumeLayout(false);
            tabPage_Ayar_Ogr.PerformLayout();
            tabPage_Ayar_Snf.ResumeLayout(false);
            tabPage_Ayar_Snf.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_ana;
        private TabPage tabPage_OgrListe;
        private TabPage tabPage_ayarlar;
        private DataGridView dataGridView_OgrListe;
        private ComboBox comboBox_SnfSec;
        private Button button1;
        private TabControl tabControl_Ayarlar;
        private TabPage tabPage_Ayar_Ogr;
        private TabPage tabPage_Ayar_Snf;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_Ogr_Kaydet;
        private ComboBox comboBox_Ayar_Snf;
        private TextBox textBox_Ogr_Soyad;
        private TextBox textBox_Ogr_Ad;
        private TextBox textBox_Ogr_Okulno;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
    }
}
