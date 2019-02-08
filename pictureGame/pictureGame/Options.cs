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
    public partial class Options : Form
    {
        Homepage c = new Homepage();
        public Options()
        {
            InitializeComponent();
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage ss = new Homepage();
            ss.Show();
        }





        private void Options_Load(object sender, EventArgs e)
        {
            addLabels();
           
        }
        private void addLabels()
        {

            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;


            Label[] labels = new Label[4];
            String[] labelNames = { "Font size:", "Music:", "Sound effects:", "Colour:" };
            for (int i = 0; i <= 3; i++)
            {
                labels[i] = new Label();
                labels[i].Size = new Size(100, 100);
                labels[i].Location = new System.Drawing.Point(30, 50 + (i * 30));
                labels[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                labels[i].Text = labelNames[i].ToString();
                labels[i].Name = labelNames[i].ToString();
                labels[i].Font = new Font("Arial", 18, FontStyle.Bold);
                labels[i].AutoSize = true;
                labels[i].ForeColor=System.Drawing.Color.White;
                this.Controls.Add(labels[i]);
                tableLayoutPanel1.Controls.Add(labels[i]);



            }


        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void musicCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (musicCmboBox.SelectedItem.ToString() == "Off")
            {
                Settings.Default["Music"] = "False";
                Settings.Default.Save();
                
              
            }
            else if (musicCmboBox.SelectedItem.ToString() == "On")
            {
                Settings.Default["Music"] = "True";
                Settings.Default.Save();
             
            }
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


        private void fontColourCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontColourCmboBox.SelectedItem.ToString() == "Red")
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    
                  Settings.Default["Colour"] = "Red";
                    Settings.Default.Save();
                 
                    theControl.ForeColor= System.Drawing.Color.Red;
                }
               
            }
            else if (fontColourCmboBox.SelectedItem.ToString() == "Blue")
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                   
                    Settings.Default["Colour"] = "Blue";
                    Settings.Default.Save();
                   
                    theControl.ForeColor = System.Drawing.Color.Blue;
                }
            }
            else if (fontColourCmboBox.SelectedItem.ToString() == "White")
            {
                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                 
                    Settings.Default["Colour"] = "White";
                    Settings.Default.Save();
                    theControl.ForeColor = System.Drawing.Color.White;
                }
            }

        }

        private void fontSizeCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (fontSizeCmboBox.SelectedItem.ToString() == "Small")
            {
                Font theFont = new Font("Arial", 5, FontStyle.Bold);
                Settings.Default["FontSize"] = 5;
                Settings.Default.Save();

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }

            }
            else if (fontSizeCmboBox.SelectedItem.ToString() == "Medium")
            {
                Font theFont = new Font("Arial",10, FontStyle.Bold);
                Settings.Default["FontSize"] = 10;
                Settings.Default.Save();

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }

            }
            else if (fontSizeCmboBox.SelectedItem.ToString() == "Large")
            {
                Font theFont = new Font("Arial", 15, FontStyle.Bold);
                Settings.Default["FontSize"] = 15;
                Settings.Default.Save();

                foreach (Control theControl in (Options.GetAllControls(this)))
                {
                    theControl.Font = theFont;
                }

            }
            

        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
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
