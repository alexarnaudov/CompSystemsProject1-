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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage ss = new Homepage();
            ss.Show();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Homepage ss = new Homepage();
            ss.Show();
        }

        private void NewGame_FormClosing(object sender, FormClosingEventArgs e)
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

        private void easyGameBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Easy ss = new Easy();
            ss.Show();
        }

        private void mediumGameBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medium ss = new Medium();
            ss.Show();
        }

        private void hardGameBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hard ss = new Hard();
            ss.Show();
        }

        private void extremeGameBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Extreme ss = new Extreme();
            ss.Show();
        }
    }
}
