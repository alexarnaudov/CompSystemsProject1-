using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pictureGame.Properties;

namespace pictureGame
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage ss = new Homepage();
            ss.Show();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Homepage ss = new Homepage();
            ss.Show();
        }

        private void Highscore_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Exit the game?", "Close Application", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                Settings.Default["Colour"] = "Black";
                Settings.Default["FontSize"] = 10;
                Settings.Default["Music"] = "True";
                Settings.Default["SoundEffects"] = "True";
                Settings.Default.Save();
                Application.ExitThread();
            }
            else if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
