using System.Data;

namespace Type_Racer
{
    public partial class RaceWindow : Form
    {
        private static decimal clicks = 0, words = 0, errors = 0;
        private static int wordsDisplayed = 5, wordLen = 0;
        public static System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        private List<string> dict = new List<string>();
        private bool enterClicked = false;
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
            timer.Stop();
            var time = timer.ElapsedMilliseconds;
            if (time <= 0)
                return;
            clicks /= 2;
            clicks -= 1;
            MainWindow.wps = words / (time / 1000);
            MainWindow.wpm = words / (time / 1000) * 60;
            MainWindow.cps = clicks / (time / 1000);
            MainWindow.cpm = clicks / (time / 1000) * 60;
            MainWindow.errorRate = errors / clicks * 100;
            MainWindow.time = time / 1000;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

            if (!timer.IsRunning)
                timer.Start();

            clicks++;
            string Input = userInputTextBox.Text.ToLower();

            if (Input.Trim().Length > wrds[0].Length)
            {
                errors++;
                statusLabel.Text = "Status: ERROR";
                statusLabel.BackColor = Color.Red;
                return;
            }
            if (Input.Trim() != wrds[0].Remove(Input.Trim().Length))
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
            if (Input.Length > 0)
                if ((Input.Last() == ' ' || enterClicked) && Input.Trim() == wrds[0])
                {
                    words++;
                    userInputTextBox.Text = "";
                    enterClicked = false;
                    NewWords();
                }
            if (words == MainWindow.wordsNum)
                this.Close();

            //userInputTextBox.Text = userInputTextBox.Text.ToLower();

            //statusLabel.Text = "Status: OK";
            //statusLabel.BackColor = Color.Lime;



            //if (userInputTextBox.Text.Length <= 0)
            //    return;
            //if (wordLen < userInputTextBox.Text.Length) {

            //    wordLen--;
            //}
            //if (userInputTextBox.Text.Last() == ' ')
            //{
            //    if (userInputTextBox.Text.Trim() == wrds[0])
            //    {
            //        words++;
            //        NewWords();
            //        userInputTextBox.Text = "";
            //        wordLen = 0;
            //    }
            //    //return;
            //}

            //bool isError = false;


            //for (int i = 0; i < userInputTextBox.Text.Length; i++)
            //{
            //    if(i > wrds[0].Length)
            //    {
            //        isError = true;
            //        break;
            //    }
            //    if (userInputTextBox.Text[i] != wrds[0][i])
            //    {

            //        isError = true;
            //        break;
            //    }
            //}
            //if (isError)
            //{
            //    if(wordLen >= wrds[0].Length)
            //        wordLen = wrds[0].Length-1;
            //    if (wordLen >= userInputTextBox.Text.Length && userInputTextBox.Text.Last() != wrds[0][wordLen])
            //        errors++;
            //    statusLabel.Text = "Status: ERROR";
            //    statusLabel.BackColor = Color.Red;
            //}
            //else
            //{
            //    statusLabel.Text = "Status: OK";
            //    statusLabel.BackColor = Color.Lime;
            //}
            //wordLen++;

        }

        private void NewWords()
        {
            trackTextBox.Text = string.Empty;
            for (int i = 0; i < wordsDisplayed; i++)
            {
                if (words + i >= MainWindow.wordsNum)
                {
                    wrds[i] = "";
                    continue;
                }
                wrds[i] = dict[i + Convert.ToInt32(words)];
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
            timer.Reset();
            clicks = 0;
            words = 0;
            errors = 0;
            this.dict = dict.OrderBy(a => Guid.NewGuid()).ToList();
            NewWords();
            userInputTextBox.Text = string.Empty;
        }

        private void userInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            enterClicked = e.KeyCode == Keys.Enter ? true : false;
            if (e.KeyCode == Keys.Space && clicks > 0)
                clicks--;
            UserInput_TextChanged(sender, e);
        }
    }
}
