using System;
using System.Windows.Forms;
using Cipher.Services;
using CipherBase.Services;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        private ICipher cipherHelper = null;

        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cipherHelper = new Cesar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox.Clear();
            this.keyTextBox.Clear();
            this.resultTextBox.Clear();
            this.ErrorLabel.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cesarButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Title.Text = "Шифр Цезаря";
            this.keyTextBox.Visible = true;
            this.Key.Visible = true;
            cipherHelper = new Cesar();
        }

        private void polibiiButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cesarButton.Checked == false)
            {
                this.Title.Text = "Шифр Полібія";
                this.keyTextBox.Visible = false;
                this.Key.Visible = false;
                cipherHelper = new Polibii();
            }
        }

        private void vishjenerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Title.Text = "Шифр Віженера";
            this.keyTextBox.Visible = true;
            this.Key.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try {
                this.resultTextBox.Text = this.cipherHelper.encode(this.textBox.Text.ToLower(), this.keyTextBox.Text);
            } catch(Exception exception) {
                this.ErrorLabel.Text = exception.Message;
            }
            /*
            if (int.TryParse(this.keyTextBox.Text, out int number))
            {
                
            }else
            {
                this.ErrorLabel.Text = "Помилка! Невірний ключ!!!";
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.keyTextBox.Text, out int number))
            {
                this.resultTextBox.Text = this.cipherHelper.decode(this.textBox.Text.ToLower(), this.keyTextBox.Text);
            }
            else
            {
                this.ErrorLabel.Text = "Помилка! Невірний ключ!!!";
            }
        }
    }
}
