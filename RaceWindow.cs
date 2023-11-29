using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Type_Racer
{
    public partial class RaceWindow : Form
    {
        private static int clicks = 0, words = 0,errors = 0, wordsDisplayed = 5;
        public static System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        private List<string> dict = new List<string>();
        private string[] wrds = new string[wordsDisplayed];

        public RaceWindow(ref List<string> dictionary)
        {
            this.dict = dictionary.OrderBy(a => Guid.NewGuid()).ToList();
            InitializeComponent();
        }

        private void RaceWindow_Load(object sender, EventArgs e)
        {
            NewWords();
            userInputTextBox.Focus();
        }

        private void RaceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            var time = timer.ElapsedMilliseconds;
            if (time <= 0)
                return;
            MainWindow.wps = words / (time / 1000);
            MainWindow.wpm = words / (time / 1000) / 60;
            MainWindow.cps = clicks / (time / 1000);
            MainWindow.cpm = clicks / (time / 1000) / 60;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

            if (!timer.IsRunning)
                timer.Start();

            userInputTextBox.Text = userInputTextBox.Text.ToLower();

            statusLabel.Text = "Status: OK";
            statusLabel.BackColor = Color.Lime;

            if (userInputTextBox.Text.Length <= 0)
                return;

            clicks++;
            if (userInputTextBox.Text.Last() == ' ')
            {
                if (userInputTextBox.Text.Trim() == wrds[0])
                {
                    words++;
                    NewWords();
                    userInputTextBox.Text = "";
                }
                return;
            }

            bool isError = false;

            for (int i = 0; i < userInputTextBox.Text.Length; i++)
            {
                if (userInputTextBox.Text[i] != wrds[0][i] || i > wrds[0].Length)
                {
                    
                    isError = true;
                    break;
                }
            }
            if (isError)
            {
                errors++;
                statusLabel.Text = "Status: ERROR";
                statusLabel.BackColor = Color.Red;
            }
            else
            {
                statusLabel.Text = "Status: OK";
                statusLabel.BackColor = Color.Lime;
            }
        }

        private void NewWords()
        {
            trackTextBox.Text = string.Empty;
            for (int i = 0; i < wordsDisplayed; i++)
            {
                wrds[i] = dict[i + words];
                trackTextBox.Text += wrds[i] + "  ";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            clicks = 0;
            words = 0;
            errors = 0;
            this.dict = dict.OrderBy(a => Guid.NewGuid()).ToList();
            NewWords();
            userInputTextBox.Text = string.Empty;
        }
    }
}
