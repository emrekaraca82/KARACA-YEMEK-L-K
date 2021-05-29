namespace yemekçilik
{
    partial class Formmasa3
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.masa3idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anayemekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceklerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatlılarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masa3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekcilikDataSet2 = new yemekçilik.yemekcilikDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncık3 = new System.Windows.Forms.Button();
            this.Btngün3 = new System.Windows.Forms.Button();
            this.btnsil3 = new System.Windows.Forms.Button();
            this.cmbtatlı3 = new System.Windows.Forms.ComboBox();
            this.cmbicecek3 = new System.Windows.Forms.ComboBox();
            this.cmbcorba3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnal3 = new System.Windows.Forms.Button();
            this.cmbana3 = new System.Windows.Forms.ComboBox();
            this.txtmasa3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.masa3TableAdapter = new yemekçilik.yemekcilikDataSet2TableAdapters.masa3TableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(552, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 295);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparisler";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masa3idDataGridViewTextBoxColumn,
            this.anayemekDataGridViewTextBoxColumn,
            this.corbaDataGridViewTextBoxColumn,
            this.iceceklerDataGridViewTextBoxColumn,
            this.tatlılarDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.masa3BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(413, 273);
            this.dataGridView3.TabIndex = 14;
            // 
            // masa3idDataGridViewTextBoxColumn
            // 
            this.masa3idDataGridViewTextBoxColumn.DataPropertyName = "masa3id";
            this.masa3idDataGridViewTextBoxColumn.HeaderText = "masa3id";
            this.masa3idDataGridViewTextBoxColumn.Name = "masa3idDataGridViewTextBoxColumn";
            this.masa3idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // masa3BindingSource
            // 
            this.masa3BindingSource.DataMember = "masa3";
            this.masa3BindingSource.DataSource = this.yemekcilikDataSet2;
            // 
            // yemekcilikDataSet2
            // 
            this.yemekcilikDataSet2.DataSetName = "yemekcilikDataSet2";
            this.yemekcilikDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncık3);
            this.groupBox1.Controls.Add(this.Btngün3);
            this.groupBox1.Controls.Add(this.btnsil3);
            this.groupBox1.Controls.Add(this.cmbtatlı3);
            this.groupBox1.Controls.Add(this.cmbicecek3);
            this.groupBox1.Controls.Add(this.cmbcorba3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnal3);
            this.groupBox1.Controls.Add(this.cmbana3);
            this.groupBox1.Controls.Add(this.txtmasa3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 290);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btncık3
            // 
            this.btncık3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncık3.ForeColor = System.Drawing.Color.Crimson;
            this.btncık3.Location = new System.Drawing.Point(360, 218);
            this.btncık3.Name = "btncık3";
            this.btncık3.Size = new System.Drawing.Size(136, 39);
            this.btncık3.TabIndex = 27;
            this.btncık3.Text = "Masadan Cık";
            this.btncık3.UseVisualStyleBackColor = true;
            this.btncık3.Click += new System.EventHandler(this.btncık3_Click);
            // 
            // Btngün3
            // 
            this.Btngün3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün3.ForeColor = System.Drawing.Color.Crimson;
            this.Btngün3.Location = new System.Drawing.Point(360, 155);
            this.Btngün3.Name = "Btngün3";
            this.Btngün3.Size = new System.Drawing.Size(136, 39);
            this.Btngün3.TabIndex = 26;
            this.Btngün3.Text = "Siparis Güncelle";
            this.Btngün3.UseVisualStyleBackColor = true;
            this.Btngün3.Click += new System.EventHandler(this.Btngün3_Click);
            // 
            // btnsil3
            // 
            this.btnsil3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil3.ForeColor = System.Drawing.Color.Crimson;
            this.btnsil3.Location = new System.Drawing.Point(360, 93);
            this.btnsil3.Name = "btnsil3";
            this.btnsil3.Size = new System.Drawing.Size(136, 39);
            this.btnsil3.TabIndex = 25;
            this.btnsil3.Text = "Siparis Sil";
            this.btnsil3.UseVisualStyleBackColor = true;
            this.btnsil3.Click += new System.EventHandler(this.btnsil3_Click);
            // 
            // cmbtatlı3
            // 
            this.cmbtatlı3.ForeColor = System.Drawing.Color.Crimson;
            this.cmbtatlı3.FormattingEnabled = true;
            this.cmbtatlı3.Items.AddRange(new object[] {
            "Baklava",
            "Künefe"});
            this.cmbtatlı3.Location = new System.Drawing.Point(145, 232);
            this.cmbtatlı3.Name = "cmbtatlı3";
            this.cmbtatlı3.Size = new System.Drawing.Size(151, 21);
            this.cmbtatlı3.TabIndex = 24;
            // 
            // cmbicecek3
            // 
            this.cmbicecek3.ForeColor = System.Drawing.Color.Crimson;
            this.cmbicecek3.FormattingEnabled = true;
            this.cmbicecek3.Items.AddRange(new object[] {
            "Ayran",
            "Şalgam",
            "330 ccl Pepsi",
            "330 ccl Fanta",
            "Su"});
            this.cmbicecek3.Location = new System.Drawing.Point(145, 186);
            this.cmbicecek3.Name = "cmbicecek3";
            this.cmbicecek3.Size = new System.Drawing.Size(151, 21);
            this.cmbicecek3.TabIndex = 23;
            // 
            // cmbcorba3
            // 
            this.cmbcorba3.ForeColor = System.Drawing.Color.Crimson;
            this.cmbcorba3.FormattingEnabled = true;
            this.cmbcorba3.Items.AddRange(new object[] {
            "Mercimek",
            "Tarhana",
            "Kelle-Paça",
            "Sebezli"});
            this.cmbcorba3.Location = new System.Drawing.Point(145, 136);
            this.cmbcorba3.Name = "cmbcorba3";
            this.cmbcorba3.Size = new System.Drawing.Size(151, 21);
            this.cmbcorba3.TabIndex = 22;
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
            // btnal3
            // 
            this.btnal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnal3.ForeColor = System.Drawing.Color.Crimson;
            this.btnal3.Location = new System.Drawing.Point(360, 28);
            this.btnal3.Name = "btnal3";
            this.btnal3.Size = new System.Drawing.Size(136, 39);
            this.btnal3.TabIndex = 17;
            this.btnal3.Text = "Siparis Al";
            this.btnal3.UseVisualStyleBackColor = true;
            this.btnal3.Click += new System.EventHandler(this.btnal3_Click);
            // 
            // cmbana3
            // 
            this.cmbana3.ForeColor = System.Drawing.Color.Crimson;
            this.cmbana3.FormattingEnabled = true;
            this.cmbana3.Items.AddRange(new object[] {
            "Adana Kebap Servis",
            "Et Döner",
            "Tavuk Döner",
            "Mantı",
            "Elbistan Tava",
            "Beyti",
            "İçli Köfte"});
            this.cmbana3.Location = new System.Drawing.Point(145, 79);
            this.cmbana3.Name = "cmbana3";
            this.cmbana3.Size = new System.Drawing.Size(151, 21);
            this.cmbana3.TabIndex = 16;
            // 
            // txtmasa3
            // 
            this.txtmasa3.ForeColor = System.Drawing.Color.Crimson;
            this.txtmasa3.Location = new System.Drawing.Point(145, 33);
            this.txtmasa3.Name = "txtmasa3";
            this.txtmasa3.Size = new System.Drawing.Size(151, 20);
            this.txtmasa3.TabIndex = 15;
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
            this.label1.Text = "Masa 3";
            // 
            // masa3TableAdapter
            // 
            this.masa3TableAdapter.ClearBeforeFill = true;
            // 
            // Formmasa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(985, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formmasa3";
            this.Text = "MASA 3";
            this.Load += new System.EventHandler(this.Formmasa3_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncık3;
        private System.Windows.Forms.Button Btngün3;
        private System.Windows.Forms.Button btnsil3;
        private System.Windows.Forms.ComboBox cmbtatlı3;
        private System.Windows.Forms.ComboBox cmbicecek3;
        private System.Windows.Forms.ComboBox cmbcorba3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnal3;
        private System.Windows.Forms.ComboBox cmbana3;
        private System.Windows.Forms.TextBox txtmasa3;
        private System.Windows.Forms.Label label1;
        private yemekcilikDataSet2 yemekcilikDataSet2;
        private System.Windows.Forms.BindingSource masa3BindingSource;
        private yemekcilikDataSet2TableAdapters.masa3TableAdapter masa3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masa3idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anayemekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceceklerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatlılarDataGridViewTextBoxColumn;
    }
}