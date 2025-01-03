using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirtySeconds.Properties;

namespace ThirtySeconds
{
    public partial class ResultsForm : Form
    {
        private Form1 form1;
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            lblSummary.Text = clsGame.GameSummary;
            lblFinalResult.Text = clsGame.GameResult;
            pbTeam1.Image = AddTeamForm.Team1.Image != null ? AddTeamForm.Team1.Image : Resources.logo1;
            pbTeam2.Image = AddTeamForm.Team2.Image != null ? AddTeamForm.Team2.Image : Resources.logo1;
            lblTeam1.Text = AddTeamForm.Team1.Name;
            lblTeam2.Text = AddTeamForm.Team2.Name;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeamForm.ResetGame();
            NumberOfRoundsForm.ResetGame();
        }
    }
}
