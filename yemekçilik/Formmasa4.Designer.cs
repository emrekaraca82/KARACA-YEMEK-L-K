namespace yemekçilik
{
    partial class Formmasa4
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncık4 = new System.Windows.Forms.Button();
            this.Btngün4 = new System.Windows.Forms.Button();
            this.btnsil4 = new System.Windows.Forms.Button();
            this.cmbtatlı4 = new System.Windows.Forms.ComboBox();
            this.cmbicecek4 = new System.Windows.Forms.ComboBox();
            this.cmbcorba4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnal4 = new System.Windows.Forms.Button();
            this.cmbana4 = new System.Windows.Forms.ComboBox();
            this.txtmasa4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yemekcilikDataSet3 = new yemekçilik.yemekcilikDataSet3();
            this.masa4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masa4TableAdapter = new yemekçilik.yemekcilikDataSet3TableAdapters.masa4TableAdapter();
            this.masa4idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anayemekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceklerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatlılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Location = new System.Drawing.Point(552, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 295);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparisler";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masa4idDataGridViewTextBoxColumn,
            this.anayemekDataGridViewTextBoxColumn,
            this.corbaDataGridViewTextBoxColumn,
            this.iceceklerDataGridViewTextBoxColumn,
            this.tatlılarDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.masa4BindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(413, 273);
            this.dataGridView4.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btncık4);
            this.groupBox4.Controls.Add(this.Btngün4);
            this.groupBox4.Controls.Add(this.btnsil4);
            this.groupBox4.Controls.Add(this.cmbtatlı4);
            this.groupBox4.Controls.Add(this.cmbicecek4);
            this.groupBox4.Controls.Add(this.cmbcorba4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnal4);
            this.groupBox4.Controls.Add(this.cmbana4);
            this.groupBox4.Controls.Add(this.txtmasa4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 290);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // btncık4
            // 
            this.btncık4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncık4.ForeColor = System.Drawing.Color.Crimson;
            this.btncık4.Location = new System.Drawing.Point(360, 218);
            this.btncık4.Name = "btncık4";
            this.btncık4.Size = new System.Drawing.Size(136, 39);
            this.btncık4.TabIndex = 27;
            this.btncık4.Text = "Masadan Cık";
            this.btncık4.UseVisualStyleBackColor = true;
            this.btncık4.Click += new System.EventHandler(this.btncık4_Click);
            // 
            // Btngün4
            // 
            this.Btngün4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün4.ForeColor = System.Drawing.Color.Crimson;
            this.Btngün4.Location = new System.Drawing.Point(360, 155);
            this.Btngün4.Name = "Btngün4";
            this.Btngün4.Size = new System.Drawing.Size(136, 39);
            this.Btngün4.TabIndex = 26;
            this.Btngün4.Text = "Siparis Güncelle";
            this.Btngün4.UseVisualStyleBackColor = true;
            this.Btngün4.Click += new System.EventHandler(this.Btngün4_Click);
            // 
            // btnsil4
            // 
            this.btnsil4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil4.ForeColor = System.Drawing.Color.Crimson;
            this.btnsil4.Location = new System.Drawing.Point(360, 93);
            this.btnsil4.Name = "btnsil4";
            this.btnsil4.Size = new System.Drawing.Size(136, 39);
            this.btnsil4.TabIndex = 25;
            this.btnsil4.Text = "Siparis Sil";
            this.btnsil4.UseVisualStyleBackColor = true;
            this.btnsil4.Click += new System.EventHandler(this.btnsil4_Click);
            // 
            // cmbtatlı4
            // 
            this.cmbtatlı4.ForeColor = System.Drawing.Color.Crimson;
            this.cmbtatlı4.FormattingEnabled = true;
            this.cmbtatlı4.Items.AddRange(new object[] {
            "Baklava",
            "Künefe"});
            this.cmbtatlı4.Location = new System.Drawing.Point(145, 232);
            this.cmbtatlı4.Name = "cmbtatlı4";
            this.cmbtatlı4.Size = new System.Drawing.Size(151, 21);
            this.cmbtatlı4.TabIndex = 24;
            // 
            // cmbicecek4
            // 
            this.cmbicecek4.ForeColor = System.Drawing.Color.Crimson;
            this.cmbicecek4.FormattingEnabled = true;
            this.cmbicecek4.Items.AddRange(new object[] {
            "Ayran",
            "Şalgam",
            "330 ccl Pepsi",
            "330 ccl Fanta",
            "Su"});
            this.cmbicecek4.Location = new System.Drawing.Point(145, 186);
            this.cmbicecek4.Name = "cmbicecek4";
            this.cmbicecek4.Size = new System.Drawing.Size(151, 21);
            this.cmbicecek4.TabIndex = 23;
            // 
            // cmbcorba4
            // 
            this.cmbcorba4.ForeColor = System.Drawing.Color.Crimson;
            this.cmbcorba4.FormattingEnabled = true;
            this.cmbcorba4.Items.AddRange(new object[] {
            "Mercimek",
            "Tarhana",
            "Kelle-Paça",
            "Sebezli"});
            this.cmbcorba4.Location = new System.Drawing.Point(145, 136);
            this.cmbcorba4.Name = "cmbcorba4";
            this.cmbcorba4.Size = new System.Drawing.Size(151, 21);
            this.cmbcorba4.TabIndex = 22;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Anayemek";
            // 
            // btnal4
            // 
            this.btnal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnal4.ForeColor = System.Drawing.Color.Crimson;
            this.btnal4.Location = new System.Drawing.Point(360, 28);
            this.btnal4.Name = "btnal4";
            this.btnal4.Size = new System.Drawing.Size(136, 39);
            this.btnal4.TabIndex = 17;
            this.btnal4.Text = "Siparis Al";
            this.btnal4.UseVisualStyleBackColor = true;
            this.btnal4.Click += new System.EventHandler(this.btnal4_Click);
            // 
            // cmbana4
            // 
            this.cmbana4.ForeColor = System.Drawing.Color.Crimson;
            this.cmbana4.FormattingEnabled = true;
            this.cmbana4.Items.AddRange(new object[] {
            "Adana Kebap Servis",
            "Et Döner",
            "Tavuk Döner",
            "Mantı",
            "Elbistan Tava",
            "Beyti",
            "İçli Köfte"});
            this.cmbana4.Location = new System.Drawing.Point(145, 79);
            this.cmbana4.Name = "cmbana4";
            this.cmbana4.Size = new System.Drawing.Size(151, 21);
            this.cmbana4.TabIndex = 16;
            // 
            // txtmasa4
            // 
            this.txtmasa4.ForeColor = System.Drawing.Color.Crimson;
            this.txtmasa4.Location = new System.Drawing.Point(145, 33);
            this.txtmasa4.Name = "txtmasa4";
            this.txtmasa4.Size = new System.Drawing.Size(151, 20);
            this.txtmasa4.TabIndex = 15;
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
            this.label1.Text = "Masa 4";
            // 
            // yemekcilikDataSet3
            // 
            this.yemekcilikDataSet3.DataSetName = "yemekcilikDataSet3";
            this.yemekcilikDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masa4BindingSource
            // 
            this.masa4BindingSource.DataMember = "masa4";
            this.masa4BindingSource.DataSource = this.yemekcilikDataSet3;
            // 
            // masa4TableAdapter
            // 
            this.masa4TableAdapter.ClearBeforeFill = true;
            // 
            // masa4idDataGridViewTextBoxColumn
            // 
            this.masa4idDataGridViewTextBoxColumn.DataPropertyName = "masa4id";
            this.masa4idDataGridViewTextBoxColumn.HeaderText = "masa4id";
            this.masa4idDataGridViewTextBoxColumn.Name = "masa4idDataGridViewTextBoxColumn";
            this.masa4idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anayemekDataGridViewTextBoxColumn
            // 
            this.anayemekDataGridViewTextBoxColumn.DataPropertyName = "Anayemek";
            this.anayemekDataGridViewTextBoxColumn.HeaderText = "Anayemek";
            this.anayemekDataGridViewTextBoxColumn.Name = "anayemekDataGridViewTextBoxColumn";
            // 
            // corbaDataGridViewTextBoxColumn
            // 
            this.corbaDataGridViewTextBoxColumn.DataPropertyName = "Corba";
            this.corbaDataGridViewTextBoxColumn.HeaderText = "Corba";
            this.corbaDataGridViewTextBoxColumn.Name = "corbaDataGridViewTextBoxColumn";
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
            // Formmasa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(990, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Formmasa4";
            this.Text = "MASA 4";
            this.Load += new System.EventHandler(this.Formmasa4_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncık4;
        private System.Windows.Forms.Button Btngün4;
        private System.Windows.Forms.Button btnsil4;
        private System.Windows.Forms.ComboBox cmbtatlı4;
        private System.Windows.Forms.ComboBox cmbicecek4;
        private System.Windows.Forms.ComboBox cmbcorba4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnal4;
        private System.Windows.Forms.ComboBox cmbana4;
        private System.Windows.Forms.TextBox txtmasa4;
        private System.Windows.Forms.Label label1;
        private yemekcilikDataSet3 yemekcilikDataSet3;
        private System.Windows.Forms.BindingSource masa4BindingSource;
        private yemekcilikDataSet3TableAdapters.masa4TableAdapter masa4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masa4idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anayemekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceceklerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatlılarDataGridViewTextBoxColumn;
    }
}