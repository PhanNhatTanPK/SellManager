namespace GUI_Desktop
{
    partial class User
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.emailTex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adressTex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DateTex = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 34;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 327);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ngày sinh";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut.Location = new System.Drawing.Point(721, 349);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(129, 42);
            this.SearchBut.TabIndex = 30;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.Red;
            this.DeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBut.Location = new System.Drawing.Point(550, 349);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(129, 42);
            this.DeleteBut.TabIndex = 29;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBut.Location = new System.Drawing.Point(372, 349);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(129, 42);
            this.UpdateBut.TabIndex = 28;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = false;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.BackColor = System.Drawing.Color.Green;
            this.SaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.Location = new System.Drawing.Point(206, 349);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(129, 42);
            this.SaveBut.TabIndex = 27;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // emailTex
            // 
            this.emailTex.Location = new System.Drawing.Point(506, 221);
            this.emailTex.Multiline = true;
            this.emailTex.Name = "emailTex";
            this.emailTex.Size = new System.Drawing.Size(199, 31);
            this.emailTex.TabIndex = 26;
            this.emailTex.TextChanged += new System.EventHandler(this.emailTex_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // phoneTex
            // 
            this.phoneTex.Location = new System.Drawing.Point(506, 176);
            this.phoneTex.Multiline = true;
            this.phoneTex.Name = "phoneTex";
            this.phoneTex.Size = new System.Drawing.Size(199, 31);
            this.phoneTex.TabIndex = 24;
            this.phoneTex.TextChanged += new System.EventHandler(this.phoneTex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số điện thoại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // adressTex
            // 
            this.adressTex.Location = new System.Drawing.Point(506, 129);
            this.adressTex.Multiline = true;
            this.adressTex.Name = "adressTex";
            this.adressTex.Size = new System.Drawing.Size(199, 31);
            this.adressTex.TabIndex = 22;
            this.adressTex.TextChanged += new System.EventHandler(this.adressTex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa chỉ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserNameTex
            // 
            this.UserNameTex.Location = new System.Drawing.Point(506, 82);
            this.UserNameTex.Multiline = true;
            this.UserNameTex.Name = "UserNameTex";
            this.UserNameTex.Size = new System.Drawing.Size(199, 31);
            this.UserNameTex.TabIndex = 20;
            this.UserNameTex.TextChanged += new System.EventHandler(this.UserNameTex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 301);
            this.panel1.TabIndex = 36;
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
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 36;
            this.button2.Text = "Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateTex
            // 
            this.DateTex.Location = new System.Drawing.Point(506, 272);
            this.DateTex.Name = "DateTex";
            this.DateTex.Size = new System.Drawing.Size(200, 22);
            this.DateTex.TabIndex = 37;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 724);
            this.Controls.Add(this.DateTex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.emailTex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneTex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adressTex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameTex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.TextBox emailTex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adressTex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DateTex;
    }
}