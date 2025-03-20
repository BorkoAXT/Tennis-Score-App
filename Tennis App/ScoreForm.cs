namespace Tennis_App
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            labelClickOnName = new Label();
            listViewLatestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            labelLatestGames = new Label();
            buttonAddNewGame = new Button();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 20F);
            labelTennisScore.Location = new Point(304, 9);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.Size = new Size(206, 46);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score";
            labelTennisScore.Click += label1_Click;
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 13F);
            labelRanking.Location = new Point(127, 54);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(90, 30);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            labelRanking.Click += label2_Click;
            // 
            // listViewRanking
            // 
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.Location = new Point(127, 99);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(607, 121);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.SelectedIndexChanged += RankingTable_SelectedIndexChanged;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "Player Name";
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "scoreColumn";
            scoreColumn.TextAlign = HorizontalAlignment.Right;
            // 
            // labelClickOnName
            // 
            labelClickOnName.AutoSize = true;
            labelClickOnName.Location = new Point(127, 223);
            labelClickOnName.Name = "labelClickOnName";
            labelClickOnName.Size = new Size(476, 20);
            labelClickOnName.TabIndex = 3;
            labelClickOnName.Text = "*click on a player's name to see more information about their matches.";
            // 
            // listViewLatestGames
            // 
            listViewLatestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLatestGames.Location = new Point(127, 313);
            listViewLatestGames.Name = "listViewLatestGames";
            listViewLatestGames.Size = new Size(615, 121);
            listViewLatestGames.TabIndex = 4;
            listViewLatestGames.UseCompatibleStateImageBehavior = false;
            listViewLatestGames.View = View.Details;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "scoreColumn";
            // 
            // labelLatestGames
            // 
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 13F);
            labelLatestGames.Location = new Point(127, 267);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(141, 30);
            labelLatestGames.TabIndex = 5;
            labelLatestGames.Text = "Latest Games";
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.Location = new Point(609, 267);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(133, 29);
            buttonAddNewGame.TabIndex = 6;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = true;
            buttonAddNewGame.Click += AddNewGameButtonClick;
            // 
            // ScoreForm
            // 
            ClientSize = new Size(820, 489);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelLatestGames);
            Controls.Add(listViewLatestGames);
            Controls.Add(labelClickOnName);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "ScoreForm";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RankingTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static Dictionary<string, int> playersWithPoints = new();


        private static Dictionary<(string, int), List<(string, int)>> games = new()
        {
            { ("G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2)} }
        };

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }
        }
        private void FillLatestGamesListView()
        {
            this.listViewLatestGames.Items.Clear();


            foreach (var game in games.ToArray())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }
        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new();
            rollInLatestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLatestGamesListView.SubItems.Add(winner);
            rollInLatestGamesListView.SubItems.Add($"{firstPlayer.Item1} - {secondPlayer.Item1})");

            this.listViewLatestGames.Items.Add(rollInLatestGamesListView);
        }
        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }
            else
            {
                return "Draw";
            }
        }

        

        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    //AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }
        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            //FillGamesData(firstPlayer, secondPlayer);

            //FillPlayerWithPoints(firstPlayer);
            //FillPlayerWithPoints(secondPlayer);

            //FillRanking
        }
    }
}
