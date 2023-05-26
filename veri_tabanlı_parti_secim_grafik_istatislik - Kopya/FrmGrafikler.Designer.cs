namespace veri_tabanlı_parti_secim_grafik_istatislik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dBSECIMPRIJEDataSet = new veri_tabanlı_parti_secim_grafik_istatislik.DBSECIMPRIJEDataSet();
            this.tBLILCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLILCETableAdapter = new veri_tabanlı_parti_secim_grafik_istatislik.DBSECIMPRIJEDataSetTableAdapters.TBLILCETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSECIMPRIJEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLILCEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAFİKLER ";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 18);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(690, 197);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.lbld);
            this.groupBox2.Controls.Add(this.lble);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(51, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLÇE DEĞERLERİ";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(576, 137);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(14, 16);
            this.lblb.TabIndex = 16;
            this.lblb.Text = "0";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(576, 169);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(14, 16);
            this.lblc.TabIndex = 15;
            this.lblc.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(576, 208);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(14, 16);
            this.lbld.TabIndex = 14;
            this.lbld.Text = "0";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(576, 240);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(14, 16);
            this.lble.TabIndex = 13;
            this.lble.Text = "0";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(576, 97);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(14, 16);
            this.lbla.TabIndex = 12;
            this.lbla.Text = "0";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(165, 240);
            this.progressBar5.Maximum = 150;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(393, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(177, 201);
            this.progressBar4.Maximum = 150;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(381, 23);
            this.progressBar4.TabIndex = 10;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(165, 130);
            this.progressBar3.Maximum = 150;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(393, 23);
            this.progressBar3.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(165, 162);
            this.progressBar2.Maximum = 150;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(393, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "E PARTİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "B PARTİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "C PARTİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "D PARTİ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 90);
            this.progressBar1.Maximum = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBLILCEBindingSource;
            this.comboBox1.DisplayMember = "ILCEAD";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(414, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE SEÇ";
            // 
            // dBSECIMPRIJEDataSet
            // 
            this.dBSECIMPRIJEDataSet.DataSetName = "DBSECIMPRIJEDataSet";
            this.dBSECIMPRIJEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLILCEBindingSource
            // 
            this.tBLILCEBindingSource.DataMember = "TBLILCE";
            this.tBLILCEBindingSource.DataSource = this.dBSECIMPRIJEDataSet;
            // 
            // tBLILCETableAdapter
            // 
            this.tBLILCETableAdapter.ClearBeforeFill = true;
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafikler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGrafikler_FormClosed);
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSECIMPRIJEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLILCEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DBSECIMPRIJEDataSet dBSECIMPRIJEDataSet;
        private System.Windows.Forms.BindingSource tBLILCEBindingSource;
        private DBSECIMPRIJEDataSetTableAdapters.TBLILCETableAdapter tBLILCETableAdapter;
    }
}