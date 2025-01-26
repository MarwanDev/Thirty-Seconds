using System;
using System.Windows.Forms;
using ThirtySeconds.Properties;

namespace ThirtySeconds
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            lblSummary.Text = ClsGame.GameSummary;
            lblFinalResult.Text = ClsGame.GameResult;
            pbTeam1.Image = AddTeamForm.Team1.Image != null ? AddTeamForm.Team1.Image : Resources.logo1;
            pbTeam2.Image = AddTeamForm.Team2.Image != null ? AddTeamForm.Team2.Image : Resources.logo1;
            lblTeam1.Text = AddTeamForm.Team1.Name;
            lblTeam2.Text = AddTeamForm.Team2.Name;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form1.ResetGame();
            this.Hide();
        }
    }
}
