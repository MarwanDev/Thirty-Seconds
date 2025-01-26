using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThirtySeconds
{
    internal class ClsRound
    {
        public enum QuestionTypeEn
        {
            Programming,
            TVShows,
            Movies,
            Sports,
            Hobbies,
            SchoolSubjects,
            Nationalities
        };
        public QuestionTypeEn QuestionType { get; set; }
        public enum Winner
        {
            Team1,
            Team2,
            Draw,
            TBD
        };
        public Winner RoundWinner { get; set; }
        public AddTeamForm.TeamSt CurrentTeam { get; set; }
        public AddTeamForm.TeamSt Team1 { get; set; }
        public AddTeamForm.TeamSt Team2 { get; set; }
        public bool IsWaiting { get; set; }
        private List<string> _LargeList;
        private List<string> _Questions;
        private List<CheckBox> _CheckBoxes;
        private readonly Timer _Timer;
        private readonly Random random = new Random();
        public bool IsTimeOver { get; set; }
        public bool IsTurnOver { get; set; }
        public bool IsRoundOver { get; set; }

        public void CalculateWinner()
        {
            RoundWinner = AddTeamForm.Team1.Score == AddTeamForm.Team2.Score ?
                Winner.Draw : AddTeamForm.Team1.Score > AddTeamForm.Team2.Score ?
                Winner.Team1 : Winner.Team2;
        }

        public ClsRound(
            QuestionTypeEn questionType,
            List<CheckBox> checkBoxes,
            Timer timer)
        {
            QuestionType = questionType;
            _Timer = timer;
            _Questions = new List<string>();
            _CheckBoxes = checkBoxes;
            FillLargeList(ref _LargeList);
            IsWaiting = false;
            IsRoundOver = false;
            RoundWinner = Winner.TBD;
        }

        private byte GetRandomNumber(int Min = 0, int Max = 5000)
        {
            byte number = (byte)random.Next(Min, Max);
            return number;
        }

        private void FillLargeList(ref List<string> largeList)
        {
            largeList = QuestionType == QuestionTypeEn.Nationalities ?
                new List<string>
                {
                    "Afghanistan", "Argentina", "Australia", "Austria", "Bangladesh",
                    "Belgium", "Brazil", "Canada", "China", "Colombia",
                    "Denmark", "Egypt", "Finland", "France", "Germany",
                    "Greece", "Hungary", "India", "Indonesia", "Ireland",
                    "Italy", "Japan", "Kenya", "Malaysia", "Mexico",
                    "Netherlands", "New Zealand", "Nigeria", "Norway", "Pakistan",
                    "Philippines", "Poland", "Portugal", "Russia", "Saudi Arabia",
                    "Singapore", "South Africa", "South Korea", "Spain", "Sweden",
                    "Switzerland", "Thailand", "Turkey", "Uganda", "Ukraine",
                    "United Arab Emirates", "United Kingdom", "United States", "Vietnam", "Zimbabwe"
                } : QuestionType == QuestionTypeEn.Hobbies ?
                new List<string>
                {
                    "Reading", "Writing", "Painting", "Drawing", "Gardening",
                    "Cooking", "Baking", "Photography", "Hiking", "Cycling",
                    "Fishing", "Camping", "Knitting", "Crocheting", "Sewing",
                    "Woodworking", "Playing Guitar", "Playing Piano", "Singing", "Dancing",
                    "Yoga", "Meditation", "Running", "Swimming", "Skating",
                    "Surfing", "Rock Climbing", "Traveling", "Bird Watching", "Stargazing",
                    "Gaming", "Coding", "Blogging", "Podcasting", "Calligraphy",
                    "Pottery", "Scrapbooking", "Journaling", "Puzzle Solving", "Chess",
                    "Collecting Stamps", "Collecting Coins", "Playing Board Games", "Martial Arts", "Weightlifting",
                    "Cooking Exotic Dishes", "Volunteering", "DIY Projects", "Origami", "Learning Languages"
                } : QuestionType == QuestionTypeEn.TVShows ?
                new List<string>
                {
                    "Breaking Bad", "Game of Thrones", "Stranger Things", "The Office", "Friends",
                    "Sherlock", "The Crown", "The Mandalorian", "The Simpsons", "Rick and Morty",
                    "Grey's Anatomy", "House of the Dragon", "The Witcher", "Better Call Saul", "The Walking Dead",
                    "The Big Bang Theory", "How I Met Your Mother", "Parks and Recreation", "Brooklyn Nine-Nine", "Succession",
                    "The Sopranos", "Lost", "Dexter", "Fargo", "Westworld",
                    "Black Mirror", "Arrested Development", "Modern Family", "Ozark", "Mad Men",
                    "Narcos", "The Boys", "The Umbrella Academy", "Peaky Blinders", "The Handmaid's Tale",
                    "Money Heist", "Chernobyl", "The Wire", "Vikings", "Seinfeld",
                    "Supernatural", "Doctor Who", "CSI: Crime Scene Investigation", "NCIS", "Criminal Minds",
                    "Lucifer", "Arrow", "The Flash", "Smallville", "Gotham"
                } : QuestionType == QuestionTypeEn.Programming ?
                new List<string>
                {
                    "Algorithm", "Bug", "Cloud", "Database", "Compiler",
                    "Encryption", "Firewall", "Framework", "Frontend", "Backend",
                    "Git", "HTTP", "API", "IDE", "Machine Learning",
                    "Artificial Intelligence", "Blockchain", "Cache", "Cookie", "DNS",
                    "Syntax", "Loop", "Variable", "Function", "Object",
                    "Class", "Inheritance", "Polymorphism", "JSON", "Array",
                    "Bit", "Byte", "Cloud Computing", "Server", "IP Address",
                    "Python", "Java", "C#", "HTML", "CSS",
                    "JavaScript", "SQL", "NoSQL", "DevOps", "Debugging",
                    "Binary", "Assembly", "SDK", "Open Source", "Virtual Machine"
                } : QuestionType == QuestionTypeEn.SchoolSubjects ?
                new List<string>
                {
                    "Mathematics", "Physics", "Chemistry", "Biology", "English",
                    "History", "Geography", "Physical Education", "Music", "Art",
                    "Computer Science", "Economics", "Business Studies", "Philosophy", "Psychology",
                    "Sociology", "Political Science", "Environmental Science", "Literature", "Drama",
                    "French", "Spanish", "German", "Mandarin", "Latin",
                    "Statistics", "Algebra", "Geometry", "Trigonometry", "Calculus",
                    "Astronomy", "Health Education", "Ethics", "Robotics", "Engineering",
                    "Accounting", "Law", "Media Studies", "Graphic Design", "Creative Writing",
                    "Anthropology", "Public Speaking", "Civics", "Agriculture", "World Religions",
                    "Photography", "Design and Technology", "Global Studies", "Zoology", "Botany"
                } : QuestionType == QuestionTypeEn.Movies ?
                new List<string>
                {
                    "The Godfather", "The Shawshank Redemption", "Pulp Fiction", "Forrest Gump", "The Dark Knight",
                    "Inception", "Titanic", "The Matrix", "Jurassic Park", "The Avengers",
                    "Star Wars", "The Lion King", "Harry Potter", "Frozen", "Toy Story",
                    "The Lord of the Rings", "Avatar", "Spider-Man", "Iron Man", "Black Panther",
                    "The Joker", "The Silence of the Lambs", "Goodfellas", "Gladiator", "Interstellar",
                    "The Departed", "Saving Private Ryan", "Schindler's List", "Parasite", "La La Land",
                    "The Wolf of Wall Street", "The Social Network", "12 Angry Men", "Fight Club", "Coco",
                    "Finding Nemo", "Beauty and the Beast", "Aladdin", "Moana", "Shrek",
                    "Up", "Monsters, Inc.", "Inside Out", "Zootopia", "Encanto",
                    "Frozen II", "Avengers: Endgame", "The Batman", "Dune", "The Hunger Games"
                } : new List<string>
                {
                    "Soccer", "Basketball", "Tennis", "Cricket", "Baseball",
                    "American Football", "Rugby", "Hockey", "Golf", "Table Tennis",
                    "Volleyball", "Badminton", "Swimming", "Track and Field", "Boxing",
                    "Wrestling", "Cycling", "Skateboarding", "Surfing", "Snowboarding",
                    "Skiing", "Ice Skating", "Figure Skating", "Gymnastics", "Rowing",
                    "Canoeing", "Kayaking", "Archery", "Shooting", "Martial Arts",
                    "Karate", "Judo", "Taekwondo", "Mixed Martial Arts", "Fencing",
                    "Weightlifting", "Powerlifting", "Bodybuilding", "Rock Climbing", "Bouldering",
                    "Horse Racing", "Equestrian", "Darts", "Snooker", "Bowling",
                    "Handball", "Water Polo", "Triathlon", "Decathlon", "Skating",
                    "Ultimate Frisbee", "Lacrosse", "Pickleball"
                };
        }

        private void FillQuestions(ref List<string> questions)
        {
            questions = new List<string>();
            for (byte i = 0; i < 5; i++)
            {
                string question;
                do
                {
                    question = _LargeList[GetRandomNumber(0, _LargeList.Count)];
                } while (questions.Contains(question));
                questions.Add(question);
            }
        }

        private void FillCheckBoxes(ref List<CheckBox> checkBoxes)
        {
            for (byte i = 0; i < 5; i++)
            {
                checkBoxes[i].Text = _Questions[i];
            }
        }

        public bool AreAllCheckBoxesChecked()
        {
            foreach (CheckBox checkBox in _CheckBoxes)
            {
                if (!checkBox.Checked)
                    return false;
            }
            return true;
        }

        private void UncheckAllCheckBoxes(bool isEnabled = false)
        {
            foreach (CheckBox checkBox in _CheckBoxes)
            {
                if (checkBox.Checked)
                    checkBox.Checked = false;
                checkBox.Enabled = isEnabled;
            }
        }

        public void DoNextStep()
        {
            if (AddTeamForm.TurnPlayer.Name == AddTeamForm.Team1.Name &&
                AddTeamForm.TurnPlayer.Image == AddTeamForm.Team1.Image)
            {
                Form1.Time = 10;
                IsTimeOver = false;
                IsTurnOver = false;
                _Timer.Enabled = true;
                IsWaiting = true;
                UncheckAllCheckBoxes();
            }
            else
            {
                IsWaiting = false;
                IsTimeOver = false;
                IsTurnOver = false;
                _Timer.Enabled = false;
                UncheckAllCheckBoxes();
            }
        }

        private void StartTurn()
        {
            Form1.Time = 30;
            IsTimeOver = false;
            IsTurnOver = false;
            _Timer.Enabled = true;
        }

        public void ChangeCurrentTeam()
        {
            if (CurrentTeam.Name == AddTeamForm.Team1.Name && CurrentTeam.Image == AddTeamForm.Team1.Image)
            {
                CurrentTeam = AddTeamForm.Team2;
            }
            else
            {
                CurrentTeam = AddTeamForm.Team1;
            }
        }

        private void SaveTeam(ref AddTeamForm.TeamSt team)
        {
            if (IsTurnOver)
            {
                team = AddTeamForm.TurnPlayer;
                ChangeCurrentTeam();
            }
        }

        private void PlayTurn(AddTeamForm.TeamSt team)
        {
            FillQuestions(ref _Questions);
            FillCheckBoxes(ref _CheckBoxes);
            StartTurn();
            SaveTeam(ref team);
            UncheckAllCheckBoxes(true);
        }

        public void StartSecondTurn()
        {
            PlayTurn(AddTeamForm.Team2);
        }

        public void StartRound()
        {
            FillLargeList(ref _LargeList);
            PlayTurn(AddTeamForm.Team1);
        }
    }
}
