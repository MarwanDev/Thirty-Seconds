using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ThirtySeconds.Properties;

namespace ThirtySeconds
{
    public partial class Form1 : Form
    {
        private clsGame Game;
        private NumberOfRoundsForm numberOfRoundsForm;
        private AddTeamForm addTeamForm;
        private static byte _NumberOfRounds;
        public static byte Time { get; set; }
        public AddTeamForm.enCurrentTeam CurrentTeam { get; private set; }
        private readonly ResultsForm resultsForm;

        private readonly List<CheckBox> _CheckBoxes;
        public Form1()
        {
            InitializeComponent();
            _NumberOfRounds = 0;
            _CheckBoxes = new List<CheckBox>();
            FillCheckBoxesList(ref _CheckBoxes);
            resultsForm = new ResultsForm();
        }

        private void FillCheckBoxesList(ref List<CheckBox> CheckBoxes)
        {
            CheckBoxes.Add(checkBox1);
            CheckBoxes.Add(checkBox2);
            CheckBoxes.Add(checkBox3);
            CheckBoxes.Add(checkBox4);
            CheckBoxes.Add(checkBox5);
        }

        private static void InitializeGame()
        {
            pbLogo.Left = 325;
            pbLogo.Top = 150;
            lblImageHeader.Left = 350;
            lblImageHeader.Top = 400;
            btnGameRules.Enabled = true;
            cbQuestionType.Enabled = false;
            lblQuestionType.Visible = false;
            btnStartRound.Visible = false;
            lblTime.Visible = false;
            pnlRound.Visible = false;
            btnReset.Enabled = false;
            lblTime.Visible = false;
            lblScore.Visible = false;
            btnStart.Enabled = true;
            llSkipCountDown.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
            MaximizeBox = false;
            MinimizeBox = false;
            cbQuestionType.Text = "Nationalities";
            lblQuestionType.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            numberOfRoundsForm = new NumberOfRoundsForm();
            addTeamForm = new AddTeamForm();
        }

        private void BtnGameRules_Click(object sender, EventArgs e)
        {
            pbLogo.Visible = false;
            lblImageHeader.Visible = false;
            gbGame.Visible = true;
            btnNext.Visible = true;
        }

        private void Rd_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
            cbQuestionType.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
            numberOfRoundsForm.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
            addTeamForm.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
            cbQuestionType.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
            resultsForm.BackColor = rdDark.Checked == true ? Color.FromArgb(28, 28, 28) : Color.White;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            gbGame.Visible = false;
            pbLogo.Visible = true;
            lblImageHeader.Visible = true;
            btnNext.Visible = false;
        }

        private void ModifyRoundText()
        {
            lblRound.Text = $"Round {Game.CurrentRoundNumber}/{Game.NumberOfRounds}";
        }

        private void StartGame()
        {
            cbQuestionType.Visible = true;
            cbQuestionType.Enabled = true;
            btnStartRound.Visible = true;
            btnStartRound.Enabled = true;
            btnStart.Enabled = false;
            Game = new clsGame(
                numberOfRounds: _NumberOfRounds,
                checkBoxes: _CheckBoxes,
                timer: timer);
            ModifyRoundText();
            Game.StartGameRound();
        }

        private void SaveTeams()
        {
            CurrentTeam = AddTeamForm.enCurrentTeam.Team1;
            addTeamForm.ClearForm();
            addTeamForm.ChangeLabelText();
            addTeamForm.ShowDialog();
            addTeamForm.ChangeLabelText();
            addTeamForm.ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (_NumberOfRounds == 0)
            {
                numberOfRoundsForm.ShowDialog();
                _NumberOfRounds = NumberOfRoundsForm.NumberOfRounds;
                if (!numberOfRoundsForm.Visible && _NumberOfRounds > 0)
                {
                    SaveTeams();
                }
            }
            else if (!addTeamForm.Visible &&
                    AddTeamForm.Team1.Name == null ||
                    AddTeamForm.Team2.Name == null)
                SaveTeams();
            else
            {
                StartGame();
            }
        }

        private void ModifyTurnUI()
        {
            lblCurrentTurn.Text = AddTeamForm.TurnPlayer.Name;
            pbCurrentTeam.Image = AddTeamForm.TurnPlayer.Image ?? Resources.logo1;
        }

        private void BtnStartRound_Click(object sender, EventArgs e)
        {
            btnGameRules.Enabled = false;
            gbGame.Visible = false;
            lblImageHeader.Visible = false;
            pbLogo.Visible = false;
            pnlRound.Left = 50;
            pnlRound.Top = 100;
            pnlRound.Visible = true;
            btnReset.Enabled = true;
            Game.QuestionTypeText = cbQuestionType.Text;
            Game.CurrentRound.QuestionType = Game.SetRoundQuestionType();
            btnStartRound.Enabled = false;
            cbQuestionType.Enabled = false;
            AddTeamForm.TurnPlayer = AddTeamForm.Team1;
            ModifyTurnUI();
            ModifyRoundText();
            Game.CurrentRound.StartRound();
            lblTime.Visible = true;
            lblScore.Visible = true;
        }

