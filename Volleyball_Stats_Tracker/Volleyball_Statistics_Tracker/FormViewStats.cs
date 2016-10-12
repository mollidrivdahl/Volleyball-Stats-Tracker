using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Statistics_Tracker
{
    public partial class FormViewStats : Form
    {
        Form _formMainMenu;
        public FormViewStats()
        {
            InitializeComponent();
            _formMainMenu = null;
        }

        public FormViewStats(Form formMainMenu)
        {
            InitializeComponent();
            _formMainMenu = formMainMenu;
        }

        //Form Visible
        private void FormViewStats_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                comboBoxMatches.Items.Clear();

                comboBoxMatches.Items.Add("<Select a Match>");
                comboBoxMatches.Text = "<Select a Match>";

                Variables.Stat_Exchanger.ReadStatsFromAllFiles();   //get past matches' stats

                foreach (Match pastMatch in Variables.Stat_Exchanger.PastMatches)
                {
                    comboBoxMatches.Items.Add(pastMatch.MatchName);
                }

                comboBoxMatches.Items.Add(Variables.Stat_Exchanger.CurrentMatch.MatchName);
            }
        }

        //Main Menu Button
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            _formMainMenu.Show();
            this.Hide();
        }

        private void buttonMainMenu_MouseEnter(object sender, EventArgs e)
        {
            buttonMainMenu.BackColor = Color.Khaki;
        }

        private void buttonMainMenu_MouseLeave(object sender, EventArgs e)
        {
            buttonMainMenu.BackColor = Color.LemonChiffon;
        }

        //Combo Box with Matches
        private void comboBoxMatches_DropDown(object sender, EventArgs e)
        {
            if (comboBoxMatches.Items.Contains("<Select a Match>"))
            {
                comboBoxMatches.Items.Remove("<Select a Match>");
            }
        }

        private void comboBoxMatches_DropDownClosed(object sender, EventArgs e)
        {
            if (!comboBoxMatches.Items.Contains("<Select a Match>"))
            {
                comboBoxMatches.Items.Add("<Select a Match>");
            }

            if (!(comboBoxMatches.SelectedIndex > -1))  //if something is not selected
            {
                comboBoxMatches.Text = "<Select a Match>";
            }
        }

        //Form Closed
        private void FormViewStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //_formMainMenu.Close();
        }
    }
}
