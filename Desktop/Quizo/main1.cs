using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace Quizo
{
    public partial class main1 : Form
    {

        public main1()
        {
            InitializeComponent();
            InitializeQuiz();
        }
        private void main1_Load(object sender, EventArgs e)
        {
            tabControlCategorie.SelectedIndex = -1;
            restart.Enabled = false;
            restart.Hide();
            exit.Enabled = false;
            exit.Hide();
        }
        private int secondsElapsed = 0;

        private Boolean buttonReadOnly = false;
        private void startQuiz_Click(object sender, EventArgs e)
        {
            if (buttonReadOnly)
            {
                return;
            }
            startQuiz.Text = "Quiz Started";
            startQuiz.ForeColor = Color.Red;

            timerQuiz.Start();
            timerQuiz1.Start();

            this.Controls.Remove(howQuizoWorks);

            allowTabChange = true;
            tabControlCategorie.SelectedTab = tabPageHistory;
            allowTabChange = false;

            currentCategorie = 1;

            levelOne.ForeColor = Color.Red;
            levelOne.Checked = true;
            levelOne.Enabled = true;
            levelTwo.Checked = false;
            levelTwo.Enabled = false;
            levelThree.Checked = false;
            levelThree.Enabled = false;

            selectedLevelQuestions = levelOneQuestions;
            buttonReadOnly = true;
        }

        private void timerQuiz1_Tick(object sender, EventArgs e)
        {
            if (timeProgressBar.Value > 0)
            {
                timeProgressBar.Value--;
            }

            if (timeProgressBar.Value == 0)
            {
                timerQuiz1.Stop();
                MessageBox.Show("Time is over! Next Question!");
                o1.Enabled = false;
                o2.Enabled = false;
                o3.Enabled = false;
                o4.Enabled = false;
                if (currentQuestionIndex == 4)
                    currentLevelCompleted = true;
            }
        }
        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;


            int minutes = secondsElapsed / 60;
            int seconds = secondsElapsed % 60;

            timeSpent.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void EndQuiz()
        {
            timerQuiz.Stop();
            timerQuiz1.Stop();
            int minutes = secondsElapsed / 60;
            int seconds = secondsElapsed % 60;
            MessageBox.Show($"Time Spent: {minutes:D2}:{seconds:D2}\n\n" +
                $"Total Score: {totalScore:D2}/1040\n\n" +
                $"You answered: {questionsAnswered:D2}/45 questions", "Quiz Finished!!!");

            restart.Enabled = true;
            restart.Show();
            exit.Enabled = true;
            exit.Show();
        }

        private void howQuizoWorks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. There are 3 different categories. Each category has 3 levels, and each level has 5 questions.\n\n" +
                "2. Complete all 5 question on each level to move to the next level and all 3 level on a categorie to move to the next categorie.\n\n" +
                "3. You have 30 seconds to answer each question. Each correct answer on level 1 earns you 5 points, level 2 - 10 and level 3 - 15.\n\n" +
                "4. Answering all 5 questions correctly in a level 1 gives you an additional 5 bonus points, Level 2 - 10 and level 3 - 15\n\n" +
                "5. Answering all questions correctly in a category/3-levels earns you an extra 100 points.\n\n" +
                "6. Answering all questions correctly in the 3 categories earns you an extra 200 points.\n\n" +
                "7. Once you press \"Start Quiz\" a timer will begin to track your total time spent on the quiz. Your quiz and score will start immediately afterward.\n\n" +
                "If you exit the application you will lose your progress and start again by loging in to your account!!!" +
                "Have fun and good luck!", "How It Works");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void levelOne_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void questionTimer_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void question1Text_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionNumber_Enter(object sender, EventArgs e)
        {

        }

        private void nextLevel_MouseHover(object sender, EventArgs e)
        {
            toolTipNextLevel.SetToolTip(nextLevel, "You Need to Finish all 5 questions!");
        }

        private void You(object sender, PopupEventArgs e)
        {

        }

        private void nextCategorie_MouseHover(object sender, EventArgs e)
        {
            toolTipNextLevel.SetToolTip(nextCategorie, "You Need to Finish all 3 levels!");
        }

        private int currentCategorie = 0;
        List<QuizQuestion> levelOneQuestions = new List<QuizQuestion>();
        List<QuizQuestion> levelTwoQuestions = new List<QuizQuestion>();
        List<QuizQuestion> levelThreeQuestions = new List<QuizQuestion>();
        private void InitializeQuiz()
        {
            levelOneQuestions.Add(new QuizQuestion("When did World War II start?", new string[] { "1939", "1941", "1914", "1945" }, 0));
            levelOneQuestions.Add(new QuizQuestion("When did the Titanic sink?", new string[] { "1905", "1912", "1923", "1898" }, 1));
            levelOneQuestions.Add(new QuizQuestion("Who led Nazi Germany during World War II?", new string[] { "Joseph Stalin", "Winston Churchill", "Adolf Hitler", "Franklin Roosevelt" }, 2));
            levelOneQuestions.Add(new QuizQuestion("When did the United States declare independence?", new string[] { "1776", "1492", "1865", "1804" }, 0));
            levelOneQuestions.Add(new QuizQuestion("The Cold War involved which superpowers?", new string[] { "The United States and Japan", "Germany and France", "The United States and the Soviet Union", "The Soviet Union and China" }, 2));

            levelTwoQuestions.Add(new QuizQuestion("Who was the first woman to fly solo across the Atlantic Ocean?", new string[] { "Amelia Earhart", "Jacqueline Cochran", "Eleanor Roosevelt", "Harriet Tubman" }, 0));
            levelTwoQuestions.Add(new QuizQuestion("The Magna Carta was signed in which year?", new string[] { "1492", "1215", "1776", "1066" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("Who discovered the Americas in 1492?", new string[] { "Ferdinand Magellan", "Christopher Columbus", "Marco Polo", "Hernan Cortes" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("What was the ship that carried the Pilgrims to America in 1620?", new string[] { "The Endeavor", "The Mayflower", "The Santa Maria", "The Nina" }, 0));
            levelTwoQuestions.Add(new QuizQuestion("In what year did the Berlin Wall fall?", new string[] { "1989", "1991", "1973", "1981" }, 0));

            levelThreeQuestions.Add(new QuizQuestion("What was the name of the first manned moon mission?", new string[] { "Apollo 11", "Apollo 13", "Gemini 6", "Mercury 7" }, 0));
            levelThreeQuestions.Add(new QuizQuestion("Who was the British Prime Minister during World War II?", new string[] { "Winston Churchill", "Neville Chamberlain", "Margaret Thatcher", "Tony Blair" }, 0));
            levelThreeQuestions.Add(new QuizQuestion("The French Revolution began in which year?", new string[] { "1789", "1804", "1776", "1815" }, 0));
            levelThreeQuestions.Add(new QuizQuestion("Which ancient civilization built the pyramids of Giza?", new string[] { "Greek", "Roman", "Egyptian", "Mesopotamian" }, 2));
            levelThreeQuestions.Add(new QuizQuestion("Who was the first emperor of China?", new string[] { "Qin Shi Huang", "Emperor Wu", "Han Wudi", "Liu Bang" }, 0));
        }

        private Boolean currentLevelCompleted = false;
        private Boolean currentCategorieCompleted = false;
        private int currentLevel = 1;
        private int currentQuestionIndex = 0;
        List<QuizQuestion> selectedLevelQuestions;
        private void DisplayNextQuestion()
        {
            if (levelTwo.Checked)
                selectedLevelQuestions = levelTwoQuestions;

            else if (levelThree.Checked)
                selectedLevelQuestions = levelThreeQuestions;


            currentQuestionIndex++;
            DisplayQuestionForLevel(selectedLevelQuestions);

            if (currentQuestionIndex >= 5)
            {
                currentQuestionIndex = 0;
                currentLevelCompleted = true;
            }
            if (currentLevelCompleted && currentLevel == 3)
            {
                currentCategorieCompleted = true;
            }

        }
        private void DisplayQuestionForLevel(List<QuizQuestion> selectedLevelQuestions)
        {
            QuizQuestion currentQuestion;
            if (currentQuestionIndex >= selectedLevelQuestions.Count)
                currentQuestion = selectedLevelQuestions[currentQuestionIndex - 1];
            else
            {
                currentQuestion = selectedLevelQuestions[currentQuestionIndex];
                questionNumber.Text = $"Question {currentQuestionIndex + 1}";
                questionText.Text = currentQuestion.Question;

                o1.Text = currentQuestion.Options[0];
                o1.Checked = false;
                o2.Text = currentQuestion.Options[1];
                o2.Checked = false;
                o3.Text = currentQuestion.Options[2];
                o3.Checked = false;
                o4.Text = currentQuestion.Options[3];
                o4.Checked = false;
            }

        }

        private int totalScore = 0;
        private void UpdateScore(int points)
        {
            totalScore += points;
            scoreValue.Text = $"Score: {totalScore}";
        }

        private int y = 0;
        private int count = 0;
        private int count1 = 0;
        private int questionsAnswered = 0;
        private void nextQuestion_Click(object sender, EventArgs e)
        {
            if (currentLevelCompleted || count == 5)
            {
                if (currentLevel == 1)
                {
                    MessageBox.Show("You have completed level 1. You can move to the next level!");
                    timerQuiz1.Stop();
                    return;
                }
                else if (currentLevel == 2)
                {
                    if (count == 5) UpdateScore(10);
                    count = 0;

                    MessageBox.Show("You have completed level 2. You can move to the next level!");
                    timerQuiz1.Stop();
                    return;


                }
                else if (currentLevel == 3)
                {
                    if (count == 5) UpdateScore(10);
                    count = 0;

                    MessageBox.Show("You have completed level 3. You can move to the next categorie!", "Conratulations!!!!");
                    timerQuiz1.Stop();

                    if (count1 == 3) UpdateScore(100);
                    count1 = 0;
                    return;
                }
            }

            bool nxtQuestion = false;
            int points = 0;
            if ((o1.Checked || o2.Checked || o3.Checked || o4.Checked) || (!o1.Enabled && !o2.Enabled && !o3.Enabled && !o4.Enabled))
            {
                int selectedOptionIndex = -1;
                if (o1.Checked) selectedOptionIndex = 0;
                if (o2.Checked) selectedOptionIndex = 1;
                if (o3.Checked) selectedOptionIndex = 2;
                if (o4.Checked) selectedOptionIndex = 3;

                QuizQuestion currentQuestion = selectedLevelQuestions[currentQuestionIndex];
                bool isCorrect = selectedOptionIndex == currentQuestion.CorrectAnswerIndex;
                y++;
                Label label = questionsTable.GetControlFromPosition(0, y) as Label;

                if (label != null)
                    label.ForeColor = isCorrect ? Color.Green : Color.Red;

                if (isCorrect)
                {
                    questionsAnswered++;
                    if (currentLevel == 1)
                    {
                        points += 5;
                        count++;
                    }
                    else if (currentLevel == 2)
                    {
                        points += 10;
                        count++;
                    }

                    else if (currentLevel == 3)
                    {
                        points += 15;
                        count++;
                    }
                }
                UpdateScore(points);
                if (count == 5) count1++;

                nxtQuestion = true;
                o1.Enabled = true;
                o2.Enabled = true;
                o3.Enabled = true;
                o4.Enabled = true;
            }
            else
                MessageBox.Show("Please choose an answer!");

            if (nxtQuestion && currentLevelCompleted == false)
            {
                DisplayNextQuestion();
                if (currentLevelCompleted)
                {
                    timerQuiz1.Stop();
                }
                else
                {
                    timeProgressBar.Maximum = 30;
                    timeProgressBar.Value = 30;
                    timerQuiz1.Start();
                }
                if (count == 5)
                {
                    if (currentLevel == 1)
                        UpdateScore(5);
                    else if (currentLevel == 2)
                        UpdateScore(10);
                    else if (currentLevel == 3)
                        UpdateScore(15);
                    count = 0;
                    currentLevelCompleted = true;
                }

                if (count1 == 3)
                {
                    UpdateScore(100);
                    count1 = 0;
                    currentLevelCompleted = true;
                }

                if (totalScore == 840)
                    UpdateScore(200);

                if (currentCategorie == 3 && currentCategorieCompleted)
                {
                    submit.Enabled = false;
                    nextLevel.Enabled = false;
                    nextCategorie.Enabled = false;
                    EndQuiz();
                }
            }
        }

        private void nextLevel_Click(object sender, EventArgs e)
        {
            if (levelThree.Checked && currentCategorie == 3)
            {
                MessageBox.Show("This is the last Level in the last categorie!");
                return;
            }

            if (levelOne.Checked && currentLevelCompleted)
            {
                currentLevel = 2;
                levelTwo.Enabled = true;
                levelTwo.Checked = true;
                levelTwo.ForeColor = Color.Red;

                levelOne.Checked = false;
                levelOne.Enabled = false;

                levelThree.Checked = false;
                levelThree.Enabled = false;

                currentLevelCompleted = false;

                QuizQuestion currentQuestion = levelTwoQuestions[0];
                questionNumber.Text = $"Question {currentQuestionIndex + 1}";
                questionText.Text = currentQuestion.Question;

                o1.Text = currentQuestion.Options[0];
                o1.Checked = false;
                o2.Text = currentQuestion.Options[1];
                o2.Checked = false;
                o3.Text = currentQuestion.Options[2];
                o3.Checked = false;
                o4.Text = currentQuestion.Options[3];
                o4.Checked = false;

                timeProgressBar.Maximum = 30;
                timeProgressBar.Value = 30;
                timerQuiz1.Start();
                count = 0;

                y = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Label label = questionsTable.GetControlFromPosition(0, i) as Label;
                    if (label != null)
                        label.ForeColor = Color.Black;
                }

            }
            else if (levelTwo.Checked && currentLevelCompleted)
            {
                currentLevel = 3;

                levelThree.Enabled = true;
                levelThree.Checked = true;
                levelThree.ForeColor = Color.Red;

                levelTwo.Checked = false;
                levelTwo.Enabled = false;

                levelOne.Checked = false;
                levelOne.Enabled = false;

                currentLevelCompleted = false;

                QuizQuestion currentQuestion = levelThreeQuestions[0];
                questionNumber.Text = $"Question {currentQuestionIndex + 1}";
                questionText.Text = currentQuestion.Question;

                o1.Text = currentQuestion.Options[0];
                o1.Checked = false;
                o2.Text = currentQuestion.Options[1];
                o2.Checked = false;
                o3.Text = currentQuestion.Options[2];
                o3.Checked = false;
                o4.Text = currentQuestion.Options[3];
                o4.Checked = false;

                timeProgressBar.Maximum = 30;
                timeProgressBar.Value = 30;
                timerQuiz1.Start();
                count = 0;

                y = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Label label = questionsTable.GetControlFromPosition(0, i) as Label;
                    if (label != null)
                        label.ForeColor = Color.Black;
                }

            }
            else if (levelThree.Checked && currentLevelCompleted)
            {
                currentCategorieCompleted = true;
                MessageBox.Show("No more levels in this categorie. You can move to the next one!");
                timerQuiz.Stop();
            }

            else
                MessageBox.Show("You need to finish all 5 questiono to move to the next level!");
        }

        private void nextCategorie_Click(object sender, EventArgs e)
        {
            if (currentCategorie == 3)
            {
                MessageBox.Show("No more Categories!");
                return;
            }

            if (currentCategorieCompleted == false)
            {
                MessageBox.Show("You need to finish all levels before moving to the next categorie!");
                return;
            }

            currentCategorieCompleted = false;
            currentCategorie++;

            levelOneQuestions.Clear();
            levelTwoQuestions.Clear();
            levelThreeQuestions.Clear();

            o1.Text = "";
            o2.Text = "";
            o3.Text = "";
            o4.Text = "";
            o1.Enabled = true;
            o2.Enabled = true;
            o3.Enabled = true;
            o4.Enabled = true;


            if (count1 == 3)
            {
                UpdateScore(100);
            }
            count1 = 0;
            count = 0;
            y = 0;

            currentLevel = 1;
            currentLevelCompleted = false;
            currentQuestionIndex = 0;

            timerQuiz.Start();
            timerQuiz1.Start();

            levelOne.ForeColor = Color.Red;
            levelOne.Checked = true;
            levelOne.Enabled = true;
            levelTwo.Checked = false;
            levelTwo.Enabled = false;
            levelThree.Checked = false;
            levelThree.Enabled = false;

            for (int i = 1; i <= 5; i++)
            {
                Label label = questionsTable.GetControlFromPosition(0, i) as Label;
                if (label != null)
                    label.ForeColor = Color.Black;
            }

            timeProgressBar.Maximum = 30;
            timeProgressBar.Value = 30;

            selectedLevelQuestions = levelOneQuestions;

            if (currentCategorie == 2)
            {
                InitializeMathQuiz();
                tabControlCategorie.TabPages[0].Text = "Math";
            }

            else
            {
                InitializeGeoQuiz();
                tabControlCategorie.TabPages[0].Text = "Geography";
            }


            QuizQuestion currentQuestion = levelOneQuestions[0];
            questionNumber.Text = $"Question {currentQuestionIndex + 1}";
            questionText.Text = currentQuestion.Question;
            o1.Text = currentQuestion.Options[0];
            o1.Checked = false;
            o2.Text = currentQuestion.Options[1];
            o2.Checked = false;
            o3.Text = currentQuestion.Options[2];
            o3.Checked = false;
            o4.Text = currentQuestion.Options[3];
            o4.Checked = false;
        }

        private void InitializeMathQuiz()
        {
            levelOneQuestions.Add(new QuizQuestion("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1));
            levelOneQuestions.Add(new QuizQuestion("What is 5 * 3?", new string[] { "15", "25", "20", "10" }, 0));
            levelOneQuestions.Add(new QuizQuestion("What is the square root of 16?", new string[] { "2", "4", "6", "8" }, 1));
            levelOneQuestions.Add(new QuizQuestion("What is 10 / 2?", new string[] { "2", "3", "5", "10" }, 2));
            levelOneQuestions.Add(new QuizQuestion("What is 7 - 3?", new string[] { "5", "4", "3", "6" }, 1));

            levelTwoQuestions.Add(new QuizQuestion("What is 12 * 12?", new string[] { "120", "144", "156", "132" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("What is 25 / 5?", new string[] { "4", "5", "6", "7" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("What is 50% of 100?", new string[] { "20", "50", "60", "40" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("What is 9 + 8?", new string[] { "15", "16", "17", "18" }, 2));
            levelTwoQuestions.Add(new QuizQuestion("What is 81 / 9?", new string[] { "8", "9", "7", "6" }, 1));

            levelThreeQuestions.Add(new QuizQuestion("Solve for x: 2x + 3 = 7", new string[] { "1", "2", "3", "4" }, 1));
            levelThreeQuestions.Add(new QuizQuestion("What is the derivative of x^2?", new string[] { "x", "2x", "x^2", "2" }, 1));
            levelThreeQuestions.Add(new QuizQuestion("What is the integral of 2x dx?", new string[] { "x^2 + C", "2x + C", "2x^2", "x + C" }, 0));
            levelThreeQuestions.Add(new QuizQuestion("What is the area of a circle with radius 3?", new string[] { "6π", "9π", "12π", "18π" }, 1));
            levelThreeQuestions.Add(new QuizQuestion("Solve for y: y/3 = 5", new string[] { "3", "5", "15", "20" }, 2));
        }

        private void InitializeGeoQuiz()
        {
            levelOneQuestions.Add(new QuizQuestion("What is the largest continent?", new string[] { "Asia", "Africa", "Europe", "Antarctica" }, 0));
            levelOneQuestions.Add(new QuizQuestion("What is the capital of France?", new string[] { "Paris", "Rome", "Berlin", "Madrid" }, 0));
            levelOneQuestions.Add(new QuizQuestion("Which country is known for the Great Wall?", new string[] { "India", "China", "Japan", "Thailand" }, 1));
            levelOneQuestions.Add(new QuizQuestion("Which ocean is located between Africa and Australia?", new string[] { "Atlantic Ocean", "Indian Ocean", "Pacific Ocean", "Arctic Ocean" }, 1));
            levelOneQuestions.Add(new QuizQuestion("Which country is the Eiffel Tower located in?", new string[] { "Germany", "France", "Italy", "Spain" }, 1));

            levelTwoQuestions.Add(new QuizQuestion("What is the largest desert in the world?", new string[] { "Sahara Desert", "Arabian Desert", "Gobi Desert", "Kalahari Desert" }, 0));
            levelTwoQuestions.Add(new QuizQuestion("Which mountain is the highest in the world?", new string[] { "Mount Kilimanjaro", "Mount Everest", "Mount Fuji", "K2" }, 1));
            levelTwoQuestions.Add(new QuizQuestion("Which country has the most natural lakes?", new string[] { "Canada", "United States", "Brazil", "Russia" }, 0));
            levelTwoQuestions.Add(new QuizQuestion("The city of Machu Picchu is located in which country?", new string[] { "Peru", "Mexico", "Argentina", "Chile" }, 0));
            levelTwoQuestions.Add(new QuizQuestion("Which river is the longest in the world?", new string[] { "Amazon River", "Nile River", "Yangtze River", "Mississippi River" }, 1));

            levelThreeQuestions.Add(new QuizQuestion("Which is the largest country in the world by area?", new string[] { "Russia", "United States", "China", "Canada" }, 0));
            levelThreeQuestions.Add(new QuizQuestion("Which country has the most islands?", new string[] { "Sweden", "Indonesia", "United States", "Norway" }, 3));
            levelThreeQuestions.Add(new QuizQuestion("What is the smallest country in the world?", new string[] { "San Marino", "Vatican City", "Liechtenstein", "Monaco" }, 1));
            levelThreeQuestions.Add(new QuizQuestion("Which is the longest river in Africa?", new string[] { "Orange River", "Congo River", "Zambezi River", "Nile River" }, 3));
            levelThreeQuestions.Add(new QuizQuestion("What is the capital of Australia?", new string[] { "Sydney", "Melbourne", "Canberra", "Brisbane" }, 2));
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool allowTabChange = false;
        private void tabControlCategorie_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageHistory && !allowTabChange)
                e.Cancel = true;
        }
    }
}
