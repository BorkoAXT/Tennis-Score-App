namespace Tennis_App
{
    partial class PlayerInfoForm
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            listViewLosses = new ListView();
            listViewDraw = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 20F);
            labelPlayerName.Location = new Point(310, 23);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(208, 46);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 13F);
            labelVictories.Location = new Point(72, 123);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(96, 30);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            labelVictories.Click += label1_Click;
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 13F);
            labelLosses.Location = new Point(365, 134);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(75, 30);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI", 13F);
            labelDraw.Location = new Point(646, 134);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(63, 30);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.Coral;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(46, 190);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(183, 163);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.Coral;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(310, 193);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(198, 163);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.Coral;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(581, 193);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(185, 163);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeaderCompetitor
            // 
            competitorVictories.Text = "Competitor";
            // 
            // columnHeaderScore
            // 
            scoreVictories.Text = "Score";
            // 
            // columnHeaderCompetitorLosses
            // 
            competitorLosses.Text = "Competitor";
            // 
            // columnHeaderScoreLosses
            // 
            scoreLosses.Text = "Score";
            // 
            // columnHeaderCompetitorDraw
            // 
            competitorDraw.Text = "Competitor";
            // 
            // columnHeaderScoreDraw
            // 
            scoreDraw.Text = "Score";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}