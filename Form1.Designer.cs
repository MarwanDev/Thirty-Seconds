using System.Windows.Forms;

namespace ThirtySeconds
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReset = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            llSkipCountDown = new System.Windows.Forms.LinkLabel();
            btnStartRound = new System.Windows.Forms.Button();
            this.btnGameRules = new System.Windows.Forms.Button();
            lblScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            lblQuestionType = new System.Windows.Forms.Label();
            cbQuestionType = new System.Windows.Forms.ComboBox();
            this.rdDark = new System.Windows.Forms.RadioButton();
            this.rdLight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.lblGameRules = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            lblImageHeader = new System.Windows.Forms.Label();
            pbLogo = new System.Windows.Forms.PictureBox();
            pnlRound = new System.Windows.Forms.Panel();
            this.lblRound = new System.Windows.Forms.Label();
            this.gbRound = new System.Windows.Forms.GroupBox();
            this.pbCurrentTeam = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerWaiting = new System.Windows.Forms.Timer(this.components);
            this.llWeb = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.gbGame.SuspendLayout();
            this.pnlRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pbLogo)).BeginInit();
            pnlRound.SuspendLayout();
            this.gbRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            btnReset.Enabled = false;
            btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(941, 485);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(122, 52);
            btnReset.TabIndex = 32;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.CornflowerBlue;
            btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStart.ForeColor = System.Drawing.Color.White;
            btnStart.Location = new System.Drawing.Point(793, 485);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(122, 52);
            btnStart.TabIndex = 31;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(llSkipCountDown);
            this.groupBox1.Controls.Add(btnStartRound);
            this.groupBox1.Controls.Add(this.btnGameRules);
            this.groupBox1.Controls.Add(lblScore);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(lblTime);
            this.groupBox1.Controls.Add(lblQuestionType);
            this.groupBox1.Controls.Add(cbQuestionType);
            this.groupBox1.Controls.Add(this.rdDark);
            this.groupBox1.Controls.Add(this.rdLight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(793, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 368);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details + Options";
            // 
            // llSkipCountDown
            // 
            llSkipCountDown.AutoSize = true;
            llSkipCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            llSkipCountDown.Location = new System.Drawing.Point(86, 221);
            llSkipCountDown.Name = "llSkipCountDown";
            llSkipCountDown.Size = new System.Drawing.Size(117, 18);
            llSkipCountDown.TabIndex = 36;
            llSkipCountDown.TabStop = true;
            llSkipCountDown.Text = "Skip Countdown";
            llSkipCountDown.Visible = false;
            llSkipCountDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSkipCountDown_LinkClicked);
            // 
            // btnStartRound
            // 
            btnStartRound.BackColor = System.Drawing.Color.CornflowerBlue;
            btnStartRound.Enabled = false;
            btnStartRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStartRound.ForeColor = System.Drawing.Color.White;
            btnStartRound.Location = new System.Drawing.Point(90, 155);
            btnStartRound.Name = "btnStartRound";
            btnStartRound.Size = new System.Drawing.Size(99, 37);
            btnStartRound.TabIndex = 35;
            btnStartRound.Text = "Start Round";
            btnStartRound.UseVisualStyleBackColor = false;
            btnStartRound.Visible = false;
            btnStartRound.Click += new System.EventHandler(this.btnStartRound_Click);
            // 
            // btnGameRules
            // 
            this.btnGameRules.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameRules.ForeColor = System.Drawing.Color.White;
            this.btnGameRules.Location = new System.Drawing.Point(51, 267);
            this.btnGameRules.Name = "btnGameRules";
            this.btnGameRules.Size = new System.Drawing.Size(181, 52);
            this.btnGameRules.TabIndex = 34;
            this.btnGameRules.Text = "Game Rules";
            this.btnGameRules.UseVisualStyleBackColor = false;
            this.btnGameRules.Click += new System.EventHandler(this.btnGameRules_Click);
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblScore.ForeColor = System.Drawing.Color.CornflowerBlue;
            lblScore.Location = new System.Drawing.Point(168, 245);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(35, 17);
            lblScore.TabIndex = 12;
            lblScore.Text = "0/5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(71, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Your Score:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            lblTime.Location = new System.Drawing.Point(128, 204);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(28, 17);
            lblTime.TabIndex = 8;
            lblTime.Text = "30";
            // 
            // lblQuestionType
            // 
            lblQuestionType.AutoSize = true;
            lblQuestionType.ForeColor = System.Drawing.Color.CornflowerBlue;
            lblQuestionType.Location = new System.Drawing.Point(11, 88);
            lblQuestionType.Name = "lblQuestionType";
            lblQuestionType.Size = new System.Drawing.Size(163, 25);
            lblQuestionType.TabIndex = 3;
            lblQuestionType.Text = "Question Types";
            // 
            // cbQuestionType
            // 
            cbQuestionType.ForeColor = System.Drawing.Color.CornflowerBlue;
            cbQuestionType.FormattingEnabled = true;
            cbQuestionType.Items.AddRange(new object[] {
            "Programming",
            "TV Shows",
            "Movies",
            "Sports",
            "Hobbies",
            "School Subjects",
            "Nationalities"});
            cbQuestionType.Location = new System.Drawing.Point(13, 116);
            cbQuestionType.Name = "cbQuestionType";
            cbQuestionType.Size = new System.Drawing.Size(244, 33);
            cbQuestionType.TabIndex = 2;
            cbQuestionType.Visible = false;
            // 
            // rdDark
            // 
            this.rdDark.AutoSize = true;
            this.rdDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDark.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdDark.Location = new System.Drawing.Point(148, 40);
            this.rdDark.Name = "rdDark";
            this.rdDark.Size = new System.Drawing.Size(105, 24);
            this.rdDark.TabIndex = 1;
            this.rdDark.TabStop = true;
            this.rdDark.Text = "Dark Mode";
            this.rdDark.UseVisualStyleBackColor = true;
            this.rdDark.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdLight
            // 
            this.rdLight.AutoSize = true;
            this.rdLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLight.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdLight.Location = new System.Drawing.Point(16, 40);
            this.rdLight.Name = "rdLight";
            this.rdLight.Size = new System.Drawing.Size(106, 24);
            this.rdLight.TabIndex = 0;
            this.rdLight.TabStop = true;
            this.rdLight.Text = "Light Mode";
            this.rdLight.UseVisualStyleBackColor = true;
            this.rdLight.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 33F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 57);
            this.label1.TabIndex = 29;
            this.label1.Text = "Brain Cardio";
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.pnlRules);
            this.gbGame.Location = new System.Drawing.Point(62, 102);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(688, 415);
            this.gbGame.TabIndex = 33;
            this.gbGame.TabStop = false;
            this.gbGame.Visible = false;
            // 
            // pnlRules
            // 
            this.pnlRules.Controls.Add(this.llWeb);
            this.pnlRules.Controls.Add(this.lblGameRules);
            this.pnlRules.Controls.Add(this.btnNext);
            this.pnlRules.Location = new System.Drawing.Point(16, 27);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(647, 361);
            this.pnlRules.TabIndex = 1;
            // 
            // lblGameRules
            // 
            this.lblGameRules.AutoSize = true;
            this.lblGameRules.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRules.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGameRules.Location = new System.Drawing.Point(17, 28);
            this.lblGameRules.Name = "lblGameRules";
            this.lblGameRules.Size = new System.Drawing.Size(510, 255);
            this.lblGameRules.TabIndex = 0;
            this.lblGameRules.Text = resources.GetString("lblGameRules.Text");
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(282, 293);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 52);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblImageHeader
            // 
            lblImageHeader.AutoSize = true;
            lblImageHeader.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImageHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            lblImageHeader.Location = new System.Drawing.Point(104, 800);
            lblImageHeader.Name = "lblImageHeader";
            lblImageHeader.Size = new System.Drawing.Size(237, 17);
            lblImageHeader.TabIndex = 35;
            lblImageHeader.Text = "Are You Ready For 30 Seconds?";
            // 
            // pbLogo
            // 
            pbLogo.Image = global::ThirtySeconds.Properties.Resources.logo;
            pbLogo.Location = new System.Drawing.Point(78, 553);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(306, 215);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 34;
            pbLogo.TabStop = false;
            // 
            // pnlRound
            // 
            pnlRound.Controls.Add(this.lblRound);
            pnlRound.Controls.Add(this.gbRound);
            pnlRound.Location = new System.Drawing.Point(429, 592);
            pnlRound.Name = "pnlRound";
            pnlRound.Size = new System.Drawing.Size(647, 361);
            pnlRound.TabIndex = 36;
            pnlRound.Visible = false;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRound.Location = new System.Drawing.Point(55, 21);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(102, 21);
            this.lblRound.TabIndex = 6;
            this.lblRound.Text = "Round 1/5";
            // 
            // gbRound
            // 
            this.gbRound.Controls.Add(this.pbCurrentTeam);
            this.gbRound.Controls.Add(this.checkBox5);
            this.gbRound.Controls.Add(this.checkBox4);
            this.gbRound.Controls.Add(this.checkBox3);
            this.gbRound.Controls.Add(this.checkBox2);
            this.gbRound.Controls.Add(this.checkBox1);
            this.gbRound.Controls.Add(this.lblCurrentTurn);
            this.gbRound.Location = new System.Drawing.Point(54, 58);
            this.gbRound.Name = "gbRound";
            this.gbRound.Size = new System.Drawing.Size(479, 274);
            this.gbRound.TabIndex = 0;
            this.gbRound.TabStop = false;
            // 
            // pbCurrentTeam
            // 
            this.pbCurrentTeam.Image = global::ThirtySeconds.Properties.Resources.logo1;
            this.pbCurrentTeam.Location = new System.Drawing.Point(326, 79);
            this.pbCurrentTeam.Name = "pbCurrentTeam";
            this.pbCurrentTeam.Size = new System.Drawing.Size(118, 113);
            this.pbCurrentTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentTeam.TabIndex = 6;
            this.pbCurrentTeam.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox5.Location = new System.Drawing.Point(54, 213);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 25);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.AppearanceChanged += new System.EventHandler(this.CheckBox_Checked);
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox4.Location = new System.Drawing.Point(54, 176);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 25);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.AppearanceChanged += new System.EventHandler(this.CheckBox_Checked);
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox3.Location = new System.Drawing.Point(54, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 25);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.AppearanceChanged += new System.EventHandler(this.CheckBox_Checked);
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox2.Location = new System.Drawing.Point(54, 102);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 25);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.AppearanceChanged += new System.EventHandler(this.CheckBox_Checked);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox1.Location = new System.Drawing.Point(54, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCurrentTurn.Location = new System.Drawing.Point(39, 29);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(119, 21);
            this.lblCurrentTurn.TabIndex = 0;
            this.lblCurrentTurn.Text = "Team 1 Turn";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerWaiting
            // 
            this.timerWaiting.Interval = 1000;
            this.timerWaiting.Tick += new System.EventHandler(this.timerWaiting_Tick);
            // 
            // llWeb
            // 
            this.llWeb.AutoSize = true;
            this.llWeb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.llWeb.LinkVisited = true;
            this.llWeb.Location = new System.Drawing.Point(17, 306);
            this.llWeb.Name = "llWeb";
            this.llWeb.Size = new System.Drawing.Size(139, 13);
            this.llWeb.TabIndex = 35;
            this.llWeb.TabStop = true;
            this.llWeb.Text = "Checkout The Web Version";
            this.llWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWeb_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 549);
            this.Controls.Add(pnlRound);
            this.Controls.Add(lblImageHeader);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(pbLogo);
            this.Controls.Add(btnReset);
            this.Controls.Add(btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Brain Cardio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pbLogo)).EndInit();
            pnlRound.ResumeLayout(false);
            pnlRound.PerformLayout();
            this.gbRound.ResumeLayout(false);
            this.gbRound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private static System.Windows.Forms.Button btnReset;
        private static System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private static System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label8;
        private static System.Windows.Forms.Label lblTime;
        private static System.Windows.Forms.Label lblQuestionType;
        private static System.Windows.Forms.ComboBox cbQuestionType;
        private System.Windows.Forms.RadioButton rdDark;
        private System.Windows.Forms.RadioButton rdLight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblGameRules;
        private static System.Windows.Forms.PictureBox pbLogo;
        private static System.Windows.Forms.Label lblImageHeader;
        private static System.Windows.Forms.Panel pnlRound;
        private System.Windows.Forms.GroupBox gbRound;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblRound;
        private static System.Windows.Forms.Button btnStartRound;
        private System.Windows.Forms.PictureBox pbCurrentTeam;
        private Timer timer;
        private static System.Windows.Forms.LinkLabel llSkipCountDown;
        private Timer timerWaiting;
        private LinkLabel llWeb;
    }
}

