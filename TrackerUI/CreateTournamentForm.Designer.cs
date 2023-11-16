namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            deletePlayersButton = new Button();
            deletePrizesButton = new Button();
            prizesListBox = new ListBox();
            prizesLabel = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(24, 21);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 17;
            headerLabel.Text = "Create Tournament";
            headerLabel.Click += headerLabel_Click;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameValue.Location = new Point(49, 140);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(317, 34);
            tournamentNameValue.TabIndex = 32;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(49, 100);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 31;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeValue.Location = new Point(185, 213);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 34);
            entryFeeValue.TabIndex = 34;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(49, 208);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 33;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(45, 335);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(321, 36);
            selectTeamDropDown.TabIndex = 36;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(49, 295);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 35;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Location = new Point(247, 302);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(119, 30);
            createNewTeamLinkLabel.TabIndex = 37;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(112, 377);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(173, 46);
            addTeamButton.TabIndex = 38;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(112, 445);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(173, 46);
            createPrizeButton.TabIndex = 39;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += button1_Click;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(464, 100);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(198, 37);
            tournamentPlayersLabel.TabIndex = 40;
            tournamentPlayersLabel.Text = "Teams / Players";
            tournamentPlayersLabel.Click += tournamentPlayersLabel_Click;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 28;
            tournamentPlayersListBox.Location = new Point(464, 140);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(340, 142);
            tournamentPlayersListBox.TabIndex = 41;
            tournamentPlayersListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // deletePlayersButton
            // 
            deletePlayersButton.FlatAppearance.BorderColor = Color.Silver;
            deletePlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deletePlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deletePlayersButton.FlatStyle = FlatStyle.Flat;
            deletePlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletePlayersButton.ForeColor = SystemColors.MenuHighlight;
            deletePlayersButton.Location = new Point(810, 171);
            deletePlayersButton.Name = "deletePlayersButton";
            deletePlayersButton.Size = new Size(103, 74);
            deletePlayersButton.TabIndex = 42;
            deletePlayersButton.Text = "Delete Selected";
            deletePlayersButton.UseVisualStyleBackColor = true;
            // 
            // deletePrizesButton
            // 
            deletePrizesButton.FlatAppearance.BorderColor = Color.Silver;
            deletePrizesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deletePrizesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deletePrizesButton.FlatStyle = FlatStyle.Flat;
            deletePrizesButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletePrizesButton.ForeColor = SystemColors.MenuHighlight;
            deletePrizesButton.Location = new Point(810, 380);
            deletePrizesButton.Name = "deletePrizesButton";
            deletePrizesButton.Size = new Size(103, 74);
            deletePrizesButton.TabIndex = 45;
            deletePrizesButton.Text = "Delete Selected";
            deletePrizesButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 28;
            prizesListBox.Location = new Point(464, 349);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(340, 142);
            prizesListBox.TabIndex = 44;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(464, 309);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(198, 37);
            prizesLabel.TabIndex = 43;
            prizesLabel.Text = "Teams / Players";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(319, 526);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(318, 68);
            createTournamentButton.TabIndex = 46;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 628);
            Controls.Add(createTournamentButton);
            Controls.Add(deletePrizesButton);
            Controls.Add(prizesListBox);
            Controls.Add(prizesLabel);
            Controls.Add(deletePlayersButton);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label tournamentPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private Button deletePlayersButton;
        private Button deletePrizesButton;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button createTournamentButton;
    }
}