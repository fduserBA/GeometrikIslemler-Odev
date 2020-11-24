namespace GeometrikIslemler_Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bDaire = new System.Windows.Forms.Button();
            this.bKare = new System.Windows.Forms.Button();
            this.bDikDortgen = new System.Windows.Forms.Button();
            this.bEskenarUcgen = new System.Windows.Forms.Button();
            this.bDikUcgen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUzunKenar = new System.Windows.Forms.TextBox();
            this.tbDUzunKenar = new System.Windows.Forms.TextBox();
            this.tbDKisaKenar = new System.Windows.Forms.TextBox();
            this.tbKenar = new System.Windows.Forms.TextBox();
            this.tbDDKenar = new System.Windows.Forms.TextBox();
            this.tbDUKenar = new System.Windows.Forms.TextBox();
            this.lDaire = new System.Windows.Forms.Label();
            this.lKare = new System.Windows.Forms.Label();
            this.lDikDortgen = new System.Windows.Forms.Label();
            this.lEskenarUcgen = new System.Windows.Forms.Label();
            this.lDikUcgen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // bDaire
            // 
            this.bDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDaire.Location = new System.Drawing.Point(24, 21);
            this.bDaire.Name = "bDaire";
            this.bDaire.Size = new System.Drawing.Size(183, 117);
            this.bDaire.TabIndex = 0;
            this.bDaire.Text = "Daire Hesaplama";
            this.bDaire.UseVisualStyleBackColor = true;
            this.bDaire.Click += new System.EventHandler(this.bDaire_Click);
            // 
            // bKare
            // 
            this.bKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKare.Location = new System.Drawing.Point(24, 144);
            this.bKare.Name = "bKare";
            this.bKare.Size = new System.Drawing.Size(183, 117);
            this.bKare.TabIndex = 0;
            this.bKare.Text = "Kare Hesaplama";
            this.bKare.UseVisualStyleBackColor = true;
            this.bKare.Click += new System.EventHandler(this.bKare_Click);
            // 
            // bDikDortgen
            // 
            this.bDikDortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDikDortgen.Location = new System.Drawing.Point(24, 267);
            this.bDikDortgen.Name = "bDikDortgen";
            this.bDikDortgen.Size = new System.Drawing.Size(183, 117);
            this.bDikDortgen.TabIndex = 0;
            this.bDikDortgen.Text = "Dik Dörtgen Hesaplama";
            this.bDikDortgen.UseVisualStyleBackColor = true;
            this.bDikDortgen.Click += new System.EventHandler(this.bDikDortgen_Click);
            // 
            // bEskenarUcgen
            // 
            this.bEskenarUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEskenarUcgen.Location = new System.Drawing.Point(24, 390);
            this.bEskenarUcgen.Name = "bEskenarUcgen";
            this.bEskenarUcgen.Size = new System.Drawing.Size(183, 117);
            this.bEskenarUcgen.TabIndex = 0;
            this.bEskenarUcgen.Text = "Eşkenar Üçken Hesaplama";
            this.bEskenarUcgen.UseVisualStyleBackColor = true;
            this.bEskenarUcgen.Click += new System.EventHandler(this.bEskenarUcgen_Click);
            // 
            // bDikUcgen
            // 
            this.bDikUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDikUcgen.Location = new System.Drawing.Point(24, 513);
            this.bDikUcgen.Name = "bDikUcgen";
            this.bDikUcgen.Size = new System.Drawing.Size(183, 117);
            this.bDikUcgen.TabIndex = 0;
            this.bDikUcgen.Text = "Dik Üçken Hesaplama";
            this.bDikUcgen.UseVisualStyleBackColor = true;
            this.bDikUcgen.Click += new System.EventHandler(this.bDikUcgen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(241, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(241, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(241, 390);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 117);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(241, 513);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 117);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // tbYariCap
            // 
            this.tbYariCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYariCap.Location = new System.Drawing.Point(647, 64);
            this.tbYariCap.Multiline = true;
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(227, 47);
            this.tbYariCap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(383, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yarıçapı Girin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(383, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kenar Uzunluğunu Girin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(383, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uzun Kenarı Girin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(383, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kısa Kenarı Girin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(383, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 68);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kenar Uzunluğunu Girin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(383, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 47);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dik Kenarı Girin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(383, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 70);
            this.label8.TabIndex = 3;
            this.label8.Text = "Taban Uzunluğunu Girin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUzunKenar
            // 
            this.tbUzunKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUzunKenar.Location = new System.Drawing.Point(647, 164);
            this.tbUzunKenar.Multiline = true;
            this.tbUzunKenar.Name = "tbUzunKenar";
            this.tbUzunKenar.Size = new System.Drawing.Size(227, 47);
            this.tbUzunKenar.TabIndex = 2;
            // 
            // tbDUzunKenar
            // 
            this.tbDUzunKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDUzunKenar.Location = new System.Drawing.Point(643, 272);
            this.tbDUzunKenar.Multiline = true;
            this.tbDUzunKenar.Name = "tbDUzunKenar";
            this.tbDUzunKenar.Size = new System.Drawing.Size(227, 47);
            this.tbDUzunKenar.TabIndex = 2;
            // 
            // tbDKisaKenar
            // 
            this.tbDKisaKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDKisaKenar.Location = new System.Drawing.Point(643, 325);
            this.tbDKisaKenar.Multiline = true;
            this.tbDKisaKenar.Name = "tbDKisaKenar";
            this.tbDKisaKenar.Size = new System.Drawing.Size(227, 47);
            this.tbDKisaKenar.TabIndex = 2;
            // 
            // tbKenar
            // 
            this.tbKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKenar.Location = new System.Drawing.Point(647, 406);
            this.tbKenar.Multiline = true;
            this.tbKenar.Name = "tbKenar";
            this.tbKenar.Size = new System.Drawing.Size(227, 47);
            this.tbKenar.TabIndex = 2;
            // 
            // tbDDKenar
            // 
            this.tbDDKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDDKenar.Location = new System.Drawing.Point(643, 518);
            this.tbDDKenar.Multiline = true;
            this.tbDDKenar.Name = "tbDDKenar";
            this.tbDDKenar.Size = new System.Drawing.Size(227, 47);
            this.tbDDKenar.TabIndex = 2;
            // 
            // tbDUKenar
            // 
            this.tbDUKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDUKenar.Location = new System.Drawing.Point(643, 571);
            this.tbDUKenar.Multiline = true;
            this.tbDUKenar.Name = "tbDUKenar";
            this.tbDUKenar.Size = new System.Drawing.Size(227, 47);
            this.tbDUKenar.TabIndex = 2;
            // 
            // lDaire
            // 
            this.lDaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDaire.Location = new System.Drawing.Point(911, 21);
            this.lDaire.Name = "lDaire";
            this.lDaire.Size = new System.Drawing.Size(230, 117);
            this.lDaire.TabIndex = 4;
            // 
            // lKare
            // 
            this.lKare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKare.Location = new System.Drawing.Point(911, 144);
            this.lKare.Name = "lKare";
            this.lKare.Size = new System.Drawing.Size(230, 117);
            this.lKare.TabIndex = 4;
            // 
            // lDikDortgen
            // 
            this.lDikDortgen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lDikDortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDikDortgen.Location = new System.Drawing.Point(911, 267);
            this.lDikDortgen.Name = "lDikDortgen";
            this.lDikDortgen.Size = new System.Drawing.Size(230, 117);
            this.lDikDortgen.TabIndex = 4;
            // 
            // lEskenarUcgen
            // 
            this.lEskenarUcgen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lEskenarUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lEskenarUcgen.Location = new System.Drawing.Point(911, 390);
            this.lEskenarUcgen.Name = "lEskenarUcgen";
            this.lEskenarUcgen.Size = new System.Drawing.Size(230, 117);
            this.lEskenarUcgen.TabIndex = 4;
            // 
            // lDikUcgen
            // 
            this.lDikUcgen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lDikUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDikUcgen.Location = new System.Drawing.Point(911, 513);
            this.lDikUcgen.Name = "lDikUcgen";
            this.lDikUcgen.Size = new System.Drawing.Size(230, 117);
            this.lDikUcgen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.lDikUcgen);
            this.Controls.Add(this.lEskenarUcgen);
            this.Controls.Add(this.lDikDortgen);
            this.Controls.Add(this.lKare);
            this.Controls.Add(this.lDaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDUKenar);
            this.Controls.Add(this.tbDDKenar);
            this.Controls.Add(this.tbKenar);
            this.Controls.Add(this.tbDKisaKenar);
            this.Controls.Add(this.tbDUzunKenar);
            this.Controls.Add(this.tbUzunKenar);
            this.Controls.Add(this.tbYariCap);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bDikUcgen);
            this.Controls.Add(this.bEskenarUcgen);
            this.Controls.Add(this.bDikDortgen);
            this.Controls.Add(this.bKare);
            this.Controls.Add(this.bDaire);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDaire;
        private System.Windows.Forms.Button bKare;
        private System.Windows.Forms.Button bDikDortgen;
        private System.Windows.Forms.Button bEskenarUcgen;
        private System.Windows.Forms.Button bDikUcgen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbYariCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUzunKenar;
        private System.Windows.Forms.TextBox tbDUzunKenar;
        private System.Windows.Forms.TextBox tbDKisaKenar;
        private System.Windows.Forms.TextBox tbKenar;
        private System.Windows.Forms.TextBox tbDDKenar;
        private System.Windows.Forms.TextBox tbDUKenar;
        private System.Windows.Forms.Label lDaire;
        private System.Windows.Forms.Label lKare;
        private System.Windows.Forms.Label lDikDortgen;
        private System.Windows.Forms.Label lEskenarUcgen;
        private System.Windows.Forms.Label lDikUcgen;
    }
}

