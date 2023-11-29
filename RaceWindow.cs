using System;
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
        private static int clicks = 0, words = 0;
        public static System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public RaceWindow()
        {
            InitializeComponent();
        }

        private void RaceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var time = timer.ElapsedMilliseconds;
            MainWindow.wps = words / (time / 1000);
            MainWindow.wpm = words / (time / 1000) / 60;
            MainWindow.cps = clicks / (time / 1000);
            MainWindow.cpm = clicks / (time / 1000) / 60;
        }
    }
}
