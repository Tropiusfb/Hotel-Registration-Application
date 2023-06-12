namespace Hotel_Registration_Application
{
    partial class FrmStock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Foods = new System.Windows.Forms.Label();
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimeStock = new System.Windows.Forms.DateTimePicker();
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Foods);
            this.groupBox1.Controls.Add(this.btnSaveStock);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.dateTimeStock);
            this.groupBox1.Controls.Add(this.txtDrink);
            this.groupBox1.Controls.Add(this.txtFood);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drinks :";
            // 
            // Foods
            // 
            this.Foods.AutoSize = true;
            this.Foods.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Foods.Location = new System.Drawing.Point(40, 69);
            this.Foods.Name = "Foods";
            this.Foods.Size = new System.Drawing.Size(67, 23);
            this.Foods.TabIndex = 8;
            this.Foods.Text = "Foods :";
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Location = new System.Drawing.Point(99, 238);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(172, 47);
            this.btnSaveStock.TabIndex = 7;
            this.btnSaveStock.Text = "Save";
            this.btnSaveStock.UseVisualStyleBackColor = true;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 135);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Foods";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Drinks";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            // 
            // dateTimeStock
            // 
            this.dateTimeStock.Location = new System.Drawing.Point(113, 177);
            this.dateTimeStock.Name = "dateTimeStock";
            this.dateTimeStock.Size = new System.Drawing.Size(190, 22);
            this.dateTimeStock.TabIndex = 5;
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(113, 110);
            this.txtDrink.Multiline = true;
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(190, 33);
            this.txtDrink.TabIndex = 3;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(113, 59);
            this.txtFood.Multiline = true;
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(190, 33);
            this.txtFood.TabIndex = 2;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStockBills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimeStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Foods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtDrink;
        private System.Windows.Forms.TextBox txtFood;
    }
}