        private void HandleTurn()
        {
            Game.CurrentRound.IsTimeOver = Time == 0;
            Game.CurrentRound.IsTurnOver = Game.CurrentRound.IsTimeOver ||
                Game.CurrentRound.AreAllCheckBoxesChecked();
            timer.Enabled = !Game.CurrentRound.IsTurnOver;
            if (!timer.Enabled)
                AddTeamForm.SaveTeamScore();
        }

        public void ShowResultsForm()
        {
            resultsForm.ShowDialog();
        }

        private void SaveRound()
        {
            Game.AddRoundToList();
            if (Game.IsGameOver())
            {
                Game.ShowConsole();
                Game.FinalizeGame();
                ShowResultsForm();
            }
            else
            {
                btnStartRound.Enabled = true;
                ModifyRoundText();
                cbQuestionType.Enabled = true;
                AddTeamForm.ResetTeamScores();
                Game.StartGameRound();
            }
        }

        private void ExecuteTurn()
        {
            HandleTurn();
            if (!timer.Enabled)
            {
                if (Game.CurrentRound.AreAllCheckBoxesChecked())
                    MessageBox.Show("Great Job!",
                        "Congratulations!",
                        MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information);
                lblTime.Visible = false;
                lblScore.Visible = false;
                Game.CurrentRound.DoNextStep();
                if (Game.CurrentRound.IsWaiting)
                    ExecuteWaiting();
                else
                {
                    if (AddTeamForm.TurnPlayer.Name == AddTeamForm.Team1.Name &&
                        AddTeamForm.TurnPlayer.Image == AddTeamForm.Team1.Image)
                    {
                        StartSecondTurn();
                    }
                    else
                    {
                        SaveRound();
                    }
                }
            }
        }

        private void ExecuteWaiting()
        {
            Time = 10;
            llSkipCountDown.Visible = true;
            timer.Enabled = false;
            timerWaiting.Enabled = true;
            lblTime.Visible = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            Time--;
            lblTime.Text = Time.ToString();
            ExecuteTurn();
            if (Time == 0 && (!Game.CurrentRound.IsWaiting || AddTeamForm.TurnPlayer.Name == AddTeamForm.Team2.Name))
            {
                //MessageBox.Show(
                //    $"Time's Up. Your Score is {AddTeamForm.TurnPlayer.Score}",
                //    "Time!",
                //    MessageBoxButtons.OK,
                //    icon: MessageBoxIcon.Information);
                lblTime.Visible = false;
                lblScore.Visible = false;
            }
            if (Time == 0)
            {
                lblTime.Visible = false;
                lblScore.Visible = false;
            }
        }

        private void ChangeCheckBoxFontStyle(object sender)
        {
            if (sender is CheckBox checkBox)
            {
                FontStyle style = checkBox.Checked ? FontStyle.Strikeout : FontStyle.Regular;
                checkBox.Font = new Font(checkBox.Font.FontFamily, checkBox.Font.Size, style);
            }
        }

        private void ModifyScore(object sender)
        {
            AddTeamForm.stTeam team;
            team = Game.CurrentRound.CurrentTeam;
            if (((CheckBox)sender).Checked)
                AddTeamForm.ModifyScore();
            else
                AddTeamForm.ModifyScore(false);
            Game.CurrentRound.CurrentTeam = team;
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            ModifyScore(sender);
            lblScore.Text = $"{AddTeamForm.TurnPlayer.Score}/5";
            lblScore.Refresh();
            ChangeCheckBoxFontStyle(sender);
        }

        private void StartSecondTurn()
        {
            llSkipCountDown.Visible = false;
            timer.Enabled = false;
            Game.CurrentRound.IsTurnOver = true;
            AddTeamForm.TurnPlayer = AddTeamForm.Team2;
            Game.CurrentRound.StartSecondTurn();
            ModifyTurnUI();
            lblScore.Visible = true;
        }

        private void LlSkipCountDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timerWaiting.Enabled = false;
            StartSecondTurn();
        }

        private void TimerWaiting_Tick(object sender, EventArgs e)
        {
            Time--;
            lblTime.Text = Time.ToString();
            lblTime.Refresh();
            if (Time == 0)
            {
                llSkipCountDown.Visible = false;
                timerWaiting.Enabled = false;
                timer.Enabled = true;
                StartSecondTurn();
                lblTime.Visible = false;
            }
        }

        public static void ResetGame()
        {
            _NumberOfRounds = 0;
            NumberOfRoundsForm.ResetGame();
            AddTeamForm.ResetGame();
            InitializeGame();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void LlWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://brain-cardio-naledi.netlify.app/") { UseShellExecute = true });
        }
    }
}
