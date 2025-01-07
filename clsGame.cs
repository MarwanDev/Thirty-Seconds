using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ThirtySeconds.ClsRound;

namespace ThirtySeconds
{
    internal class clsGame
    {
        public byte NumberOfRounds { get; private set; }
        private List<ClsRound> _Rounds;
        public byte CurrentRoundNumber { get; private set; }
        public enum enWinner
        {
            Team1,
            Team2,
            Draw,
            TBD
        };
        private enWinner Winner { get; set; }
        public string QuestionTypeText { get; set; }
        List<CheckBox> _CheckBoxes;
        Timer _Timer;
        public static string GameSummary { get; private set; }
        public static string GameResult { get; private set; }

        public clsGame(
            byte numberOfRounds,
            List<CheckBox> checkBoxes,
            Timer timer)
        {
            NumberOfRounds = numberOfRounds;
            Winner = enWinner.TBD;
            _Rounds = new List<ClsRound>();
            QuestionTypeText = "";
            _Timer = timer;
            _CheckBoxes = checkBoxes;
            CurrentRoundNumber = 1;
        }

        public QuestionTypeEn SetRoundQuestionType()
        {
            return QuestionTypeText == "Programming" ? QuestionTypeEn.Programming :
                QuestionTypeText == "TV Shows" ? QuestionTypeEn.TVShows :
                QuestionTypeText == "Movies" ? QuestionTypeEn.Movies :
                QuestionTypeText == "Sports" ? QuestionTypeEn.Sports :
                QuestionTypeText == "Hobbies" ? QuestionTypeEn.Hobbies :
                QuestionTypeText == "Nationalities" ? QuestionTypeEn.Nationalities :
                QuestionTypeEn.SchoolSubjects;
        }

        public bool IsGameOver()
        {
            return NumberOfRounds == _Rounds.Count;
        }

        private void SetGameResultText()
        {
            GameResult = Winner != enWinner.TBD ?
                Winner == enWinner.Draw ?
                $"{AddTeamForm.Team1.WinningRounds} - " +
                $"{AddTeamForm.Team2.WinningRounds}\n" +
                $"Draw 🤝" :
                Winner == enWinner.Team1 ?
                $"{AddTeamForm.Team1.WinningRounds} - " +
                $"{AddTeamForm.Team2.WinningRounds}\n" +
                $"{AddTeamForm.Team1.Name} Wins 🎉" :
                Winner == enWinner.Team2 ?
                $"{AddTeamForm.Team1.WinningRounds} - " +
                $"{AddTeamForm.Team2.WinningRounds}\n" +
                $"{AddTeamForm.Team2.Name} Wins 🎉" : null : null;
        }

        public ClsRound CurrentRound { get; set; }

        private void ShowResultTextBox(string result)
        {
            MessageBox.Show(result, "Result", MessageBoxButtons.OK);
        }

        private void ModifyTeamWonRounds()
        {
            if (CurrentRound.RoundWinner == ClsRound.Winner.Team1)
                AddTeamForm.IncrementWinningRounds(AddTeamForm.CurrentTeam.Team1);
            else if (CurrentRound.RoundWinner == ClsRound.Winner.Team2)
                AddTeamForm.IncrementWinningRounds(AddTeamForm.CurrentTeam.Team2);
        }

        private void SetGameSummary()
        {
            byte counter = 1;
            foreach (ClsRound round in _Rounds)
            {
                GameSummary += $"Round {counter}: {round.Team1.Score} - {round.Team2.Score}\n";
                counter++;
            }
        }

        private void CalculateGameWinner()
        {
            Winner = AddTeamForm.Team1.WinningRounds == AddTeamForm.Team2.WinningRounds ? enWinner.Draw :
                AddTeamForm.Team1.WinningRounds > AddTeamForm.Team2.WinningRounds ? enWinner.Team1 :
                AddTeamForm.Team1.WinningRounds < AddTeamForm.Team2.WinningRounds ?  enWinner.Team2 : enWinner.TBD;
        }

        public void FinalizeGame()
        {
            CalculateGameWinner();
            SetGameResultText();
            SetGameSummary();
        }

        public void AddRoundToList()
        {
            CurrentRound.Team1 = AddTeamForm.Team1;
            CurrentRound.Team2 = AddTeamForm.Team2;
            CurrentRound.CalculateWinner();
            ModifyTeamWonRounds();
            string roundResult = CurrentRound.RoundWinner != ClsRound.Winner.TBD ?
                CurrentRound.RoundWinner == ClsRound.Winner.Draw ?
                "The Round Ended With Draw 🤝" :
                CurrentRound.RoundWinner == ClsRound.Winner.Team1 ?
                $"{CurrentRound.Team1.Name} is the Round {CurrentRoundNumber} Winner 🎉" :
                CurrentRound.RoundWinner == ClsRound.Winner.Team2 ?
                $"{CurrentRound.Team2.Name} is the Round {CurrentRoundNumber} Winner 🎉" : null : null;
            _Rounds.Add(CurrentRound);
            MessageBox.Show("Round is Over!!!", "Saved", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            MessageBox.Show($"Team1: {CurrentRound.Team1.Name} Score: {CurrentRound.Team1.Score}", "Score", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            MessageBox.Show($"Team2: {CurrentRound.Team2.Name} Score: {CurrentRound.Team2.Score}", "Score", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            if (roundResult != null)
                ShowResultTextBox(roundResult);
        }

        public void ShowConsole()
        {
            foreach (ClsRound round in _Rounds)
            {
                Console.WriteLine($"{round.Team1.Score} - {round.Team2.Score}");
            }
        }

        public void StartGameRound()
        {
            if (AddTeamForm.Team1.Name != null && AddTeamForm.Team2.Name != null)
            {
                ClsRound round =
                    new ClsRound(QuestionTypeEn.Nationalities,
                    checkBoxes: _CheckBoxes,
                    timer: _Timer);
                CurrentRound = round;
                CurrentRoundNumber = _Rounds.Count > 0 ? (byte)(_Rounds.Count + 1) : (byte)1;
            }
        }
    }
}
