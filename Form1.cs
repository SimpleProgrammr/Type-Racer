using System.DirectoryServices.ActiveDirectory;

namespace Type_Racer
{
    public partial class MainWindow : Form
    {
        public static float cps = 0, cpm = 0, wpm = 0, wps = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(".\\Dictionaries"))
                Directory.CreateDirectory("Dictionaries");
            foreach (var file in Directory.GetFiles("Dictionaries"))
            {
                languageSetting.Items.Add(file.Replace("Dictionaries\\", ""));
            }
            languageSetting.SelectedIndex = 0;
            WordsSpeedOptions.SelectedIndex = 0;
        }

        private void WordsSpeedOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
