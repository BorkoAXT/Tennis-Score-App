namespace Tennis_App
{
    partial class NewGameForm
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
            labelNewGame = new Label();
            labelFirstPlayerName = new Label();
            labelSecondPlayerName = new Label();
            labelFirstPlayerPoints = new Label();
            labelSecondPlayerPoints = new Label();
            buttonSaveGame = new Button();
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            labelVs = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            SuspendLayout();
            // 
            // labelNewGame
            // 
            labelNewGame.AutoSize = true;
            labelNewGame.Font = new Font("Segoe UI", 20F);
            labelNewGame.Location = new Point(304, 20);
            labelNewGame.Name = "labelNewGame";
            labelNewGame.Size = new Size(184, 46);
            labelNewGame.TabIndex = 0;
            labelNewGame.Text = "New Game";
            labelNewGame.Click += label1_Click;
            // 
            // labelFirstPlayer
            // 
            labelFirstPlayerName.AutoSize = true;
            labelFirstPlayerName.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerName.Location = new Point(57, 108);
            labelFirstPlayerName.Name = "labelFirstPlayerName";
            labelFirstPlayerName.Size = new Size(118, 30);
            labelFirstPlayerName.TabIndex = 1;
            labelFirstPlayerName.Text = "First Player";
            // 
            // labelSecondPlayer
            // 
            labelSecondPlayerName.AutoSize = true;
            labelSecondPlayerName.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerName.Location = new Point(467, 108);
            labelSecondPlayerName.Name = "labelSecondPlayerName";
            labelSecondPlayerName.Size = new Size(150, 30);
            labelSecondPlayerName.TabIndex = 2;
            labelSecondPlayerName.Text = "Second Player";
            // 
            // labelPointsFirstPlayer
            // 
            labelFirstPlayerPoints.AutoSize = true;
            labelFirstPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerPoints.Location = new Point(129, 212);
            labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            labelFirstPlayerPoints.Size = new Size(70, 30);
            labelFirstPlayerPoints.TabIndex = 3;
            labelFirstPlayerPoints.Text = "Points";
            // 
            // labelPointsSecondPlayer
            // 
            labelSecondPlayerPoints.AutoSize = true;
            labelSecondPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerPoints.Location = new Point(550, 212);
            labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            labelSecondPlayerPoints.Size = new Size(70, 30);
            labelSecondPlayerPoints.TabIndex = 4;
            labelSecondPlayerPoints.Text = "Points";
            // 
            // button1
            // 
            buttonSaveGame.BackColor = SystemColors.ActiveCaption;
            buttonSaveGame.Font = new Font("Segoe UI", 13F);
            buttonSaveGame.ForeColor = SystemColors.ButtonFace;
            buttonSaveGame.Location = new Point(289, 365);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(184, 39);
            buttonSaveGame.TabIndex = 5;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = false;
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.BackColor = Color.Coral;
            textBoxFirstPlayerName.Location = new Point(57, 155);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(234, 27);
            textBoxFirstPlayerName.TabIndex = 6;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.Coral;
            textBoxSecondPlayerName.Location = new Point(467, 155);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(239, 27);
            textBoxSecondPlayerName.TabIndex = 7;
            // 
            // numericSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.BackColor = Color.Coral;
            numericUpDownSecondPlayerPoints.Location = new Point(560, 279);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(48, 27);
            numericUpDownSecondPlayerPoints.TabIndex = 1;
            // 
            // numeicFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.BackColor = Color.Coral;
            numericUpDownFirstPlayerPoints.Location = new Point(141, 279);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(46, 27);
            numericUpDownFirstPlayerPoints.TabIndex = 1;
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Segoe UI", 20F);
            labelVs.Location = new Point(363, 256);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(59, 46);
            labelVs.TabIndex = 8;
            labelVs.Text = "VS";
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVs);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(buttonSaveGame);
            Controls.Add(labelSecondPlayerPoints);
            Controls.Add(labelFirstPlayerPoints);
            Controls.Add(labelSecondPlayerName);
            Controls.Add(labelFirstPlayerName);
            Controls.Add(labelNewGame);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewGame;
        private Label labelFirstPlayerName;
        private Label labelSecondPlayerName;
        private Label labelFirstPlayerPoints;
        private Label labelSecondPlayerPoints;
        private Button buttonSaveGame;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private Label labelVs;
    }
}