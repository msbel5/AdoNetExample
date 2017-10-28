namespace AdoNetOdev
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            this.txtMaxStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchByPrice = new System.Windows.Forms.Button();
            this.btnSearchByStock = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(253, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 29);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak  Değer:";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinPrice.Location = new System.Drawing.Point(253, 56);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(100, 29);
            this.txtMinPrice.TabIndex = 2;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxPrice.Location = new System.Drawing.Point(390, 57);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(100, 29);
            this.txtMaxPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ile ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(133, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Miktari :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(359, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "ile ";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinStock.Location = new System.Drawing.Point(253, 90);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(100, 29);
            this.txtMinStock.TabIndex = 2;
            // 
            // txtMaxStock
            // 
            this.txtMaxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxStock.Location = new System.Drawing.Point(390, 91);
            this.txtMaxStock.Name = "txtMaxStock";
            this.txtMaxStock.Size = new System.Drawing.Size(100, 29);
            this.txtMaxStock.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(294, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Eşleşen Sonuç adeti :";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.Location = new System.Drawing.Point(528, 141);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(20, 24);
            this.a.TabIndex = 3;
            this.a.Text = "0";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 235);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adi";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyatı";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Miktari";
            this.columnHeader3.Width = 183;
            // 
            // btnSearchByPrice
            // 
            this.btnSearchByPrice.Location = new System.Drawing.Point(497, 56);
            this.btnSearchByPrice.Name = "btnSearchByPrice";
            this.btnSearchByPrice.Size = new System.Drawing.Size(75, 29);
            this.btnSearchByPrice.TabIndex = 5;
            this.btnSearchByPrice.Text = "Ara";
            this.btnSearchByPrice.UseVisualStyleBackColor = true;
            this.btnSearchByPrice.Click += new System.EventHandler(this.btnSearchByPrice_Click);
            // 
            // btnSearchByStock
            // 
            this.btnSearchByStock.Location = new System.Drawing.Point(497, 90);
            this.btnSearchByStock.Name = "btnSearchByStock";
            this.btnSearchByStock.Size = new System.Drawing.Size(75, 30);
            this.btnSearchByStock.TabIndex = 5;
            this.btnSearchByStock.Text = "Ara";
            this.btnSearchByStock.UseVisualStyleBackColor = true;
            this.btnSearchByStock.Click += new System.EventHandler(this.btnSearchByStock_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(496, 21);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(75, 29);
            this.btnSearchByName.TabIndex = 5;
            this.btnSearchByName.Text = "Ara";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 442);
            this.Controls.Add(this.btnSearchByStock);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSearchByPrice);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxStock);
            this.Controls.Add(this.txtMinStock);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinStock;
        private System.Windows.Forms.TextBox txtMaxStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSearchByPrice;
        private System.Windows.Forms.Button btnSearchByStock;
        private System.Windows.Forms.Button btnSearchByName;
    }
}