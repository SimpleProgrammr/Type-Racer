using System.DirectoryServices.ActiveDirectory;

namespace Type_Racer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!Directory.Exists(".\\Dictionaries"))
                Directory.CreateDirectory("Dictionaries");
            foreach (var file in Directory.GetFiles("Dictionaries"))
            {
                languageSetting.Items.Add(file.ToString());
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
