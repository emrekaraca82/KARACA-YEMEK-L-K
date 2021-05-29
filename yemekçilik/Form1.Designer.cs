namespace yemekçilik
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genelmasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekcilikDataSet4 = new yemekçilik.yemekcilikDataSet4();
            this.genelmasaTableAdapter = new yemekçilik.yemekcilikDataSet4TableAdapters.genelmasaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.yemekcilikDataSet5 = new yemekçilik.yemekcilikDataSet5();
            this.genelmasaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genelmasaTableAdapter1 = new yemekçilik.yemekcilikDataSet5TableAdapters.genelmasaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genelmasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelmasaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn1.Location = new System.Drawing.Point(60, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(142, 67);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Masa 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn2.Location = new System.Drawing.Point(309, 42);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(142, 67);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Masa 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn3.Location = new System.Drawing.Point(60, 141);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(142, 67);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Masa 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn4.Location = new System.Drawing.Point(309, 141);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(142, 67);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Masa 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Location = new System.Drawing.Point(63, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // genelmasaBindingSource
            // 
            this.genelmasaBindingSource.DataMember = "genelmasa";
            this.genelmasaBindingSource.DataSource = this.yemekcilikDataSet4;
            // 
            // yemekcilikDataSet4
            // 
            this.yemekcilikDataSet4.DataSetName = "yemekcilikDataSet4";
            this.yemekcilikDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genelmasaTableAdapter
            // 
            this.genelmasaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(101, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "7/24 YEMEK SARAYINA HOŞ GELDİNİZ";
            // 
            // yemekcilikDataSet5
            // 
            this.yemekcilikDataSet5.DataSetName = "yemekcilikDataSet5";
            this.yemekcilikDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genelmasaBindingSource1
            // 
            this.genelmasaBindingSource1.DataMember = "genelmasa";
            this.genelmasaBindingSource1.DataSource = this.yemekcilikDataSet5;
            // 
            // genelmasaTableAdapter1
            // 
            this.genelmasaTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(703, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "YEMEKÇİLİK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genelmasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekcilikDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelmasaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private yemekcilikDataSet4 yemekcilikDataSet4;
        private System.Windows.Forms.BindingSource genelmasaBindingSource;
        private yemekcilikDataSet4TableAdapters.genelmasaTableAdapter genelmasaTableAdapter;
        private System.Windows.Forms.Label label1;
        private yemekcilikDataSet5 yemekcilikDataSet5;
        private System.Windows.Forms.BindingSource genelmasaBindingSource1;
        private yemekcilikDataSet5TableAdapters.genelmasaTableAdapter genelmasaTableAdapter1;

    }
}

