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
            var time = (decimal)timer.ElapsedMilliseconds;
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
            {
                timer.Start();
                statsCouter.RunWorkerAsync();
            }
            clicks++;
            string Input = userInputTextBox.Text.ToLower();

            if (Input.Trim().Length > wrds[0].Length)
            {
                if (wordLen < Input.Trim().Length)
                    errors++;

                statusLabel.Text = "Status: ERROR";
                statusLabel.BackColor = Color.Red;
                return;
            }
            if (Input.Trim() != wrds[0].Remove(Input.Trim().Length))
            {
                if (wordLen < Input.Trim().Length)
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
                    wordLen = 0;
                    NewWords();
                }
            wordLen = Input.Trim().Length;
            if (words == MainWindow.wordsNum)
                this.Close();

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

        private void statsCouter_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for(int i =0; timer.IsRunning ; i++)
            {
                if (statsCouter.CancellationPending)
                    break;

                statsCouter.ReportProgress(i);
                Thread.Sleep(100);
            }
            return;
        }

        private void statsCouter_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            errorsLabel.Text = $"Mistakes: {errors}";
            CompletedWordsLabel.Text = $"Completed words: {words}";
            timeLabel.Text = $"Time: {double.Round((double)timer.ElapsedMilliseconds / 1000, 1)} s";
        }

    }
}
