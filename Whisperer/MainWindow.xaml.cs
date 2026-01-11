using System.Diagnostics;
using System.Windows;

namespace Whisperer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckForLeague();
        }

        private void CheckForLeague()
        {
            // This looks for the process "LeagueClientUx" (The UI, not the game engine)
            var leagueProcesses = Process.GetProcessesByName("LeagueClientUx");

            if (leagueProcesses.Length > 0)
            {
                var p = leagueProcesses[0];
                MessageBox.Show($"Success! League is running.\nProcess ID: {p.Id}\nWe are ready to connect.");
            }
            else
            {
                MessageBox.Show("League Client is not running. Open League and restart this app.");
            }
        }
    }
}