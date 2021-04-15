using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Simon_Says
{
    public partial class MainPage : Form
    {
        public int stack = 0;
        public int stack1 = 0;
        public int stack2 = 0;
        public string message = "";
        public bool answer = false;
        public bool dash = false;
        public string cmd = "NU";

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            stack = 0;
            stack1 = 0;
            message = "";
            answer = false;
            dash = false;
            ask_txt.Text = "";
            question_txt.Text = "";
            ask_txt.ReadOnly = false;
            ask_txt.Focus();
            warning_tip.SetToolTip(warning_pic, "We are not responsible for your questions! \nYou use the application at your own risk!");
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmd == "DA")
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("Bye Bye.");
                speechSynthesizer.Dispose();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Speak("Simon told you that you use the application at your own risk.");
                speechSynthesizer.Dispose();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.R))
            {
                cmd = "DA";
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void question_txt_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialog;
                if (dash == true && (ask_txt.Text == "Simon pretty please" || ask_txt.Text == "Simon pretty please tell me the answer"))
                {
                    message = message.Substring(1);
                    SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                    speechSynthesizer.Speak("Simon says" + message);
                    speechSynthesizer.Dispose();
                    dialog = MessageBox.Show(message, "Simon Says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK)
                    {
                        MainPage_Load(null, EventArgs.Empty);
                    }
                }
                else
                {
                    var list = new List<string> { "I don't have time for your questions.", "Not at your service.", "Try to read the manual.", "I think you are joking.", "I don't want to answer that." };
                    var random = new Random();
                    int index = random.Next(list.Count);

                    SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                    speechSynthesizer.Speak("Simon says" + list[index]);
                    speechSynthesizer.Dispose();
                    dialog = MessageBox.Show(list[index], "Simon Says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK)
                    {
                        MainPage_Load(null, EventArgs.Empty);
                    }
                }
            }
        }

        private void ask_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            stack++;
            if (e.KeyChar == '/')
            {
                stack1++;
                switch (stack1)
                {
                    case 1:
                        answer = true;
                        dash = true;
                        ask_txt.ReadOnly = true;
                        ask_txt.BackColor = System.Drawing.SystemColors.Window;
                        break;
                    case 2:
                        answer = false;
                        ask_txt.ReadOnly = false;
                        e.Handled = true;
                        break;
                }
            }
            if (answer == true)
            {
                switch (stack)
                {
                    case 1:
                        ask_txt.Text += "S";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 2:
                        ask_txt.Text += "i";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 3:
                        ask_txt.Text += "m";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 4:
                        ask_txt.Text += "o";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 5:
                        ask_txt.Text += "n";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 6:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 7:
                        ask_txt.Text += "p";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 8:
                        ask_txt.Text += "r";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 9:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 10:
                        ask_txt.Text += "t";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 11:
                        ask_txt.Text += "t";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 12:
                        ask_txt.Text += "y";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 13:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 14:
                        ask_txt.Text += "p";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 15:
                        ask_txt.Text += "l";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 16:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 17:
                        ask_txt.Text += "a";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 18:
                        ask_txt.Text += "s";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 19:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 20:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 21:
                        ask_txt.Text += "t";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 22:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 23:
                        ask_txt.Text += "l";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 24:
                        ask_txt.Text += "l";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 25:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 26:
                        ask_txt.Text += "m";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 27:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 28:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 29:
                        ask_txt.Text += "t";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 30:
                        ask_txt.Text += "h";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 31:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 32:
                        ask_txt.Text += " ";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 33:
                        ask_txt.Text += "a";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 34:
                        ask_txt.Text += "n";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 35:
                        ask_txt.Text += "s";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 36:
                        ask_txt.Text += "w";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 37:
                        ask_txt.Text += "e";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                    case 38:
                        ask_txt.Text += "r";
                        ask_txt.SelectionStart = ask_txt.Text.Length;
                        message = message + e.KeyChar.ToString();
                        break;
                }
                if (stack > 38)
                {
                    message = message + e.KeyChar.ToString();
                }
            }
        }

        private void howto_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simon is very busy. In order to reach to you, and get your answer. You have to request him. \n\nYou can do this by saying this: \n-Simon pretty please \n\nor this: \n-Simon pretty please tell me the answer \n\nThen add your question and press enter.", "How to get Simon answer your question?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void warning_pic_MouseHover(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak("Warning");
            speechSynthesizer.Dispose();
        }
    }
}
