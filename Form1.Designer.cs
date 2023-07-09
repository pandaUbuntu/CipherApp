namespace WindowsFormsApp1
{
    partial class MyForm
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
            this.Title = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.vishjenerButton = new System.Windows.Forms.RadioButton();
            this.cesarButton = new System.Windows.Forms.RadioButton();
            this.polibiiButton = new System.Windows.Forms.RadioButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
           
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(535, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(256, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "Шифр Цезаря";
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userText.Location = new System.Drawing.Point(12, 95);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 39);
            this.userText.TabIndex = 1;
            this.userText.Text = "Текст:";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Key.Location = new System.Drawing.Point(12, 238);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(101, 39);
            this.Key.TabIndex = 2;
            this.Key.Text = "Ключ:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(12, 311);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(154, 39);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат:";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(207, 95);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1141, 136);
            this.textBox.TabIndex = 4;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(207, 314);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(1141, 241);
            this.resultTextBox.TabIndex = 5;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox.Location = new System.Drawing.Point(207, 251);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(1141, 41);
            this.keyTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зашифрувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 719);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Розшифрувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 719);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 63);
            this.button3.TabIndex = 9;
            this.button3.Text = "Очистити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1079, 719);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 63);
            this.button4.TabIndex = 10;
            this.button4.Text = "Закрити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vishjenerButton
            // 
            this.vishjenerButton.AutoSize = true;
            this.vishjenerButton.Location = new System.Drawing.Point(12, 666);
            this.vishjenerButton.Name = "vishjenerButton";
            this.vishjenerButton.Size = new System.Drawing.Size(218, 37);
            this.vishjenerButton.TabIndex = 11;
            this.vishjenerButton.TabStop = true;
            this.vishjenerButton.Text = "Шифр Віженера";
            this.vishjenerButton.UseVisualStyleBackColor = true;
            this.vishjenerButton.CheckedChanged += new System.EventHandler(this.vishjenerButton_CheckedChanged);
            // 
            // cesarButton
            // 
            this.cesarButton.AutoSize = true;
            this.cesarButton.Checked = true;
            this.cesarButton.Location = new System.Drawing.Point(12, 579);
            this.cesarButton.Name = "cesarButton";
            this.cesarButton.Size = new System.Drawing.Size(196, 37);
            this.cesarButton.TabIndex = 12;
            this.cesarButton.TabStop = true;
            this.cesarButton.Text = "Шифр Цезаря";
            this.cesarButton.UseVisualStyleBackColor = true;
            this.cesarButton.CheckedChanged += new System.EventHandler(this.cesarButton_CheckedChanged);
            // 
            // polibiiButton
            // 
            this.polibiiButton.AutoSize = true;
            this.polibiiButton.Location = new System.Drawing.Point(12, 623);
            this.polibiiButton.Name = "polibiiButton";
            this.polibiiButton.Size = new System.Drawing.Size(207, 37);
            this.polibiiButton.TabIndex = 13;
            this.polibiiButton.TabStop = true;
            this.polibiiButton.Text = "Шифр Полібія";
            this.polibiiButton.UseVisualStyleBackColor = true;
            this.polibiiButton.CheckedChanged += new System.EventHandler(this.polibiiButton_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(354, 579);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorLabel.Size = new System.Drawing.Size(0, 33);
            this.ErrorLabel.TabIndex = 14;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 794);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.polibiiButton);
            this.Controls.Add(this.cesarButton);
            this.Controls.Add(this.vishjenerButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MyForm";
            this.Text = "Шифратор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton vishjenerButton;
        private System.Windows.Forms.RadioButton cesarButton;
        private System.Windows.Forms.RadioButton polibiiButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

