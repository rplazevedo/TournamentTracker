namespace TrackerUI
{
    partial class TournamentViewerForm
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
            scoreButton = new Button();
            versusLabel = new Label();
            teamTwoScoreText = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            teamOneScoreLabel = new Label();
            teamOneName = new Label();
            matchupListBox = new ListBox();
            unplayedOnlyCheckbox = new CheckBox();
            roundDropDown = new ComboBox();
            roundLabel = new Label();
            tournamentName = new Label();
            headerLabel = new Label();
            teamOneScoreText = new TextBox();
            SuspendLayout();
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(579, 310);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(108, 46);
            scoreButton.TabIndex = 29;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(473, 312);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 37);
            versusLabel.TabIndex = 28;
            versusLabel.Text = "-VS-";
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreText.Location = new Point(508, 419);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(100, 34);
            teamTwoScoreText.TabIndex = 27;
            teamTwoScoreText.TextChanged += teamTwoScoreText_TextChanged;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(420, 414);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(82, 37);
            teamTwoScoreLabel.TabIndex = 26;
            teamTwoScoreLabel.Text = "Score";
            teamTwoScoreLabel.Click += teamTwoScoreLabel_Click;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(420, 377);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 25;
            teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(420, 240);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 23;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(420, 203);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 22;
            teamOneName.Text = "<team one>";
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 28;
            matchupListBox.Location = new Point(22, 203);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(340, 254);
            matchupListBox.TabIndex = 21;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(122, 137);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(202, 41);
            unplayedOnlyCheckbox.TabIndex = 20;
            unplayedOnlyCheckbox.Text = "UnplayedOnly";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(122, 97);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(240, 36);
            roundDropDown.TabIndex = 19;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(22, 93);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 18;
            roundLabel.Text = "Round";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(242, 21);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 17;
            tournamentName.Text = "<none>";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(22, 21);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Tournament:";
            // 
            // teamOneScoreText
            // 
            teamOneScoreText.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreText.Location = new Point(508, 245);
            teamOneScoreText.Name = "teamOneScoreText";
            teamOneScoreText.Size = new Size(100, 34);
            teamOneScoreText.TabIndex = 30;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 500);
            Controls.Add(teamOneScoreText);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Name = "TournamentViewerForm";
            Text = "TournamentViewerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scoreButton;
        private Label versusLabel;
        private TextBox teamTwoScoreText;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label teamOneScoreLabel;
        private Label teamOneName;
        private ListBox matchupListBox;
        private CheckBox unplayedOnlyCheckbox;
        private ComboBox roundDropDown;
        private Label roundLabel;
        private Label tournamentName;
        private Label headerLabel;
        private TextBox teamOneScoreText;
    }
}