using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThirtySeconds
{
    public partial class AddTeamForm : Form
    {
        public struct TeamSt
        {
            public string Name { get; set; }
            public Image Image { get; set; }
            public byte Score { get; set; }
            public byte WinningRounds { get; set; }

            public TeamSt(string name, Image image)
            {
                Name = name;
                Image = image;
                Score = 0;
                WinningRounds = 0;
            }

            public void IncrementScore()
            {
                if (Score < byte.MaxValue)
                {
                    Score++;
                }
            }

            public void DecrementScore()
            {
                if (Score >= 0)
                {
                    Score++;
                }
            }
        }
        public static TeamSt Team1 { get; private set; }
        public static TeamSt Team2 { get; private set; }
        public enum CurrentTeam { Team1, Team2 };
        public static CurrentTeam TheCurrentTeam { get; set; }
        public static TeamSt TurnPlayer { get; set; }
        public static void ModifyScore(bool increment = true)
        {
            TeamSt team;
            team = TurnPlayer;
            team.Score = increment ? (byte)(team.Score + 1) : (byte)(team.Score - 1);
            TurnPlayer = team;
        }

        public static void IncrementWinningRounds(CurrentTeam enTeam)
        {
            TeamSt team;
            team = enTeam == CurrentTeam.Team1 ? Team1 : Team2;
            team.WinningRounds++;
            if (enTeam == CurrentTeam.Team1)
            {
                Team1 = team;
            }
            else if (enTeam == CurrentTeam.Team2)
            {
                Team2 = team;
            }
        }

        public AddTeamForm()
        {
            InitializeComponent();
            TheCurrentTeam = CurrentTeam.Team1;
            this.KeyPreview = true;
            this.KeyDown += AddTeamForm_KeyDown;
        }

        private void AddTeamForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        public void ChangeCurrentTeam()
        {

        }

        public void ChangeLabelText()
        {
            lblTeam.Text = TheCurrentTeam == CurrentTeam.Team2 ? "Second Team Name" :
                "First Team Name";
        }

        public void ClearForm()
        {
            tbTeamName.Text = "";
            pictureBox1.Image = null;
        }

        public static void ResetTeamScores()
        {
            TeamSt team = Team1;
            team.Score = 0;
            Team1 = team;
            team = Team2;
            team.Score = 0;
            Team2 = team;
        }

        private void BtnBrowseImg_Click(object sender, EventArgs e)
        {
            if (fdImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fdImage.FileName);
            }
        }

        private void SaveTeamData()
        {
            TeamSt Team = TheCurrentTeam == CurrentTeam.Team1 ? Team1 : Team2;
            Team.Name = tbTeamName.Text.Trim();
            Team.Image = pictureBox1.Image;
            if (TheCurrentTeam == CurrentTeam.Team1)
            {
                Team1 = Team;
                TheCurrentTeam = CurrentTeam.Team2;
                ClearForm();
            }
            else
                Team2 = Team;
            this.Hide();
            if (Team1.Name?.Trim().Length > 0 && Team2.Name?.Trim().Length > 0)
                if (Team1.Name?.Trim() == Team2.Name?.Trim())
                {
                    MessageBox.Show("Please Pick Different Team Names!", "Error",
                        MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                    Team.Name = null;
                    Team.Image = null;
                    Team1 = Team;
                    Team2 = Team;
                    ClearForm();
                    TheCurrentTeam = CurrentTeam.Team1;
                    ChangeLabelText();
                }
                else if (MessageBox.Show($"Team1: {Team1.Name}\nTeam2: {Team2.Name}\nTeams Saved Successfully",
                    "Success", MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show("Please Click Start to Select Start 1st Round", "Start",
                        MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information);
                    TheCurrentTeam = CurrentTeam.Team1;
                }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (tbTeamName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a valid name!",
                    "Warning",
                    MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning);
            }
            else
            {
                SaveTeamData();
            }
        }

        private void AddTeamForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void ResetGame()
        {
            Team1 = new TeamSt();
            Team2 = new TeamSt();
        }

        public static void SaveTeamScore()
        {
            AddTeamForm.TeamSt team;
            team = AddTeamForm.TurnPlayer;
            if (TurnPlayer.Name == Team1.Name && TurnPlayer.Image == Team1.Image)
                AddTeamForm.Team1 = team;
            else
                AddTeamForm.Team2 = team;
        }
    }
}
