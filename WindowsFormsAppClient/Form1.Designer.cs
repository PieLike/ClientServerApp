namespace WindowsFormsAppClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.executionButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(103, 72);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(471, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "C:\\Users\\PieLike\\Desktop";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(103, 99);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(471, 20);
            this.contentBox.TabIndex = 1;
            this.contentBox.Text = "testContent";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 75);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(66, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Путь файла";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(12, 102);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(72, 13);
            this.contentLabel.TabIndex = 3;
            this.contentLabel.Text = "Содержимое";
            // 
            // executionButton
            // 
            this.executionButton.Location = new System.Drawing.Point(12, 125);
            this.executionButton.Name = "executionButton";
            this.executionButton.Size = new System.Drawing.Size(562, 23);
            this.executionButton.TabIndex = 4;
            this.executionButton.Text = "Выполнить";
            this.executionButton.UseVisualStyleBackColor = true;
            this.executionButton.Click += new System.EventHandler(this.executionButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(14, 170);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 5;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(12, 38);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(564, 23);
            this.connectionButton.TabIndex = 8;
            this.connectionButton.Text = "Подключиться к серверу";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 15);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(83, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Адрес сервера";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(103, 12);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(473, 20);
            this.addressBox.TabIndex = 6;
            this.addressBox.Text = "localhost:7012";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 205);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.executionButton);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.pathBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button executionButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressBox;
    }
}

