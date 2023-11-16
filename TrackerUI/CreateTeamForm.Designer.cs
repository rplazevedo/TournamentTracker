namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamtNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            selectMemberDropDown = new ComboBox();
            selectMemberLabel = new Label();
            addMemberButton = new Button();
            addNewMemberBox1 = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            phoneValue = new TextBox();
            phoneLabel = new Label();
            createMemberButton = new Button();
            createTeamButton = new Button();
            teamMembersListBox = new ListBox();
            deleteMembersButton = new Button();
            addNewMemberBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamtNameValue
            // 
            teamtNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamtNameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamtNameValue.Location = new Point(50, 137);
            teamtNameValue.Name = "teamtNameValue";
            teamtNameValue.Size = new Size(317, 34);
            teamtNameValue.TabIndex = 35;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(50, 97);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 34;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(25, 18);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(213, 50);
            headerLabel.TabIndex = 33;
            headerLabel.Text = "Create Team";
            // 
            // selectMemberDropDown
            // 
            selectMemberDropDown.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberDropDown.FormattingEnabled = true;
            selectMemberDropDown.Location = new Point(46, 238);
            selectMemberDropDown.Name = "selectMemberDropDown";
            selectMemberDropDown.Size = new Size(321, 36);
            selectMemberDropDown.TabIndex = 38;
            // 
            // selectMemberLabel
            // 
            selectMemberLabel.AutoSize = true;
            selectMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectMemberLabel.Location = new Point(50, 198);
            selectMemberLabel.Name = "selectMemberLabel";
            selectMemberLabel.Size = new Size(194, 37);
            selectMemberLabel.TabIndex = 37;
            selectMemberLabel.Text = "Select Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(117, 280);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(173, 46);
            addMemberButton.TabIndex = 39;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberBox1
            // 
            addNewMemberBox1.Controls.Add(createMemberButton);
            addNewMemberBox1.Controls.Add(phoneValue);
            addNewMemberBox1.Controls.Add(phoneLabel);
            addNewMemberBox1.Controls.Add(emailValue);
            addNewMemberBox1.Controls.Add(emailLabel);
            addNewMemberBox1.Controls.Add(lastNameValue);
            addNewMemberBox1.Controls.Add(lastNameLabel);
            addNewMemberBox1.Controls.Add(firstNameValue);
            addNewMemberBox1.Controls.Add(firstNameLabel);
            addNewMemberBox1.Location = new Point(50, 358);
            addNewMemberBox1.Name = "addNewMemberBox1";
            addNewMemberBox1.Size = new Size(392, 330);
            addNewMemberBox1.TabIndex = 40;
            addNewMemberBox1.TabStop = false;
            addNewMemberBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValue.Location = new Point(156, 35);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(217, 34);
            firstNameValue.TabIndex = 32;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(6, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 31;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValue.Location = new Point(156, 94);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(217, 34);
            lastNameValue.TabIndex = 34;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 89);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 33;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailValue.Location = new Point(156, 153);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(217, 34);
            emailValue.TabIndex = 36;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(6, 148);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 35;
            emailLabel.Text = "Email";
            // 
            // phoneValue
            // 
            phoneValue.BorderStyle = BorderStyle.FixedSingle;
            phoneValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            phoneValue.Location = new Point(156, 212);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(217, 34);
            phoneValue.TabIndex = 38;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.ForeColor = SystemColors.MenuHighlight;
            phoneLabel.Location = new Point(6, 207);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(92, 37);
            phoneLabel.TabIndex = 37;
            phoneLabel.Text = "Phone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(107, 268);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(173, 46);
            createMemberButton.TabIndex = 40;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += button1_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(327, 711);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(318, 68);
            createTeamButton.TabIndex = 47;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 28;
            teamMembersListBox.Location = new Point(491, 154);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(333, 534);
            teamMembersListBox.TabIndex = 48;
            // 
            // deleteMembersButton
            // 
            deleteMembersButton.FlatAppearance.BorderColor = Color.Silver;
            deleteMembersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteMembersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteMembersButton.FlatStyle = FlatStyle.Flat;
            deleteMembersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteMembersButton.ForeColor = SystemColors.MenuHighlight;
            deleteMembersButton.Location = new Point(830, 393);
            deleteMembersButton.Name = "deleteMembersButton";
            deleteMembersButton.Size = new Size(103, 74);
            deleteMembersButton.TabIndex = 49;
            deleteMembersButton.Text = "Delete Selected";
            deleteMembersButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(965, 806);
            Controls.Add(deleteMembersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createTeamButton);
            Controls.Add(addNewMemberBox1);
            Controls.Add(addMemberButton);
            Controls.Add(selectMemberDropDown);
            Controls.Add(selectMemberLabel);
            Controls.Add(teamtNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberBox1.ResumeLayout(false);
            addNewMemberBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamtNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private ComboBox selectMemberDropDown;
        private Label selectMemberLabel;
        private Button addMemberButton;
        private GroupBox addNewMemberBox1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private Button createTeamButton;
        private ListBox teamMembersListBox;
        private Button deleteMembersButton;
    }
}