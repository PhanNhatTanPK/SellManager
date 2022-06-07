namespace GUI_Desktop
{
    partial class Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.PriceTex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OriginTex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 327);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchBut
            // 
            this.SearchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut.Location = new System.Drawing.Point(755, 315);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(129, 42);
            this.SearchBut.TabIndex = 41;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.Red;
            this.DeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBut.Location = new System.Drawing.Point(584, 315);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(129, 42);
            this.DeleteBut.TabIndex = 40;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBut.Location = new System.Drawing.Point(406, 315);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(129, 42);
            this.UpdateBut.TabIndex = 39;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.BackColor = System.Drawing.Color.Green;
            this.SaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.Location = new System.Drawing.Point(240, 315);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(129, 42);
            this.SaveBut.TabIndex = 38;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // PriceTex
            // 
            this.PriceTex.Location = new System.Drawing.Point(477, 232);
            this.PriceTex.Multiline = true;
            this.PriceTex.Name = "PriceTex";
            this.PriceTex.Size = new System.Drawing.Size(199, 31);
            this.PriceTex.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giá cả";
            // 
            // AmountTex
            // 
            this.AmountTex.Location = new System.Drawing.Point(477, 178);
            this.AmountTex.Multiline = true;
            this.AmountTex.Name = "AmountTex";
            this.AmountTex.Size = new System.Drawing.Size(199, 31);
            this.AmountTex.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số lượng";
            // 
            // OriginTex
            // 
            this.OriginTex.Location = new System.Drawing.Point(477, 131);
            this.OriginTex.Multiline = true;
            this.OriginTex.Name = "OriginTex";
            this.OriginTex.Size = new System.Drawing.Size(199, 31);
            this.OriginTex.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Xuất xứ";
            // 
            // productTex
            // 
            this.productTex.Location = new System.Drawing.Point(477, 75);
            this.productTex.Multiline = true;
            this.productTex.Name = "productTex";
            this.productTex.Size = new System.Drawing.Size(199, 31);
            this.productTex.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 301);
            this.panel1.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(33, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 42);
            this.button3.TabIndex = 37;
            this.button3.Text = "Recipes ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 36;
            this.button2.Text = "Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 44;
            this.label6.Text = "...";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 724);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.PriceTex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OriginTex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productTex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.TextBox PriceTex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountTex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OriginTex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productTex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}