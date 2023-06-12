namespace Hotel_Registration_Application
{
    partial class FrmBills
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Foods = new System.Windows.Forms.Label();
            this.btnSaveBills = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtElectric = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGas);
            this.groupBox1.Controls.Add(this.txtInternet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Foods);
            this.groupBox1.Controls.Add(this.btnSaveBills);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtWater);
            this.groupBox1.Controls.Add(this.txtElectric);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(64, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gas :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(115, 170);
            this.txtGas.Multiline = true;
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(190, 33);
            this.txtGas.TabIndex = 12;
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(115, 117);
            this.txtInternet.Multiline = true;
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(190, 33);
            this.txtInternet.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Internet :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Water :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Foods
            // 
            this.Foods.AutoSize = true;
            this.Foods.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Foods.Location = new System.Drawing.Point(26, 30);
            this.Foods.Name = "Foods";
            this.Foods.Size = new System.Drawing.Size(88, 18);
            this.Foods.TabIndex = 8;
            this.Foods.Text = "Electricity :";
            this.Foods.Click += new System.EventHandler(this.Foods_Click);
            // 
            // btnSaveBills
            // 
            this.btnSaveBills.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveBills.Location = new System.Drawing.Point(99, 238);
            this.btnSaveBills.Name = "btnSaveBills";
            this.btnSaveBills.Size = new System.Drawing.Size(172, 47);
            this.btnSaveBills.TabIndex = 7;
            this.btnSaveBills.Text = "Save";
            this.btnSaveBills.UseVisualStyleBackColor = true;
            this.btnSaveBills.Click += new System.EventHandler(this.btnSaveBills_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 135);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Electricity";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Water";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Internet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gas";
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(115, 72);
            this.txtWater.Multiline = true;
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(190, 33);
            this.txtWater.TabIndex = 3;
            // 
            // txtElectric
            // 
            this.txtElectric.Location = new System.Drawing.Point(115, 21);
            this.txtElectric.Multiline = true;
            this.txtElectric.Name = "txtElectric";
            this.txtElectric.Size = new System.Drawing.Size(190, 33);
            this.txtElectric.TabIndex = 2;
            // 
            // FrmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.FrmBills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Foods;
        private System.Windows.Forms.Button btnSaveBills;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtElectric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}