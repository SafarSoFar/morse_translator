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
        public Form1()
        {
            InitializeComponent();
        }

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

        private void translateButton_Click(object sender, EventArgs e)
        {

            //dotLength = Int32.Parse(lenComboBox.SelectedValue.ToString());
            if(lenComboBox.SelectedItem != null)
            {
                string tmpStr = lenComboBox.SelectedItem.ToString();
                dotLength = Int32.Parse(tmpStr);
            }
            else
            {
                MessageBox.Show("Didn't choose the length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            if (freqComboBox.SelectedItem != null)
            {
                string tmpStr = freqComboBox.SelectedItem.ToString();
                freq = Int32.Parse(tmpStr);
            }
            else
            {
                MessageBox.Show("Didn't choose the frequency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            dashLength = dotLength * 3;
            wordPause = dotLength * 7;            
            Dictionary<char, string> cyrDic = new Dictionary<char, string>();
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
            output = "";
            int len = inputTextBox.TextLength;
            for (int i = 0; i < len; i++)
            {

                if (inputTextBox.Text[i] == ' ')
                {
                    output += ' ';
                    CreateSound(inputTextBox.Text[i]);
                }
                else
                {
                    output += cyrDic[inputTextBox.Text[i]];
                    for (int j = 0; j < cyrDic[inputTextBox.Text[i]].Length; j++)
                    {
                        CreateSound(cyrDic[inputTextBox.Text[i]][j]);
                    }
                    output += ' ';
                }
                
                //cout << ' ';
            }
            //std::cout << '\n';
            //std::cout << output;
        }
    }
}
