using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace morse__GUI
{
    public partial class Form1 : Form
    {
        int wordPause;
        int freq;
        int dotLength;
        int dashLength;
        string output;
        Dictionary<char, string> cyrDic = new Dictionary<char, string>();
        Dictionary<char, string> latDic = new Dictionary<char, string>();

        public Form1()
        {
            InitializeComponent();
            //Cyrillic
            cyrDic['а'] = "*-";
            cyrDic['б'] = "-***";
            cyrDic['в'] = "*--";
            cyrDic['г'] = "--*";
            cyrDic['д'] = "-**";
            cyrDic['е'] = "*";
            //cyrDic['ё'] = "";
            cyrDic['ж'] = "***-";
            cyrDic['з'] = "--**";
            cyrDic['и'] = "**";
            cyrDic['й'] = "*---";
            cyrDic['к'] = "-*-";
            cyrDic['л'] = "-*--";
            cyrDic['м'] = "--";
            cyrDic['н'] = "-*";
            cyrDic['о'] = "---";
            cyrDic['п'] = "*--*";
            cyrDic['р'] = "*-*";
            cyrDic['с'] = "***";
            cyrDic['т'] = "-";
            cyrDic['у'] = "**-";
            cyrDic['ф'] = "**-*";
            cyrDic['х'] = "****";
            cyrDic['ц'] = "-*-*";
            cyrDic['ч'] = "---*";
            cyrDic['ш'] = "----";
            cyrDic['щ'] = "--*-";
            cyrDic['ъ'] = "*--*-*";
            cyrDic['ы'] = "-*--";
            cyrDic['ь'] = "-**-";
            cyrDic['э'] = "***-***";
            cyrDic['ю'] = "**--";
            cyrDic['я'] = "*-*-";
            cyrDic[' '] = " ";
            //Latin
            latDic['a'] = "*-";
            latDic['b'] = "-***";
            latDic['c'] = "-*-*";
            latDic['d'] = "-**";
            latDic['e'] = "*";
            latDic['f'] = "**-*";
            latDic['g'] = "--*";
            latDic['h'] = "****";
            latDic['i'] = "**";
            latDic['j'] = "*---";
            latDic['k'] = "-*-";
            latDic['l'] = "*-**";
            latDic['m'] = "--";
            latDic['n'] = "-*";
            latDic['o'] = "---";
            latDic['p'] = "*--*";
            latDic['q'] = "--*-";
            latDic['r'] = "-*-";
            latDic['s'] = "***";
            latDic['t'] = "-";
            latDic['u'] = "**-";
            latDic['v'] = "***-";
            latDic['w'] = "*--";
            latDic['x'] = "-**-";
            latDic['y'] = "-*--";
            latDic['z'] = "--**";
        }
        // Создание звука
        void CreateSound(char ch)
        {
            if (ch == ' ')
            {
                Thread.Sleep(wordPause);
            }
            else
            {
                if (ch == '*')
                {
                    Console.Beep(freq, dotLength);
                }
                else
                    Console.Beep(freq, dashLength);

                Thread.Sleep(dashLength);
            }
            outputTextBox.Text = output;

        }
        // Нажатие кнопки перевода
        private void translateButton_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> curDic;
            if (symbolsComboBox.SelectedItem != null)
            {
                string cur = symbolsComboBox.SelectedItem.ToString();
                if (cur == "Cyrillic")
                {
                    curDic = cyrDic;
                }
                else
                    curDic = latDic;
            }
            else
            {
                // Ошибка при не выборе алфавита
                MessageBox.Show("Didn't choose the alphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lenComboBox.SelectedItem != null)
            {
                string tmpStr = lenComboBox.SelectedItem.ToString();
                dotLength = Int32.Parse(tmpStr);
            }
            else
            {
            // Ошибка при не выборе длины звучания точки
                MessageBox.Show("Didn't choose the length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (freqComboBox.SelectedItem != null)
            {
                string tmpStr = freqComboBox.SelectedItem.ToString();
                freq = Int32.Parse(tmpStr);
            }
            else
            {
            // Ошибка при не выборе частоты звучания точки
                MessageBox.Show("Didn't choose the frequency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // длина тире - 3 точки
            dashLength = dotLength * 3;
            // длина пазуы между словами - 7 точек 
            wordPause = dotLength * 7;

            output = "";
            int len = inputTextBox.TextLength;
            inputTextBox.Text = inputTextBox.Text.ToLower();
            try
            {
                for (int i = 0; i < len; i++)
                {

                    if (inputTextBox.Text[i] == ' ')
                    {
                        output += ' ';
                        CreateSound(inputTextBox.Text[i]);
                    }
                    else
                    {
                        output += curDic[inputTextBox.Text[i]];
                        for (int j = 0; j < curDic[inputTextBox.Text[i]].Length; j++)
                        {
                            CreateSound(curDic[inputTextBox.Text[i]][j]);
                        }
                        output += ' ';
                    }


                }

            }
            // Если использован неправильный алфавит - ошибка
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                MessageBox.Show("Wrong symbols type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void memeButton_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            //this.Controls.Add(frm2);
            frm2.Show();
        }

        private void memeButton_MouseEnter(object sender, EventArgs e)
        {
            memeButton.ForeColor = Color.Black;
        }

        private void memeButton_MouseLeave(object sender, EventArgs e)
        {
            memeButton.ForeColor = System.Drawing.SystemColors.Control;
        }
    }
}
