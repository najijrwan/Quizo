namespace Quizo
{
    partial class main1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main1));
            howQuizoWorks = new Button();
            startQuiz = new Button();
            quizInfo = new TableLayoutPanel();
            scoreValue = new Label();
            timeSpent = new Label();
            time = new Label();
            score = new Label();
            timerQuiz = new System.Windows.Forms.Timer(components);
            timerQuiz1 = new System.Windows.Forms.Timer(components);
            toolTipNextLevel = new ToolTip(components);
            tabPageHistory = new TabPage();
            exit = new Button();
            restart = new Button();
            timeProgressBar = new ProgressBar();
            nextCategorie = new Button();
            nextLevel = new Button();
            submit = new Button();
            questionNumber = new GroupBox();
            questionText = new Label();
            o4 = new RadioButton();
            o3 = new RadioButton();
            o2 = new RadioButton();
            o1 = new RadioButton();
            questionsTable = new TableLayoutPanel();
            q5 = new Label();
            q4 = new Label();
            q3 = new Label();
            q2 = new Label();
            q1 = new Label();
            questions = new Label();
            levelOne = new RadioButton();
            levelThree = new RadioButton();
            levelTwo = new RadioButton();
            tabControlCategorie = new TabControl();
            quizInfo.SuspendLayout();
            tabPageHistory.SuspendLayout();
            questionNumber.SuspendLayout();
            questionsTable.SuspendLayout();
            tabControlCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // howQuizoWorks
            // 
            howQuizoWorks.BackColor = Color.Honeydew;
            howQuizoWorks.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            howQuizoWorks.ForeColor = Color.ForestGreen;
            howQuizoWorks.Location = new Point(12, 13);
            howQuizoWorks.Name = "howQuizoWorks";
            howQuizoWorks.Size = new Size(150, 31);
            howQuizoWorks.TabIndex = 5;
            howQuizoWorks.Text = "How Quizo Works?";
            howQuizoWorks.UseVisualStyleBackColor = false;
            howQuizoWorks.Click += howQuizoWorks_Click;
            // 
            // startQuiz
            // 
            startQuiz.BackColor = Color.Honeydew;
            startQuiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startQuiz.ForeColor = Color.ForestGreen;
            startQuiz.Location = new Point(447, 13);
            startQuiz.Name = "startQuiz";
            startQuiz.Size = new Size(150, 31);
            startQuiz.TabIndex = 6;
            startQuiz.Text = "Start Quiz...";
            startQuiz.UseVisualStyleBackColor = false;
            startQuiz.Click += startQuiz_Click;
            // 
            // quizInfo
            // 
            quizInfo.BackColor = Color.Honeydew;
            quizInfo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            quizInfo.ColumnCount = 2;
            quizInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            quizInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            quizInfo.Controls.Add(scoreValue, 1, 1);
            quizInfo.Controls.Add(timeSpent, 0, 1);
            quizInfo.Controls.Add(time, 0, 0);
            quizInfo.Controls.Add(score, 1, 0);
            quizInfo.Location = new Point(812, 12);
            quizInfo.Name = "quizInfo";
            quizInfo.RowCount = 2;
            quizInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            quizInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            quizInfo.Size = new Size(210, 48);
            quizInfo.TabIndex = 7;
            // 
            // scoreValue
            // 
            scoreValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            scoreValue.AutoSize = true;
            scoreValue.BackColor = Color.Transparent;
            scoreValue.ForeColor = Color.Red;
            scoreValue.Location = new Point(148, 24);
            scoreValue.Name = "scoreValue";
            scoreValue.Size = new Size(18, 23);
            scoreValue.TabIndex = 9;
            scoreValue.Text = "0";
            // 
            // timeSpent
            // 
            timeSpent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            timeSpent.AutoSize = true;
            timeSpent.BackColor = Color.Transparent;
            timeSpent.ForeColor = Color.Red;
            timeSpent.Location = new Point(28, 24);
            timeSpent.Name = "timeSpent";
            timeSpent.Size = new Size(49, 23);
            timeSpent.TabIndex = 8;
            timeSpent.Text = "00:00";
            // 
            // time
            // 
            time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.ForeColor = Color.Red;
            time.Location = new Point(30, 1);
            time.Name = "time";
            time.Size = new Size(45, 22);
            time.TabIndex = 0;
            time.Text = "Time";
            // 
            // score
            // 
            score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.ForeColor = Color.Red;
            score.Location = new Point(112, 1);
            score.Name = "score";
            score.Size = new Size(90, 22);
            score.TabIndex = 1;
            score.Text = "Score/1040";
            score.Click += label2_Click;
            // 
            // timerQuiz
            // 
            timerQuiz.Interval = 1000;
            timerQuiz.Tick += timerQuiz_Tick;
            // 
            // timerQuiz1
            // 
            timerQuiz1.Interval = 1000;
            timerQuiz1.Tick += timerQuiz1_Tick;
            // 
            // toolTipNextLevel
            // 
            toolTipNextLevel.Popup += You;
            // 
            // tabPageHistory
            // 
            tabPageHistory.BackColor = Color.Honeydew;
            tabPageHistory.Controls.Add(exit);
            tabPageHistory.Controls.Add(restart);
            tabPageHistory.Controls.Add(timeProgressBar);
            tabPageHistory.Controls.Add(nextCategorie);
            tabPageHistory.Controls.Add(nextLevel);
            tabPageHistory.Controls.Add(submit);
            tabPageHistory.Controls.Add(questionNumber);
            tabPageHistory.Controls.Add(questionsTable);
            tabPageHistory.Controls.Add(levelOne);
            tabPageHistory.Controls.Add(levelThree);
            tabPageHistory.Controls.Add(levelTwo);
            tabPageHistory.ForeColor = Color.Honeydew;
            tabPageHistory.Location = new Point(4, 29);
            tabPageHistory.Name = "tabPageHistory";
            tabPageHistory.Padding = new Padding(3);
            tabPageHistory.Size = new Size(1002, 396);
            tabPageHistory.TabIndex = 0;
            tabPageHistory.Text = "History";
            // 
            // exit
            // 
            exit.BackColor = Color.Honeydew;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.ForestGreen;
            exit.Location = new Point(508, 332);
            exit.Name = "exit";
            exit.Size = new Size(150, 31);
            exit.TabIndex = 17;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // restart
            // 
            restart.BackColor = Color.Honeydew;
            restart.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            restart.ForeColor = Color.ForestGreen;
            restart.Location = new Point(336, 332);
            restart.Name = "restart";
            restart.Size = new Size(150, 31);
            restart.TabIndex = 16;
            restart.Text = "Restart";
            restart.UseVisualStyleBackColor = false;
            restart.Click += restart_Click;
            // 
            // timeProgressBar
            // 
            timeProgressBar.ForeColor = Color.ForestGreen;
            timeProgressBar.Location = new Point(6, 81);
            timeProgressBar.Maximum = 30;
            timeProgressBar.Name = "timeProgressBar";
            timeProgressBar.Size = new Size(178, 29);
            timeProgressBar.TabIndex = 15;
            timeProgressBar.Value = 30;
            // 
            // nextCategorie
            // 
            nextCategorie.BackColor = Color.Honeydew;
            nextCategorie.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nextCategorie.ForeColor = Color.ForestGreen;
            nextCategorie.Location = new Point(815, 240);
            nextCategorie.Name = "nextCategorie";
            nextCategorie.Size = new Size(150, 31);
            nextCategorie.TabIndex = 14;
            nextCategorie.Text = "Next Topic";
            nextCategorie.UseVisualStyleBackColor = false;
            nextCategorie.Click += nextCategorie_Click;
            nextCategorie.MouseHover += nextCategorie_MouseHover;
            // 
            // nextLevel
            // 
            nextLevel.BackColor = Color.Honeydew;
            nextLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nextLevel.ForeColor = Color.ForestGreen;
            nextLevel.Location = new Point(815, 178);
            nextLevel.Name = "nextLevel";
            nextLevel.Size = new Size(150, 31);
            nextLevel.TabIndex = 13;
            nextLevel.Text = "Next Level";
            nextLevel.UseVisualStyleBackColor = false;
            nextLevel.Click += nextLevel_Click;
            nextLevel.MouseHover += nextLevel_MouseHover;
            // 
            // submit
            // 
            submit.BackColor = Color.Honeydew;
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            submit.ForeColor = Color.ForestGreen;
            submit.Location = new Point(815, 112);
            submit.Name = "submit";
            submit.Size = new Size(150, 31);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += nextQuestion_Click;
            // 
            // questionNumber
            // 
            questionNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            questionNumber.Controls.Add(questionText);
            questionNumber.Controls.Add(o4);
            questionNumber.Controls.Add(o3);
            questionNumber.Controls.Add(o2);
            questionNumber.Controls.Add(o1);
            questionNumber.ForeColor = Color.ForestGreen;
            questionNumber.Location = new Point(227, 81);
            questionNumber.Name = "questionNumber";
            questionNumber.Size = new Size(550, 223);
            questionNumber.TabIndex = 11;
            questionNumber.TabStop = false;
            questionNumber.Text = "Question 1";
            questionNumber.Enter += questionNumber_Enter;
            // 
            // questionText
            // 
            questionText.AutoSize = true;
            questionText.BackColor = Color.Honeydew;
            questionText.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            questionText.ForeColor = Color.LightSeaGreen;
            questionText.Location = new Point(6, 42);
            questionText.Name = "questionText";
            questionText.Size = new Size(359, 20);
            questionText.TabIndex = 15;
            questionText.Text = "Who was the first president of the United States?";
            questionText.Click += question1Text_Click;
            // 
            // o4
            // 
            o4.AutoSize = true;
            o4.ForeColor = Color.Black;
            o4.Location = new Point(35, 186);
            o4.Name = "o4";
            o4.Size = new Size(118, 24);
            o4.TabIndex = 14;
            o4.Text = "John Adams";
            o4.UseVisualStyleBackColor = true;
            // 
            // o3
            // 
            o3.AutoSize = true;
            o3.ForeColor = Color.Black;
            o3.Location = new Point(35, 156);
            o3.Name = "o3";
            o3.Size = new Size(153, 24);
            o3.TabIndex = 13;
            o3.Text = "Abraham Lincoln";
            o3.UseVisualStyleBackColor = true;
            o3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // o2
            // 
            o2.AutoSize = true;
            o2.ForeColor = Color.Black;
            o2.Location = new Point(35, 126);
            o2.Name = "o2";
            o2.Size = new Size(157, 24);
            o2.TabIndex = 12;
            o2.Text = "Thomas Jefferson";
            o2.UseVisualStyleBackColor = true;
            o2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // o1
            // 
            o1.AutoSize = true;
            o1.ForeColor = Color.Black;
            o1.Location = new Point(35, 96);
            o1.Name = "o1";
            o1.Size = new Size(172, 24);
            o1.TabIndex = 11;
            o1.Text = "George Washington";
            o1.UseVisualStyleBackColor = true;
            o1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // questionsTable
            // 
            questionsTable.BackColor = Color.Honeydew;
            questionsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            questionsTable.ColumnCount = 1;
            questionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            questionsTable.Controls.Add(q5, 0, 5);
            questionsTable.Controls.Add(q4, 0, 4);
            questionsTable.Controls.Add(q3, 0, 3);
            questionsTable.Controls.Add(q2, 0, 2);
            questionsTable.Controls.Add(q1, 0, 1);
            questionsTable.Controls.Add(questions, 0, 0);
            questionsTable.ForeColor = Color.Black;
            questionsTable.Location = new Point(6, 116);
            questionsTable.Name = "questionsTable";
            questionsTable.RowCount = 6;
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            questionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            questionsTable.Size = new Size(178, 188);
            questionsTable.TabIndex = 8;
            questionsTable.Paint += tableLayoutPanel1_Paint_1;
            // 
            // q5
            // 
            q5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            q5.AutoSize = true;
            q5.BackColor = Color.Transparent;
            q5.ForeColor = Color.Black;
            q5.Location = new Point(74, 156);
            q5.Name = "q5";
            q5.Size = new Size(29, 31);
            q5.TabIndex = 5;
            q5.Text = "Q5";
            // 
            // q4
            // 
            q4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            q4.AutoSize = true;
            q4.BackColor = Color.Transparent;
            q4.ForeColor = Color.Black;
            q4.Location = new Point(74, 125);
            q4.Name = "q4";
            q4.Size = new Size(29, 30);
            q4.TabIndex = 4;
            q4.Text = "Q4";
            // 
            // q3
            // 
            q3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            q3.AutoSize = true;
            q3.BackColor = Color.Transparent;
            q3.ForeColor = Color.Black;
            q3.Location = new Point(74, 94);
            q3.Name = "q3";
            q3.Size = new Size(29, 30);
            q3.TabIndex = 3;
            q3.Text = "Q3";
            // 
            // q2
            // 
            q2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            q2.AutoSize = true;
            q2.BackColor = Color.Transparent;
            q2.ForeColor = Color.Black;
            q2.Location = new Point(74, 63);
            q2.Name = "q2";
            q2.Size = new Size(29, 30);
            q2.TabIndex = 2;
            q2.Text = "Q2";
            // 
            // q1
            // 
            q1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            q1.AutoSize = true;
            q1.BackColor = Color.Transparent;
            q1.ForeColor = Color.Black;
            q1.Location = new Point(74, 32);
            q1.Name = "q1";
            q1.Size = new Size(29, 30);
            q1.TabIndex = 1;
            q1.Text = "Q1";
            // 
            // questions
            // 
            questions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            questions.AutoSize = true;
            questions.BackColor = Color.Transparent;
            questions.ForeColor = Color.Black;
            questions.Location = new Point(49, 1);
            questions.Name = "questions";
            questions.Size = new Size(80, 30);
            questions.TabIndex = 0;
            questions.Text = "Questions";
            // 
            // levelOne
            // 
            levelOne.AutoSize = true;
            levelOne.Checked = true;
            levelOne.FlatStyle = FlatStyle.Flat;
            levelOne.ForeColor = Color.ForestGreen;
            levelOne.Location = new Point(336, 6);
            levelOne.Name = "levelOne";
            levelOne.Size = new Size(98, 24);
            levelOne.TabIndex = 3;
            levelOne.TabStop = true;
            levelOne.Text = "Level One";
            levelOne.UseVisualStyleBackColor = true;
            // 
            // levelThree
            // 
            levelThree.AutoSize = true;
            levelThree.FlatStyle = FlatStyle.Flat;
            levelThree.ForeColor = Color.ForestGreen;
            levelThree.Location = new Point(548, 6);
            levelThree.Name = "levelThree";
            levelThree.Size = new Size(110, 24);
            levelThree.TabIndex = 2;
            levelThree.Text = "Level Three";
            levelThree.UseVisualStyleBackColor = true;
            // 
            // levelTwo
            // 
            levelTwo.AutoSize = true;
            levelTwo.FlatStyle = FlatStyle.Flat;
            levelTwo.ForeColor = Color.ForestGreen;
            levelTwo.Location = new Point(442, 6);
            levelTwo.Name = "levelTwo";
            levelTwo.Size = new Size(100, 24);
            levelTwo.TabIndex = 1;
            levelTwo.Text = "Level Two";
            levelTwo.UseVisualStyleBackColor = true;
            // 
            // tabControlCategorie
            // 
            tabControlCategorie.Controls.Add(tabPageHistory);
            tabControlCategorie.Location = new Point(12, 62);
            tabControlCategorie.Name = "tabControlCategorie";
            tabControlCategorie.SelectedIndex = 0;
            tabControlCategorie.Size = new Size(1010, 429);
            tabControlCategorie.TabIndex = 8;
            tabControlCategorie.Selecting += tabControlCategorie_Selecting;
            // 
            // main1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1034, 503);
            Controls.Add(tabControlCategorie);
            Controls.Add(quizInfo);
            Controls.Add(startQuiz);
            Controls.Add(howQuizoWorks);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.ForestGreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "main1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizo";
            FormClosed += main1_FormClosed;
            Load += main1_Load;
            quizInfo.ResumeLayout(false);
            quizInfo.PerformLayout();
            tabPageHistory.ResumeLayout(false);
            tabPageHistory.PerformLayout();
            questionNumber.ResumeLayout(false);
            questionNumber.PerformLayout();
            questionsTable.ResumeLayout(false);
            questionsTable.PerformLayout();
            tabControlCategorie.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCategories;
        private TabControl tabControl1;
        private Button howQuizoWorks;
        private Button startQuiz;
        private TableLayoutPanel quizInfo;
        private Label time;
        private Label score;
        private Label timeSpent;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.Timer timerQuiz1;
        private ToolTip toolTipNextLevel;
        private Label scoreValue;
        private TabPage tabPageHistory;
        private ProgressBar timeProgressBar;
        private Button nextCategorie;
        private Button nextLevel;
        private Button submit;
        private GroupBox questionNumber;
        private Label questionText;
        private RadioButton o4;
        private RadioButton o3;
        private RadioButton o2;
        private RadioButton o1;
        private TableLayoutPanel questionsTable;
        private Label q5;
        private Label q4;
        private Label q3;
        private Label q2;
        private Label q1;
        private Label questions;
        private RadioButton levelOne;
        private RadioButton levelThree;
        private RadioButton levelTwo;
        private TabControl tabControlCategorie;
        private Button exit;
        private Button restart;
    }
}