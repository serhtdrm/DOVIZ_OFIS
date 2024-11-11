namespace doviz_ofis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbleuroalis = new System.Windows.Forms.Label();
            this.lbldolaralis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldolarsatis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbleurosatis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.btndolaral = new System.Windows.Forms.Button();
            this.btndolarsat = new System.Windows.Forms.Button();
            this.btneuroal = new System.Windows.Forms.Button();
            this.btneurosat = new System.Windows.Forms.Button();
            this.btnsatisyap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOLAR ALIŞ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "EURO ALIŞ: ";
            // 
            // lbleuroalis
            // 
            this.lbleuroalis.AutoSize = true;
            this.lbleuroalis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleuroalis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbleuroalis.Location = new System.Drawing.Point(190, 213);
            this.lbleuroalis.Name = "lbleuroalis";
            this.lbleuroalis.Size = new System.Drawing.Size(42, 42);
            this.lbleuroalis.TabIndex = 3;
            this.lbleuroalis.Text = "0";
            // 
            // lbldolaralis
            // 
            this.lbldolaralis.AutoSize = true;
            this.lbldolaralis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolaralis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbldolaralis.Location = new System.Drawing.Point(205, 50);
            this.lbldolaralis.Name = "lbldolaralis";
            this.lbldolaralis.Size = new System.Drawing.Size(42, 42);
            this.lbldolaralis.TabIndex = 4;
            this.lbldolaralis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOLAR SATIŞ: ";
            // 
            // lbldolarsatis
            // 
            this.lbldolarsatis.AutoSize = true;
            this.lbldolarsatis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolarsatis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbldolarsatis.Location = new System.Drawing.Point(233, 128);
            this.lbldolarsatis.Name = "lbldolarsatis";
            this.lbldolarsatis.Size = new System.Drawing.Size(42, 42);
            this.lbldolarsatis.TabIndex = 6;
            this.lbldolarsatis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "EURO SATIŞ: ";
            // 
            // lbleurosatis
            // 
            this.lbleurosatis.AutoSize = true;
            this.lbleurosatis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleurosatis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbleurosatis.Location = new System.Drawing.Point(190, 310);
            this.lbleurosatis.Name = "lbleurosatis";
            this.lbleurosatis.Size = new System.Drawing.Size(42, 42);
            this.lbleurosatis.TabIndex = 8;
            this.lbleurosatis.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(81, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 223);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtkalan
            // 
            this.txtkalan.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkalan.Location = new System.Drawing.Point(78, 173);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(410, 34);
            this.txtkalan.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(-1, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "KALAN: ";
            // 
            // txttutar
            // 
            this.txttutar.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(78, 121);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(410, 34);
            this.txttutar.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(-3, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "TUTAR:";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(78, 69);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(410, 34);
            this.txtmiktar.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(-3, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "MİKTAR: ";
            // 
            // txtkur
            // 
            this.txtkur.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkur.Location = new System.Drawing.Point(78, 19);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(410, 34);
            this.txtkur.TabIndex = 11;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "KUR: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsatisyap.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsatisyap.Location = new System.Drawing.Point(677, 542);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(214, 82);
            this.btnsatisyap.TabIndex = 10;
            this.btnsatisyap.Text = "€-$/TL";
            this.btnsatisyap.UseVisualStyleBackColor = false;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // btndolaral
            // 
            this.btndolaral.Location = new System.Drawing.Point(384, 51);
            this.btndolaral.Name = "btndolaral";
            this.btndolaral.Size = new System.Drawing.Size(39, 40);
            this.btndolaral.TabIndex = 11;
            this.btndolaral.Text = "...";
            this.btndolaral.UseVisualStyleBackColor = true;
            this.btndolaral.Click += new System.EventHandler(this.btndolaral_Click);
            // 
            // btndolarsat
            // 
            this.btndolarsat.Location = new System.Drawing.Point(384, 130);
            this.btndolarsat.Name = "btndolarsat";
            this.btndolarsat.Size = new System.Drawing.Size(39, 40);
            this.btndolarsat.TabIndex = 12;
            this.btndolarsat.Text = "...";
            this.btndolarsat.UseVisualStyleBackColor = true;
            this.btndolarsat.Click += new System.EventHandler(this.btndolarsat_Click);
            // 
            // btneuroal
            // 
            this.btneuroal.Location = new System.Drawing.Point(384, 222);
            this.btneuroal.Name = "btneuroal";
            this.btneuroal.Size = new System.Drawing.Size(39, 40);
            this.btneuroal.TabIndex = 13;
            this.btneuroal.Text = "...";
            this.btneuroal.UseVisualStyleBackColor = true;
            this.btneuroal.Click += new System.EventHandler(this.btneuroal_Click);
            // 
            // btneurosat
            // 
            this.btneurosat.Location = new System.Drawing.Point(384, 312);
            this.btneurosat.Name = "btneurosat";
            this.btneurosat.Size = new System.Drawing.Size(39, 40);
            this.btneurosat.TabIndex = 14;
            this.btneurosat.Text = "...";
            this.btneurosat.UseVisualStyleBackColor = true;
            this.btneurosat.Click += new System.EventHandler(this.btneurosat_Click);
            // 
            // btnsatisyap2
            // 
            this.btnsatisyap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsatisyap2.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsatisyap2.Location = new System.Drawing.Point(677, 429);
            this.btnsatisyap2.Name = "btnsatisyap2";
            this.btnsatisyap2.Size = new System.Drawing.Size(214, 82);
            this.btnsatisyap2.TabIndex = 15;
            this.btnsatisyap2.Text = "TL/€-$";
            this.btnsatisyap2.UseVisualStyleBackColor = false;
            this.btnsatisyap2.Click += new System.EventHandler(this.btnsatisyap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doviz_ofis.Properties.Resources.doviz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 636);
            this.Controls.Add(this.btnsatisyap2);
            this.Controls.Add(this.btneurosat);
            this.Controls.Add(this.btneuroal);
            this.Controls.Add(this.btndolarsat);
            this.Controls.Add(this.btndolaral);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbleurosatis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldolarsatis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldolaralis);
            this.Controls.Add(this.lbleuroalis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbleuroalis;
        private System.Windows.Forms.Label lbldolaralis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldolarsatis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbleurosatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Button btndolaral;
        private System.Windows.Forms.Button btndolarsat;
        private System.Windows.Forms.Button btneuroal;
        private System.Windows.Forms.Button btneurosat;
        private System.Windows.Forms.Button btnsatisyap2;
    }
}

