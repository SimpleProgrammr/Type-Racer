namespace Type_Racer
{
    public partial class MainWindow : Form
    {
        public static decimal cps = 0, cpm = 0, wpm = 0, wps = 0, errorRate = 0, wordsNum, time = 0;


        public MainWindow()
        {
            InitializeComponent();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {


            if (!Directory.Exists(".\\Dictionaries"))
                Directory.CreateDirectory("Dictionaries");
            foreach (var file in Directory.GetFiles("Dictionaries"))
            {
                languageSetting.Items.Add(file.Replace("Dictionaries", "").Replace("\\", ""));
            }
            languageSetting.SelectedIndex = 0;
            WordsSpeedOptions.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            wordsNum = wordsNumber.Value;
            var dict = File.ReadAllLines(".\\Dictionaries\\" + languageSetting.Text).ToList();
            RaceWindow rw = new RaceWindow(ref dict);
            this.Hide();

            rw.ShowDialog();

            switch (WordsSpeedOptions.SelectedItem)
            {

                case "CPS":
                    WordsSpeed.Text = decimal.Round(cps, 2).ToString();
                    break;
                case "CPM":
                    WordsSpeed.Text = decimal.Round(cpm, 2).ToString();
                    break;
                case "WPS":
                    WordsSpeed.Text = decimal.Round(wps, 2).ToString();
                    break;
                case "WPM":
                    WordsSpeed.Text = decimal.Round(wpm, 2).ToString();
                    break;
            }
            errorRateLabel.Text = decimal.Round(errorRate, 2).ToString() + " %";
            lastTimeLabel.Text = decimal.Round(time, 2).ToString() + " s";
            this.Show();


        }


        private void WordsSpeedOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (WordsSpeedOptions.SelectedItem)
            {
                case "CPS":
                    WordsSpeed.Text = cps.ToString();
                    break;
                case "CPM":
                    WordsSpeed.Text = cpm.ToString();
                    break;
                case "WPS":
                    WordsSpeed.Text = wps.ToString();
                    break;
                case "WPM":
                    WordsSpeed.Text = wpm.ToString();
                    break;
            }
        }
    }
}
