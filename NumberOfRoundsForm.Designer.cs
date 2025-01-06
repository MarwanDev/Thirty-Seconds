namespace ThirtySeconds
{
    partial class NumberOfRoundsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nfNumberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.btnRoundsNumberSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nfNumberOfRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Many Rounds?";
            // 
            // nfNumberOfRounds
            // 
            this.nfNumberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfNumberOfRounds.Location = new System.Drawing.Point(63, 99);
            this.nfNumberOfRounds.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nfNumberOfRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nfNumberOfRounds.Name = "nfNumberOfRounds";
            this.nfNumberOfRounds.Size = new System.Drawing.Size(207, 31);
            this.nfNumberOfRounds.TabIndex = 1;
            this.nfNumberOfRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRoundsNumberSave
            // 
            this.btnRoundsNumberSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRoundsNumberSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundsNumberSave.ForeColor = System.Drawing.Color.White;
            this.btnRoundsNumberSave.Location = new System.Drawing.Point(105, 152);
            this.btnRoundsNumberSave.Name = "btnRoundsNumberSave";
            this.btnRoundsNumberSave.Size = new System.Drawing.Size(122, 52);
            this.btnRoundsNumberSave.TabIndex = 32;
            this.btnRoundsNumberSave.Text = "Go >";
            this.btnRoundsNumberSave.UseVisualStyleBackColor = false;
            this.btnRoundsNumberSave.Click += new System.EventHandler(this.btnRoundsNumberSave_Click);
            // 
            // NumberOfRoundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 233);
            this.Controls.Add(this.btnRoundsNumberSave);
            this.Controls.Add(this.nfNumberOfRounds);
            this.Controls.Add(this.label1);
            this.Name = "NumberOfRoundsForm";
            this.Text = "How Many Rounds?";
            this.Load += new System.EventHandler(this.NumberOfRoundsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nfNumberOfRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nfNumberOfRounds;
        private System.Windows.Forms.Button btnRoundsNumberSave;
    }
}