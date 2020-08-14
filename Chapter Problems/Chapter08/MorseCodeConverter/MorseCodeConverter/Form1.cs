using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeConverter
{
    public partial class MorseConverterFrom : Form
    {
        char[] characters = new char[] {' ', ',', '.' , '?', '0', '1', '2', '3',
                                        '4', '5', '6' , '7', '8', '9', 'A', 'B',
                                        'C', 'D', 'E' , 'F', 'G', 'H', 'I', 'J',
                                        'K', 'L', 'M' , 'N', 'O', 'P', 'Q', 'R',
                                        'S', 'T', 'U' , 'V', 'W', 'X', 'Y', 'Z'};

        string[] morseChar = new string[] {" ", "--..--", ".-.-.-", "..--..--", "-----",
                                           ".----", "..---", "...--", "....-", ".....",
                                            "-....", "--....", "----..", "----.", ".-",
                                            "-...", "-.-.", "-..", ".", "..-.",
                                            "--.", "....", "..", ".---", "-.-",
                                            ".-..", "---", "-.", "---", ".--.",
                                            "--.-", ".-.", "...", "-", "..-",
                                            "...-", ".--", "-..-", "-.--", "--..",};

        public MorseConverterFrom()
        {
            InitializeComponent();
        }

        private int Index(ref char myChar)
        {
            int index = -1;

            for(int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == char.ToUpper(myChar))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string input = stringTextBox.Text;
            string output = "";
            char toPasss;

            Console.WriteLine(characters.Length + "  " + morseChar.Length);
            if(input != "")
            {
                for(int i = 0; i < input.Length; i++)
                {
                    toPasss = input[i];
                    try
                    {
                        output += morseChar[Index(ref toPasss)];
                        Console.WriteLine(toPasss + "  " + output);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            morseLabel.Text = output;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
