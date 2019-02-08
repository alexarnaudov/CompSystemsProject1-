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
    public partial class Homepage : Form
    {
        //public String homepageColour;
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
        public Homepage()
        {
            InitializeComponent();

            setup();


        }
        private void setup()
        {
            
            
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }



        private void newGameBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewGame ss = new NewGame();
            ss.Show();
        }

        private void highscoreBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Highscore ss = new Highscore();
            ss.Show();
        }

        private void optionsBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options ss = new Options();
            ss.Show();
        }

        private void helpBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help ss = new Help();
            ss.Show();
        }

        private void soundBttn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "Planetrise v1_0.wav";
            if (soundBttn.Text == "On")
            {

                soundBttn.Image = Image.FromFile(@"soundOff.png");
                soundBttn.Text = "Off";
                sound.Stop();


            }

            else if (soundBttn.Text == "Off")
            {
                soundBttn.Image = Image.FromFile(@"sound1.png");
                soundBttn.Text = "On";
                sound.PlayLooping();
            }



        }

        public void musicOn()
        {
            sound.SoundLocation = "Planetrise v1_0.wav";
            if (Settings.Default["Music"].ToString() == "True")
            {
               
                soundBttn.Image = Image.FromFile(@"sound1.png");
                soundBttn.Text = "On";
                sound.PlayLooping();
            }
            else if (Settings.Default["Music"].ToString() == "False")
            {

                soundBttn.Image = Image.FromFile(@"soundOff.png");
                soundBttn.Text = "Off";
                sound.Stop();
            }

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
           
            controlColour();
            controlSize();
            musicOn();

        }
        public static IEnumerable<Control> GetAllControls(Control control)
        {
            Stack<Control> contrlStack = new Stack<Control>();

            contrlStack.Push(control);

            while (contrlStack.Any())
            {
                var nextControl = contrlStack.Pop();

                foreach (Control childControl in nextControl.Controls)
                {
                    contrlStack.Push(childControl);
                }

                yield return nextControl;
            }
        }

        public void controlColour()
        {
          
            if (Settings.Default["Colour"].ToString() == "Red")
            {
               
                foreach (Control theControl in (Homepage.GetAllControls(this)))
                {

                    theControl.ForeColor = System.Drawing.Color.Red;
                }
            }
            else if (Settings.Default["Colour"].ToString() == "Blue")
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {

                    theControl.ForeColor = System.Drawing.Color.Blue;
                }
            }
            else if (Settings.Default["Colour"].ToString() == "White")
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {

                    theControl.ForeColor = System.Drawing.Color.White;
                }
            }
            else 
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {

                    theControl.ForeColor = System.Drawing.Color.Black;
                }
            }
        }
        public void controlSize()
        {

            if (System.Convert.ToInt32(Settings.Default["FontSize"]) == 5)
            {
                Font theFont = new Font("Arial", 5, FontStyle.Bold);

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }
            }
            else if (System.Convert.ToInt32(Settings.Default["FontSize"]) == 10)
            {
                Font theFont = new Font("Arial", 10, FontStyle.Bold);
               
                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }
            }
            else if (System.Convert.ToInt32(Settings.Default["FontSize"]) == 15)
            {
                Font theFont = new Font("Arial", 15, FontStyle.Bold);

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }
            }
            else
            {
                Font theFont = new Font("Arial", 10, FontStyle.Bold);

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }
            }
        }

        public void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Exit the game?","Close Application", MessageBoxButtons.YesNo );
            if (choice == DialogResult.Yes)
            {
                Settings.Default["Colour"] = "White";
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
