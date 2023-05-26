namespace veri_tabanlı_parti_secim_grafik_istatislik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtilcead = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.btnoygiriş = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "A PARTİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "B PARTİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "C PARTİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "D PARTİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "E PARTİ";
            // 
            // txtilcead
            // 
            this.txtilcead.Location = new System.Drawing.Point(173, 41);
            this.txtilcead.Name = "txtilcead";
            this.txtilcead.Size = new System.Drawing.Size(526, 22);
            this.txtilcead.TabIndex = 7;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(173, 112);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(526, 22);
            this.txta.TabIndex = 8;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(173, 154);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(526, 22);
            this.txtb.TabIndex = 9;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(173, 188);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(526, 22);
            this.txtc.TabIndex = 10;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(173, 219);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(526, 22);
            this.txtd.TabIndex = 11;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(173, 254);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(526, 22);
            this.txte.TabIndex = 12;
            // 
            // btnoygiriş
            // 
            this.btnoygiriş.Location = new System.Drawing.Point(119, 285);
            this.btnoygiriş.Name = "btnoygiriş";
            this.btnoygiriş.Size = new System.Drawing.Size(542, 49);
            this.btnoygiriş.TabIndex = 13;
            this.btnoygiriş.Text = "OY GİRİŞ YAP ";
            this.btnoygiriş.UseVisualStyleBackColor = true;
            this.btnoygiriş.Click += new System.EventHandler(this.btnoygiriş_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 51);
            this.button2.TabIndex = 14;
            this.button2.Text = "ÇIKIŞ YAP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(77, 357);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(222, 51);
            this.btngrafikler.TabIndex = 15;
            this.btngrafikler.Text = "GRAFİKLER ";
            this.btngrafikler.UseVisualStyleBackColor = true;
            this.btngrafikler.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngrafikler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnoygiriş);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtilcead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VTGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtilcead;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Button btnoygiriş;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btngrafikler;
    }
}

