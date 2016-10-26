namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectLabel = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.DBNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.ServerTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.QueryTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(287, 37);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(613, 474);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(5, 156);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(250, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Подключиться к серверу";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectLabel);
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.DBNameTB);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Controls.Add(this.UsernameTB);
            this.groupBox1.Controls.Add(this.PortTB);
            this.groupBox1.Controls.Add(this.ServerTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ConnectLabel
            // 
            this.ConnectLabel.AutoEllipsis = true;
            this.ConnectLabel.Location = new System.Drawing.Point(6, 214);
            this.ConnectLabel.Name = "ConnectLabel";
            this.ConnectLabel.Size = new System.Drawing.Size(246, 17);
            this.ConnectLabel.TabIndex = 11;
            this.ConnectLabel.Text = "Не подключен";
            this.ConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(5, 185);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(250, 23);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Отключиться от сервера";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // DBNameTB
            // 
            this.DBNameTB.Location = new System.Drawing.Point(113, 130);
            this.DBNameTB.Name = "DBNameTB";
            this.DBNameTB.Size = new System.Drawing.Size(142, 20);
            this.DBNameTB.TabIndex = 9;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(113, 104);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.Size = new System.Drawing.Size(142, 20);
            this.PasswordTB.TabIndex = 8;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(113, 78);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(142, 20);
            this.UsernameTB.TabIndex = 7;
            // 
            // PortTB
            // 
            this.PortTB.Location = new System.Drawing.Point(113, 50);
            this.PortTB.MaxLength = 4;
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(142, 20);
            this.PortTB.TabIndex = 6;
            this.PortTB.Text = "5432";
            // 
            // ServerTB
            // 
            this.ServerTB.Location = new System.Drawing.Point(113, 24);
            this.ServerTB.Name = "ServerTB";
            this.ServerTB.Size = new System.Drawing.Size(142, 20);
            this.ServerTB.TabIndex = 5;
            this.ServerTB.Text = "192.168.54.21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя базы данных:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.QueryButton);
            this.groupBox2.Controls.Add(this.QueryTB);
            this.groupBox2.Location = new System.Drawing.Point(13, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 246);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выполнить SQL-запрос";
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QueryButton.Location = new System.Drawing.Point(5, 213);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(257, 23);
            this.QueryButton.TabIndex = 10;
            this.QueryButton.Text = "Выполнить";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // QueryTB
            // 
            this.QueryTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QueryTB.Location = new System.Drawing.Point(6, 19);
            this.QueryTB.Multiline = true;
            this.QueryTB.Name = "QueryTB";
            this.QueryTB.Size = new System.Drawing.Size(256, 188);
            this.QueryTB.TabIndex = 0;
            this.QueryTB.TextChanged += new System.EventHandler(this.QueryTB_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(287, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(610, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DBNameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.TextBox ServerTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.TextBox QueryTB;
        private System.Windows.Forms.Label ConnectLabel;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label6;
    }
}

