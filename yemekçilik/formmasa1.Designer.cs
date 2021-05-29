namespace yemekçilik
{
    partial class formmasa1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masa1idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anayemekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbalarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceklerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatlılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekcilikDataSet = new yemekçilik.yemekcilikDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncık1 = new System.Windows.Forms.Button();
            this.Btngün1 = new System.Windows.Forms.Button();
            this.btnsil1 = new System.Windows.Forms.Button();
            this.cmbtatlı1 = new System.Windows.Forms.ComboBox();
            this.cmbicecek1 = new System.Windows.Forms.ComboBox();
            this.cmbcorba1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnal1 = new System.Windows.Forms.Button();
            this.cmbana1 = new System.Windows.Forms.ComboBox();
            this.txtmasa1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masa1TableAdapter = new yemekçilik.yemekcilikDataSetTableAdapters.masa1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masa1idDataGridViewTextBoxColumn,
            this.anayemekDataGridViewTextBoxColumn,
            this.corbalarDataGridViewTextBoxColumn,
            this.iceceklerDataGridViewTextBoxColumn,
            this.tatlılarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masa1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 261);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // masa1idDataGridViewTextBoxColumn
            // 
            this.masa1idDataGridViewTextBoxColumn.DataPropertyName = "masa1id";
            this.masa1idDataGridViewTextBoxColumn.HeaderText = "masa1id";
            this.masa1idDataGridViewTextBoxColumn.Name = "masa1idDataGridViewTextBoxColumn";
            this.masa1idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // masa1BindingSource
            // 
            this.masa1BindingSource.DataMember = "masa1";
            this.masa1BindingSource.DataSource = this.yemekcilikDataSet;
            // 
            // yemekcilikDataSet
            // 
            this.yemekcilikDataSet.DataSetName = "yemekcilikDataSet";
            this.yemekcilikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncık1);
            this.groupBox1.Controls.Add(this.Btngün1);
            this.groupBox1.Controls.Add(this.btnsil1);
            this.groupBox1.Controls.Add(this.cmbtatlı1);
            this.groupBox1.Controls.Add(this.cmbicecek1);
            this.groupBox1.Controls.Add(this.cmbcorba1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnal1);
            this.groupBox1.Controls.Add(this.cmbana1);
            this.groupBox1.Controls.Add(this.txtmasa1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 295);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btncık1
            // 
            this.btncık1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncık1.Location = new System.Drawing.Point(360, 218);
            this.btncık1.Name = "btncık1";
            this.btncık1.Size = new System.Drawing.Size(136, 39);
            this.btncık1.TabIndex = 27;
            this.btncık1.Text = "Masadan Cık";
            this.btncık1.UseVisualStyleBackColor = true;
            this.btncık1.Click += new System.EventHandler(this.btncık1_Click);
            // 
            // Btngün1
            // 
            this.Btngün1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün1.Location = new System.Drawing.Point(360, 155);
            this.Btngün1.Name = "Btngün1";
            this.Btngün1.Size = new System.Drawing.Size(136, 39);
            this.Btngün1.TabIndex = 26;
            this.Btngün1.Text = "Siparis Güncelle";
            this.Btngün1.UseVisualStyleBackColor = true;
            this.Btngün1.Click += new System.EventHandler(this.Btngün1_Click);
            // 
            // btnsil1
            // 
            this.btnsil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil1.Location = new System.Drawing.Point(360, 93);
            this.btnsil1.Name = "btnsil1";
            this.btnsil1.Size = new System.Drawing.Size(136, 39);
            this.btnsil1.TabIndex = 25;
            this.btnsil1.Text = "Siparis Sil";
            this.btnsil1.UseVisualStyleBackColor = true;
            this.btnsil1.Click += new System.EventHandler(this.btnsil1_Click);
            // 
            // cmbtatlı1
            // 
            this.cmbtatlı1.FormattingEnabled = true;
            this.cmbtatlı1.Items.AddRange(new object[] {
            "Baklava",
            "Künefe"});
            this.cmbtatlı1.Location = new System.Drawing.Point(145, 232);
            this.cmbtatlı1.Name = "cmbtatlı1";
            this.cmbtatlı1.Size = new System.Drawing.Size(151, 21);
            this.cmbtatlı1.TabIndex = 24;
            // 
            // cmbicecek1
            // 
            this.cmbicecek1.FormattingEnabled = true;
            this.cmbicecek1.Items.AddRange(new object[] {
            "Ayran",
            "Şalgam",
            "330 ccl Pepsi",
            "330 ccl Fanta",
            "Su"});
            this.cmbicecek1.Location = new System.Drawing.Point(145, 186);
            this.cmbicecek1.Name = "cmbicecek1";
            this.cmbicecek1.Size = new System.Drawing.Size(151, 21);
            this.cmbicecek1.TabIndex = 23;
            // 
            // cmbcorba1
            // 
            this.cmbcorba1.FormattingEnabled = true;
            this.cmbcorba1.Items.AddRange(new object[] {
            "Mercimek",
            "Tarhana",
            "Kelle-Paça",
            "Sebezli"});
            this.cmbcorba1.Location = new System.Drawing.Point(145, 136);
            this.cmbcorba1.Name = "cmbcorba1";
            this.cmbcorba1.Size = new System.Drawing.Size(151, 21);
            this.cmbcorba1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Anayemek";
            // 
            // btnal1
            // 
            this.btnal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnal1.Location = new System.Drawing.Point(360, 28);
            this.btnal1.Name = "btnal1";
            this.btnal1.Size = new System.Drawing.Size(136, 39);
            this.btnal1.TabIndex = 17;
            this.btnal1.Text = "Siparis Al";
            this.btnal1.UseVisualStyleBackColor = true;
            this.btnal1.Click += new System.EventHandler(this.btnal1_Click);
            // 
            // cmbana1
            // 
            this.cmbana1.FormattingEnabled = true;
            this.cmbana1.Items.AddRange(new object[] {
            "Adana Kebap Servis",
            "Et Döner",
            "Tavuk Döner",
            "Mantı",
            "Elbistan Tava",
            "Beyti",
            "İçli Köfte"});
            this.cmbana1.Location = new System.Drawing.Point(145, 79);
            this.cmbana1.Name = "cmbana1";
            this.cmbana1.Size = new System.Drawing.Size(151, 21);
            this.cmbana1.TabIndex = 16;
            // 
            // txtmasa1
            // 
            this.txtmasa1.Location = new System.Drawing.Point(145, 33);
            this.txtmasa1.Name = "txtmasa1";
            this.txtmasa1.Size = new System.Drawing.Size(151, 20);
            this.txtmasa1.TabIndex = 15;
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
            this.label1.Text = "Masa 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(562, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 283);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparisler";
            // 
            // masa1TableAdapter
            // 
            this.masa1TableAdapter.ClearBeforeFill = true;
            // 
            // formmasa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(989, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "formmasa1";
            this.Text = "MASA 1";
            this.Load += new System.EventHandler(this.formmasa1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncık1;
        private System.Windows.Forms.Button Btngün1;
        private System.Windows.Forms.Button btnsil1;
        private System.Windows.Forms.ComboBox cmbtatlı1;
        private System.Windows.Forms.ComboBox cmbicecek1;
        private System.Windows.Forms.ComboBox cmbcorba1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnal1;
        private System.Windows.Forms.ComboBox cmbana1;
        private System.Windows.Forms.TextBox txtmasa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private yemekcilikDataSet yemekcilikDataSet;
        private System.Windows.Forms.BindingSource masa1BindingSource;
        private yemekcilikDataSetTableAdapters.masa1TableAdapter masa1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masa1idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anayemekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corbalarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceceklerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatlılarDataGridViewTextBoxColumn;

    }
}