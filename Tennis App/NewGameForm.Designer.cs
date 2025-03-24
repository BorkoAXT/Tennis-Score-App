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
            components = new System.ComponentModel.Container();
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
            firstPlayerNameErrorProvider = new ErrorProvider(components);
            secondPlayerNameErrorProvider = new ErrorProvider(components);
            labelErrorMessageFirstNameTextBox = new Label();
            labelErrorMessageSecondNameTextBox = new Label();
            labelSameNamesErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelNewGame
            // 
            labelNewGame.AutoSize = true;
            labelNewGame.Font = new Font("Segoe UI", 20F);
            labelNewGame.Location = new Point(266, 15);
            labelNewGame.Name = "labelNewGame";
            labelNewGame.Size = new Size(148, 37);
            labelNewGame.TabIndex = 0;
            labelNewGame.Text = "New Game";
            labelNewGame.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFirstPlayerName
            // 
            labelFirstPlayerName.AutoSize = true;
            labelFirstPlayerName.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerName.Location = new Point(50, 81);
            labelFirstPlayerName.Name = "labelFirstPlayerName";
            labelFirstPlayerName.Size = new Size(97, 25);
            labelFirstPlayerName.TabIndex = 1;
            labelFirstPlayerName.Text = "First Player";
            // 
            // labelSecondPlayerName
            // 
            labelSecondPlayerName.AutoSize = true;
            labelSecondPlayerName.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerName.Location = new Point(409, 81);
            labelSecondPlayerName.Name = "labelSecondPlayerName";
            labelSecondPlayerName.Size = new Size(123, 25);
            labelSecondPlayerName.TabIndex = 2;
            labelSecondPlayerName.Text = "Second Player";
            // 
            // labelFirstPlayerPoints
            // 
            labelFirstPlayerPoints.AutoSize = true;
            labelFirstPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerPoints.Location = new Point(113, 159);
            labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            labelFirstPlayerPoints.Size = new Size(60, 25);
            labelFirstPlayerPoints.TabIndex = 3;
            labelFirstPlayerPoints.Text = "Points";
            // 
            // labelSecondPlayerPoints
            // 
            labelSecondPlayerPoints.AutoSize = true;
            labelSecondPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerPoints.Location = new Point(481, 159);
            labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            labelSecondPlayerPoints.Size = new Size(60, 25);
            labelSecondPlayerPoints.TabIndex = 4;
            labelSecondPlayerPoints.Text = "Points";
            // 
            // buttonSaveGame
            // 
            buttonSaveGame.BackColor = SystemColors.ActiveCaption;
            buttonSaveGame.Font = new Font("Segoe UI", 13F);
            buttonSaveGame.ForeColor = SystemColors.ButtonFace;
            buttonSaveGame.Location = new Point(253, 274);
            buttonSaveGame.Margin = new Padding(3, 2, 3, 2);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(161, 42);
            buttonSaveGame.TabIndex = 5;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = false;
            buttonSaveGame.Click += ButtonSaveGameClick;
            buttonSaveGame.MouseClick += ButtonSaveGameClick;
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.BackColor = Color.Coral;
            textBoxFirstPlayerName.Location = new Point(50, 116);
            textBoxFirstPlayerName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(205, 23);
            textBoxFirstPlayerName.TabIndex = 6;
            textBoxFirstPlayerName.Validating += ValidatePlayerName;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.Coral;
            textBoxSecondPlayerName.Location = new Point(409, 116);
            textBoxSecondPlayerName.Margin = new Padding(3, 2, 3, 2);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(210, 23);
            textBoxSecondPlayerName.TabIndex = 7;
            textBoxSecondPlayerName.Validating += ValidatePlayerName;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.BackColor = Color.Coral;
            numericUpDownSecondPlayerPoints.Location = new Point(490, 209);
            numericUpDownSecondPlayerPoints.Margin = new Padding(3, 2, 3, 2);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(42, 23);
            numericUpDownSecondPlayerPoints.TabIndex = 1;
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.BackColor = Color.Coral;
            numericUpDownFirstPlayerPoints.Location = new Point(123, 209);
            numericUpDownFirstPlayerPoints.Margin = new Padding(3, 2, 3, 2);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(40, 23);
            numericUpDownFirstPlayerPoints.TabIndex = 1;
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Segoe UI", 20F);
            labelVs.Location = new Point(318, 192);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(48, 37);
            labelVs.TabIndex = 8;
            labelVs.Text = "VS";
            // 
            // firstPlayerNameErrorProvider
            // 
            firstPlayerNameErrorProvider.ContainerControl = this;
            // 
            // secondPlayerNameErrorProvider
            // 
            secondPlayerNameErrorProvider.ContainerControl = this;
            // 
            // labelErrorMessageFirstNameTextBox
            // 
            labelErrorMessageFirstNameTextBox.AutoSize = true;
            labelErrorMessageFirstNameTextBox.ForeColor = Color.Red;
            labelErrorMessageFirstNameTextBox.Location = new Point(53, 142);
            labelErrorMessageFirstNameTextBox.Name = "labelErrorMessageFirstNameTextBox";
            labelErrorMessageFirstNameTextBox.Size = new Size(0, 15);
            labelErrorMessageFirstNameTextBox.TabIndex = 9;
            // 
            // labelErrorMessageSecondNameTextBox
            // 
            labelErrorMessageSecondNameTextBox.AutoSize = true;
            labelErrorMessageSecondNameTextBox.Location = new Point(412, 142);
            labelErrorMessageSecondNameTextBox.Name = "labelErrorMessageSecondNameTextBox";
            labelErrorMessageSecondNameTextBox.Size = new Size(0, 15);
            labelErrorMessageSecondNameTextBox.TabIndex = 10;
            // 
            // labelSameNamesErrorMessage
            // 
            labelSameNamesErrorMessage.AutoSize = true;
            labelSameNamesErrorMessage.ForeColor = Color.Red;
            labelSameNamesErrorMessage.Location = new Point(232, 159);
            labelSameNamesErrorMessage.Name = "labelSameNamesErrorMessage";
            labelSameNamesErrorMessage.Size = new Size(0, 15);
            labelSameNamesErrorMessage.TabIndex = 11;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(700, 338);
            Controls.Add(labelSameNamesErrorMessage);
            Controls.Add(labelErrorMessageSecondNameTextBox);
            Controls.Add(labelErrorMessageFirstNameTextBox);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameErrorProvider).EndInit();
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
        private ErrorProvider firstPlayerNameErrorProvider;
        private ErrorProvider secondPlayerNameErrorProvider;
        private Label labelErrorMessageSecondNameTextBox;
        private Label labelErrorMessageFirstNameTextBox;
        private Label labelSameNamesErrorMessage;
    }
}