namespace yemekçilik
{
    partial class Formmasa2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.masa2idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anayemekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbalarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceklerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatlılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masa2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekcilikDataSet1 = new yemekçilik.yemekcilikDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncık2 = new System.Windows.Forms.Button();
            this.Btngün2 = new System.Windows.Forms.Button();
            this.btnsil2 = new System.Windows.Forms.Button();
            this.cmbtatlı2 = new System.Windows.Forms.ComboBox();
            this.cmbicecek2 = new System.Windows.Forms.ComboBox();
            this.cmbcorba2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnal2 = new System.Windows.Forms.Button();
            this.cmbana2 = new System.Windows.Forms.ComboBox();
            this.txtmasa2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.masa2TableAdapter = new yemekçilik.yemekcilikDataSet1TableAdapters.masa2TableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(562, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 295);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparisler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masa2idDataGridViewTextBoxColumn,
            this.anayemekDataGridViewTextBoxColumn,
            this.corbalarDataGridViewTextBoxColumn,
            this.iceceklerDataGridViewTextBoxColumn,
            this.tatlılarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.masa2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(403, 273);
            this.dataGridView2.TabIndex = 14;
            // 
            // masa2idDataGridViewTextBoxColumn
            // 
            this.masa2idDataGridViewTextBoxColumn.DataPropertyName = "masa2id";
            this.masa2idDataGridViewTextBoxColumn.HeaderText = "masa2id";
            this.masa2idDataGridViewTextBoxColumn.Name = "masa2idDataGridViewTextBoxColumn";
            this.masa2idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anayemekDataGridViewTextBoxColumn
            // 
            this.anayemekDataGridViewTextBoxColumn.DataPropertyName = "Anayemek";
            this.anayemekDataGridViewTextBoxColumn.HeaderText = "Anayemek";
            this.anayemekDataGridViewTextBoxColumn.Name = "anayemekDataGridViewTextBoxColumn";
            // 
            // corbalarDataGridViewTextBoxColumn
            // 
            this.corbalarDataGridViewTextBoxColumn.DataPropertyName = "Corbalar";
            this.corbalarDataGridViewTextBoxColumn.HeaderText = "Corbalar";
            this.corbalarDataGridViewTextBoxColumn.Name = "corbalarDataGridViewTextBoxColumn";
            // 
            // iceceklerDataGridViewTextBoxColumn
            // 
            this.iceceklerDataGridViewTextBoxColumn.DataPropertyName = "İcecekler";
            this.iceceklerDataGridViewTextBoxColumn.HeaderText = "İcecekler";
            this.iceceklerDataGridViewTextBoxColumn.Name = "iceceklerDataGridViewTextBoxColumn";
            // 
            // tatlılarDataGridViewTextBoxColumn
            // 
            this.tatlılarDataGridViewTextBoxColumn.DataPropertyName = "Tatlılar";
            this.tatlılarDataGridViewTextBoxColumn.HeaderText = "Tatlılar";
            this.tatlılarDataGridViewTextBoxColumn.Name = "tatlılarDataGridViewTextBoxColumn";
            // 
            // masa2BindingSource
            // 
            this.masa2BindingSource.DataMember = "masa2";
            this.masa2BindingSource.DataSource = this.yemekcilikDataSet1;
            // 
            // yemekcilikDataSet1
            // 
            this.yemekcilikDataSet1.DataSetName = "yemekcilikDataSet1";
            this.yemekcilikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btncık2);
            this.groupBox1.Controls.Add(this.Btngün2);
            this.groupBox1.Controls.Add(this.btnsil2);
            this.groupBox1.Controls.Add(this.cmbtatlı2);
            this.groupBox1.Controls.Add(this.cmbicecek2);
            this.groupBox1.Controls.Add(this.cmbcorba2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnal2);
            this.groupBox1.Controls.Add(this.cmbana2);
            this.groupBox1.Controls.Add(this.txtmasa2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 290);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btncık2
            // 
            this.btncık2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncık2.ForeColor = System.Drawing.Color.Crimson;
            this.btncık2.Location = new System.Drawing.Point(360, 218);
            this.btncık2.Name = "btncık2";
            this.btncık2.Size = new System.Drawing.Size(136, 39);
            this.btncık2.TabIndex = 27;
            this.btncık2.Text = "Masadan Cık";
            this.btncık2.UseVisualStyleBackColor = true;
            this.btncık2.Click += new System.EventHandler(this.btncık2_Click);
            // 
            // Btngün2
            // 
            this.Btngün2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün2.ForeColor = System.Drawing.Color.Crimson;
            this.Btngün2.Location = new System.Drawing.Point(360, 155);
            this.Btngün2.Name = "Btngün2";
            this.Btngün2.Size = new System.Drawing.Size(136, 39);
            this.Btngün2.TabIndex = 26;
            this.Btngün2.Text = "Siparis Güncelle";
            this.Btngün2.UseVisualStyleBackColor = true;
            this.Btngün2.Click += new System.EventHandler(this.Btngün2_Click);
            // 
            // btnsil2
            // 
            this.btnsil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil2.ForeColor = System.Drawing.Color.Crimson;
            this.btnsil2.Location = new System.Drawing.Point(360, 93);
            this.btnsil2.Name = "btnsil2";
            this.btnsil2.Size = new System.Drawing.Size(136, 39);
            this.btnsil2.TabIndex = 25;
            this.btnsil2.Text = "Siparis Sil";
            this.btnsil2.UseVisualStyleBackColor = true;
            this.btnsil2.Click += new System.EventHandler(this.btnsil2_Click);
            // 
            // cmbtatlı2
            // 
            this.cmbtatlı2.ForeColor = System.Drawing.Color.Crimson;
            this.cmbtatlı2.FormattingEnabled = true;
            this.cmbtatlı2.Items.AddRange(new object[] {
            "Baklava",
            "Künefe"});
            this.cmbtatlı2.Location = new System.Drawing.Point(145, 232);
            this.cmbtatlı2.Name = "cmbtatlı2";
            this.cmbtatlı2.Size = new System.Drawing.Size(151, 21);
            this.cmbtatlı2.TabIndex = 24;
            // 
            // cmbicecek2
            // 
            this.cmbicecek2.ForeColor = System.Drawing.Color.Crimson;
            this.cmbicecek2.FormattingEnabled = true;
            this.cmbicecek2.Items.AddRange(new object[] {
            "Ayran",
            "Şalgam",
            "330 ccl Pepsi",
            "330 ccl Fanta",
            "Su"});
            this.cmbicecek2.Location = new System.Drawing.Point(145, 186);
            this.cmbicecek2.Name = "cmbicecek2";
            this.cmbicecek2.Size = new System.Drawing.Size(151, 21);
            this.cmbicecek2.TabIndex = 23;
            // 
            // cmbcorba2
            // 
            this.cmbcorba2.ForeColor = System.Drawing.Color.Crimson;
            this.cmbcorba2.FormattingEnabled = true;
            this.cmbcorba2.Items.AddRange(new object[] {
            "Mercimek",
            "Tarhana",
            "Kelle-Paça",
            "Sebezli"});
            this.cmbcorba2.Location = new System.Drawing.Point(145, 136);
            this.cmbcorba2.Name = "cmbcorba2";
            this.cmbcorba2.Size = new System.Drawing.Size(151, 21);
            this.cmbcorba2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(16, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tatlı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "İcecek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Corba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Anayemek";
            // 
            // btnal2
            // 
            this.btnal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnal2.ForeColor = System.Drawing.Color.Crimson;
            this.btnal2.Location = new System.Drawing.Point(360, 28);
            this.btnal2.Name = "btnal2";
            this.btnal2.Size = new System.Drawing.Size(136, 39);
            this.btnal2.TabIndex = 17;
            this.btnal2.Text = "Siparis Al";
            this.btnal2.UseVisualStyleBackColor = true;
            this.btnal2.Click += new System.EventHandler(this.btnal2_Click);
            // 
            // cmbana2
            // 
            this.cmbana2.ForeColor = System.Drawing.Color.Crimson;
            this.cmbana2.FormattingEnabled = true;
            this.cmbana2.Items.AddRange(new object[] {
            "Adana Kebap Servis",
            "Et Döner",
            "Tavuk Döner",
            "Mantı",
            "Elbistan Tava",
            "Beyti",
            "İçli Köfte"});
            this.cmbana2.Location = new System.Drawing.Point(145, 79);
            this.cmbana2.Name = "cmbana2";
            this.cmbana2.Size = new System.Drawing.Size(151, 21);
            this.cmbana2.TabIndex = 16;
            // 
            // txtmasa2
            // 
            this.txtmasa2.ForeColor = System.Drawing.Color.Crimson;
            this.txtmasa2.Location = new System.Drawing.Point(145, 33);
            this.txtmasa2.Name = "txtmasa2";
            this.txtmasa2.Size = new System.Drawing.Size(151, 20);
            this.txtmasa2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masa 2";
            // 
            // masa2TableAdapter
            // 
            this.masa2TableAdapter.ClearBeforeFill = true;
            // 
            // Formmasa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1000, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formmasa2";
            this.Text = "MASA 2";
            this.Load += new System.EventHandler(this.Formmasa2_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncık2;
        private System.Windows.Forms.Button Btngün2;
        private System.Windows.Forms.Button btnsil2;
        private System.Windows.Forms.ComboBox cmbtatlı2;
        private System.Windows.Forms.ComboBox cmbicecek2;
        private System.Windows.Forms.ComboBox cmbcorba2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnal2;
        private System.Windows.Forms.ComboBox cmbana2;
        private System.Windows.Forms.TextBox txtmasa2;
        private System.Windows.Forms.Label label1;
        private yemekcilikDataSet1 yemekcilikDataSet1;
        private System.Windows.Forms.BindingSource masa2BindingSource;
        private yemekcilikDataSet1TableAdapters.masa2TableAdapter masa2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masa2idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anayemekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corbalarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceceklerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatlılarDataGridViewTextBoxColumn;
    }
}