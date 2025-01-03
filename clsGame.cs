using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ThirtySeconds.clsRound;

namespace ThirtySeconds
{
    internal class clsGame
    {
        public byte NumberOfRounds { get; private set; }
        private List<clsRound> _Rounds;
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
            _Rounds = new List<clsRound>();
            QuestionTypeText = "";
            _Timer = timer;
            _CheckBoxes = checkBoxes;
            CurrentRoundNumber = 1;
        }

        public enQuestionType SetRoundQuestionType()
        {
            return QuestionTypeText == "Programming" ? enQuestionType.Programming :
                QuestionTypeText == "TV Shows" ? enQuestionType.TVShows :
                QuestionTypeText == "Movies" ? enQuestionType.Movies :
                QuestionTypeText == "Sports" ? enQuestionType.Sports :
                QuestionTypeText == "Hobbies" ? enQuestionType.Hobbies :
                QuestionTypeText == "Nationalities" ? enQuestionType.Nationalities :
                enQuestionType.SchoolSubjects;
        }

        public bool IsGameOver()
        {
            return NumberOfRounds == _Rounds.Count;
        }

        private void SetGameResultText()
        {
            GameResult = Winner != enWinner.TBD ? Winner == enWinner.Draw ? "Draw 🤝" : 
                Winner == enWinner.Team1 ? $"{AddTeamForm.Team1.Name} Wins 🎉" :
                Winner == enWinner.Team1 ? $"{AddTeamForm.Team2.Name} Wins 🎉" : null : null;
        }

        public clsRound CurrentRound { get; set; }

        private void ShowResultTextBox(string result)
        {
            MessageBox.Show(result, "Result", MessageBoxButtons.OK);
        }

        private void ModifyTeamWonRounds()
        {
            if (CurrentRound.RoundWinner == clsRound.enWinner.Team1)
                AddTeamForm.IncrementWinningRounds(AddTeamForm.enCurrentTeam.Team1);
            else if (CurrentRound.RoundWinner == clsRound.enWinner.Team2)
                AddTeamForm.IncrementWinningRounds(AddTeamForm.enCurrentTeam.Team2);
        }

        private void SetGameSummary()
        {
            byte counter = 1;
            foreach(clsRound round in _Rounds)
            {
                GameSummary += $"Round {counter}: {round.Team1.Score} - {round.Team2.Score}\n";
                counter++;
            }
        }

        private void CalculateGameWinner()
        {
            Winner = AddTeamForm.Team1.WinningRounds == AddTeamForm.Team2.WinningRounds ? enWinner.Draw :
                AddTeamForm.Team1.WinningRounds > AddTeamForm.Team2.WinningRounds ? enWinner.Team1 : enWinner.Team2;
        }

        public void ShowFinalMessageBox()
        {
            //ModifyTeamWonRounds();
            CalculateGameWinner();
            SetGameResultText();
            SetGameSummary();
            MessageBox.Show(GameSummary, "Rounds Summary");
            MessageBox.Show($"Team: {AddTeamForm.Team1.Name} Won " +
                $"{AddTeamForm.Team1.WinningRounds} Rounds\n" +
                $"Team: {AddTeamForm.Team2.Name} Won " +
                $"{AddTeamForm.Team2.WinningRounds} Rounds\n", 
                "Rounds Summary");
        }

        public void AddRoundToList()
        {
            CurrentRound.Team1 = AddTeamForm.Team1;
            CurrentRound.Team2 = AddTeamForm.Team2;
            CurrentRound.CalculateWinner();
            ModifyTeamWonRounds();
            string roundResult = CurrentRound.RoundWinner != clsRound.enWinner.TBD ?
                CurrentRound.RoundWinner == clsRound.enWinner.Draw ?
                "The Round Ended With Draw 🤝" :
                CurrentRound.RoundWinner == clsRound.enWinner.Team1 ? 
                $"{CurrentRound.Team1.Name} is the Round {CurrentRoundNumber} Winner 🎉" : 
                CurrentRound.RoundWinner == clsRound.enWinner.Team2 ?
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
            foreach(clsRound round in _Rounds)
            {
                Console.WriteLine($"{round.Team1.Score} - {round.Team2.Score}");
            }
        }

        public void StartGameRound()
        {
            if (AddTeamForm.Team1.Name != null && AddTeamForm.Team2.Name != null)
            {
                clsRound round =
                    new clsRound(enQuestionType.Nationalities,
                    checkBoxes: _CheckBoxes,
                    timer: _Timer);
                CurrentRound = round;
                CurrentRoundNumber = _Rounds.Count > 0 ? (byte)(_Rounds.Count + 1) : (byte)1;
            }
        }
    }
}
