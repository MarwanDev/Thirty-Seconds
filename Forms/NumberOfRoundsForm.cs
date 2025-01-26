using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ThirtySeconds
{
    public partial class NumberOfRoundsForm : Form
    {
        public static byte NumberOfRounds { get; private set; }
        public string TeamName { get; private set; }
        public Image TeamImage { get; private set; }
        public NumberOfRoundsForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += NumberOfRoundsForm_KeyDown;
        }

        private void NumberOfRoundsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRoundsNumberSave.PerformClick();
            }
        }

        private void NumberOfRoundsForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void ResetGame()
        {
            NumberOfRounds = 0;
        }

        private void btnRoundsNumberSave_Click(object sender, EventArgs e)
        {
            NumberOfRounds = (byte)nfNumberOfRounds.Value;
            this.Hide();
        }
    }
}
