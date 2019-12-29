namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.teamOneNamelabel = new System.Windows.Forms.Label();
            this.teamOneScorelabel = new System.Windows.Forms.Label();
            this.teamTwoNamelabel = new System.Windows.Forms.Label();
            this.teamTwoScorelabel = new System.Windows.Forms.Label();
            this.versuslabel = new System.Windows.Forms.Label();
            this.teamOneScoreValuetextBox = new System.Windows.Forms.TextBox();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlycheckBox = new System.Windows.Forms.CheckBox();
            this.matchuplistBox = new System.Windows.Forms.ListBox();
            this.teamTwoScoreValuetextBox = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.Location = new System.Drawing.Point(54, 26);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(133, 25);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(193, 38);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(43, 13);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Location = new System.Drawing.Point(56, 87);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(39, 13);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // teamOneNamelabel
            // 
            this.teamOneNamelabel.AutoSize = true;
            this.teamOneNamelabel.Location = new System.Drawing.Point(253, 173);
            this.teamOneNamelabel.Name = "teamOneNamelabel";
            this.teamOneNamelabel.Size = new System.Drawing.Size(67, 13);
            this.teamOneNamelabel.TabIndex = 3;
            this.teamOneNamelabel.Text = "<Team one>";
            // 
            // teamOneScorelabel
            // 
            this.teamOneScorelabel.AutoSize = true;
            this.teamOneScorelabel.Location = new System.Drawing.Point(253, 207);
            this.teamOneScorelabel.Name = "teamOneScorelabel";
            this.teamOneScorelabel.Size = new System.Drawing.Size(35, 13);
            this.teamOneScorelabel.TabIndex = 4;
            this.teamOneScorelabel.Text = "Score";
            // 
            // teamTwoNamelabel
            // 
            this.teamTwoNamelabel.AutoSize = true;
            this.teamTwoNamelabel.Location = new System.Drawing.Point(253, 271);
            this.teamTwoNamelabel.Name = "teamTwoNamelabel";
            this.teamTwoNamelabel.Size = new System.Drawing.Size(70, 13);
            this.teamTwoNamelabel.TabIndex = 5;
            this.teamTwoNamelabel.Text = "<Team Two>";
            // 
            // teamTwoScorelabel
            // 
            this.teamTwoScorelabel.AutoSize = true;
            this.teamTwoScorelabel.Location = new System.Drawing.Point(253, 303);
            this.teamTwoScorelabel.Name = "teamTwoScorelabel";
            this.teamTwoScorelabel.Size = new System.Drawing.Size(35, 13);
            this.teamTwoScorelabel.TabIndex = 6;
            this.teamTwoScorelabel.Text = "Score";
            // 
            // versuslabel
            // 
            this.versuslabel.AutoSize = true;
            this.versuslabel.Location = new System.Drawing.Point(334, 247);
            this.versuslabel.Name = "versuslabel";
            this.versuslabel.Size = new System.Drawing.Size(27, 13);
            this.versuslabel.TabIndex = 7;
            this.versuslabel.Text = "-VS-";
            // 
            // teamOneScoreValuetextBox
            // 
            this.teamOneScoreValuetextBox.Location = new System.Drawing.Point(309, 200);
            this.teamOneScoreValuetextBox.Name = "teamOneScoreValuetextBox";
            this.teamOneScoreValuetextBox.Size = new System.Drawing.Size(100, 20);
            this.teamOneScoreValuetextBox.TabIndex = 8;
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(101, 79);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(121, 21);
            this.roundDropDown.TabIndex = 9;
            // 
            // UnplayedOnlycheckBox
            // 
            this.UnplayedOnlycheckBox.AutoSize = true;
            this.UnplayedOnlycheckBox.Location = new System.Drawing.Point(101, 123);
            this.UnplayedOnlycheckBox.Name = "UnplayedOnlycheckBox";
            this.UnplayedOnlycheckBox.Size = new System.Drawing.Size(95, 17);
            this.UnplayedOnlycheckBox.TabIndex = 10;
            this.UnplayedOnlycheckBox.Text = "Unplayed Only";
            this.UnplayedOnlycheckBox.UseVisualStyleBackColor = true;
            // 
            // matchuplistBox
            // 
            this.matchuplistBox.FormattingEnabled = true;
            this.matchuplistBox.Location = new System.Drawing.Point(59, 173);
            this.matchuplistBox.Name = "matchuplistBox";
            this.matchuplistBox.Size = new System.Drawing.Size(163, 147);
            this.matchuplistBox.TabIndex = 11;
            // 
            // teamTwoScoreValuetextBox
            // 
            this.teamTwoScoreValuetextBox.Location = new System.Drawing.Point(309, 296);
            this.teamTwoScoreValuetextBox.Name = "teamTwoScoreValuetextBox";
            this.teamTwoScoreValuetextBox.Size = new System.Drawing.Size(100, 20);
            this.teamTwoScoreValuetextBox.TabIndex = 12;
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(424, 247);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValuetextBox);
            this.Controls.Add(this.matchuplistBox);
            this.Controls.Add(this.UnplayedOnlycheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.teamOneScoreValuetextBox);
            this.Controls.Add(this.versuslabel);
            this.Controls.Add(this.teamTwoScorelabel);
            this.Controls.Add(this.teamTwoNamelabel);
            this.Controls.Add(this.teamOneScorelabel);
            this.Controls.Add(this.teamOneNamelabel);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTournament);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label teamOneNamelabel;
        private System.Windows.Forms.Label teamOneScorelabel;
        private System.Windows.Forms.Label teamTwoNamelabel;
        private System.Windows.Forms.Label teamTwoScorelabel;
        private System.Windows.Forms.Label versuslabel;
        private System.Windows.Forms.TextBox teamOneScoreValuetextBox;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlycheckBox;
        private System.Windows.Forms.ListBox matchuplistBox;
        private System.Windows.Forms.TextBox teamTwoScoreValuetextBox;
        private System.Windows.Forms.Button scoreButton;
    }
}

