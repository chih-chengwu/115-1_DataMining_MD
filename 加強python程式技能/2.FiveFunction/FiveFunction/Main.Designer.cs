namespace CollegeSample1_5Function
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModify2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(346, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "通訊錄維護";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(250, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "身分證字號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(532, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(532, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "性別";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(132, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "電話";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(132, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "地址";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(69, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 116);
            this.panel1.TabIndex = 7;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnd.Location = new System.Drawing.Point(651, 10);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(112, 87);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(506, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 87);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清螢幕";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(384, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 87);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.Location = new System.Drawing.Point(262, 10);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 87);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改存檔";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(141, 10);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 87);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(20, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 87);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增存檔";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtID.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(448, 138);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 36);
            this.txtID.TabIndex = 8;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(250, 222);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 36);
            this.txtName.TabIndex = 9;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBirthday.Location = new System.Drawing.Point(626, 220);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(166, 36);
            this.txtBirthday.TabIndex = 10;
            this.txtBirthday.TextChanged += new System.EventHandler(this.txtBirthday_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTel.Location = new System.Drawing.Point(250, 298);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 36);
            this.txtTel.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(250, 378);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(541, 36);
            this.txtAddress.TabIndex = 12;
            // 
            // cboSex
            // 
            this.cboSex.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Location = new System.Drawing.Point(626, 298);
            this.cboSex.Margin = new System.Windows.Forms.Padding(4);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(166, 32);
            this.cboSex.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnModify2);
            this.panel2.Location = new System.Drawing.Point(69, 573);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 112);
            this.panel2.TabIndex = 14;
            // 
            // btnModify2
            // 
            this.btnModify2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify2.Location = new System.Drawing.Point(262, 12);
            this.btnModify2.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify2.Name = "btnModify2";
            this.btnModify2.Size = new System.Drawing.Size(112, 87);
            this.btnModify2.TabIndex = 3;
            this.btnModify2.Text = "修改存檔2";
            this.btnModify2.UseVisualStyleBackColor = true;
            this.btnModify2.Click += new System.EventHandler(this.btnModify2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModify2;
    }
}

