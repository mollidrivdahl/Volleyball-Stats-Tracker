using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Statistics_Tracker
{
    public partial class FormMainMenu : Form
    {
        Variables _staticVariables;
        bool _firstMatchStarted;

        public FormMainMenu()
        {
            InitializeComponent();
            _staticVariables = new Variables(this);
            _firstMatchStarted = false;
        }

        //***Form Load***
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            //stats folder has no files or folders (no matches have been saved)
            if (Directory.GetFiles(@"..\..\stats").Length == 0 && Directory.GetDirectories(@"..\..\stats").Length == 0)
            {
                buttonUpdateCurrent.Enabled = false;
                buttonUpdateCurrent.BackColor = Color.Gainsboro;
            }
            //at least one match has been saved
            else
            {
                _firstMatchStarted = true;
                Variables.Stat_Exchanger.LoadCurrentMatchInfo();    //get current match's stats
            }
        }

        //***Update Current Button***
        private void buttonUpdateCurrent_Click(object sender, EventArgs e)
        {
            Variables.Form_UpdateStats.Show();
            Variables.Form_UpdateStats.LabelMatchNameText = Variables.Stat_Exchanger.CurrentMatch.MatchName;
            Variables.Form_UpdateStats.LabelMatchName.Location = new System.Drawing.Point((Variables.Form_UpdateStats.ClientSize.Width - Variables.Form_UpdateStats.LabelMatchName.Size.Width) / 2, 9);
            this.Hide();
        }

        private void buttonUpdateCurrent_MouseEnter(object sender, EventArgs e)
        {
            buttonUpdateCurrent.BackColor = Color.MistyRose;
        }

        private void buttonUpdateCurrent_MouseLeave(object sender, EventArgs e)
        {
            buttonUpdateCurrent.BackColor = Color.LemonChiffon;
        }

        //***Update New Button***
        private void buttonUpdateNew_Click(object sender, EventArgs e)
        {
            FormNewMatchWarning warningDialog = new FormNewMatchWarning();

            if (_firstMatchStarted)
                warningDialog.ShowDialog();
            else
            {
                warningDialog.simulateButtonYesClick();
                warningDialog.ShowDialog();
            }

            if (warningDialog.AcceptNameClicked)
            {
                this.Hide();
                FormChangesNotification formNotification = new FormChangesNotification();
                formNotification.LabelNotification.Text = "You are now starting a new match!";
                formNotification.LabelNotification.Location = new System.Drawing.Point((formNotification.ClientSize.Width - formNotification.LabelNotification.Size.Width) / 2, 9);
                formNotification.ShowDialog();

                if (!_firstMatchStarted)
                {
                    _firstMatchStarted = true;
                    buttonUpdateCurrent.Enabled = true;
                    buttonUpdateCurrent.BackColor = Color.LemonChiffon;
                }
            }

        }
        private void buttonUpdateNew_MouseEnter(object sender, EventArgs e)
        {
            buttonUpdateNew.BackColor = Color.MistyRose;
        }

        private void buttonUpdateNew_MouseLeave(object sender, EventArgs e)
        {
            buttonUpdateNew.BackColor = Color.LemonChiffon;
        }

        //***View Stats Button***
        private void buttonViewStats_Click(object sender, EventArgs e)
        {
            Variables.Form_ViewStats.Show();
            this.Hide();
        }

        private void buttonViewStats_MouseEnter(object sender, EventArgs e)
        {
            buttonViewStats.BackColor = Color.PaleTurquoise;
        }

        private void buttonViewStats_MouseLeave(object sender, EventArgs e)
        {
            buttonViewStats.BackColor = Color.LemonChiffon;
        }

        //***Exit Button***
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();

        }
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Khaki;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.LemonChiffon;
        }

        //***Form Closed***
        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //this.Close();
        }


    }
}