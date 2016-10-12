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
    public partial class FormNewMatchWarning : Form
    {
        bool acceptNameClicked;
        bool yesClicked;

        public FormNewMatchWarning()
        {
            InitializeComponent();
            acceptNameClicked = false;
            yesClicked = false;
        }

        public bool AcceptNameClicked
        {
            get { return acceptNameClicked; }   //Read only
        }

        //No Button
        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Yes Button
        private void buttonYes_Click(object sender, EventArgs e)
        {
            simulateButtonYesClick();
        }

        public void simulateButtonYesClick()
        {
            yesClicked = true;
            textBoxMatchNameInput.Visible = true;
            labelPrompt.Visible = true;
            buttonAcceptName.Visible = true;
            labelQuestion.Visible = false;
            labelWarning.Visible = false;
            buttonNo.Visible = false;
            buttonYes.Visible = false;
        }

        //Accept Name Input Button
        private void buttonAcceptName_Click(object sender, EventArgs e)
        {
            //No name given for match
            if (textBoxMatchNameInput.Text == "")
            {
                labelError.Text = "*Must enter a name for the match*";
                labelError.Location = new System.Drawing.Point((this.ClientSize.Width - this.labelError.Size.Width) / 2, 167);
                labelError.Visible = true;
            }
            //Duplicate name given for match
            else if (Variables.Stat_Exchanger.CheckFileExists(textBoxMatchNameInput.Text))
            {
                labelError.Text = "*Match with that name already exists*";
                labelError.Location = new System.Drawing.Point((this.ClientSize.Width - this.labelError.Size.Width) / 2, 167);
                labelError.Visible = true;
            }
            //Name given for match exceeds character limit
            else if (textBoxMatchNameInput.Text.Length > 60)
            {
                labelError.Text = "*Match name cannot exceed 60 characters*";
                labelError.Location = new System.Drawing.Point((this.ClientSize.Width - this.labelError.Size.Width) / 2, 167);
                labelError.Visible = true;
            }
            //Valid name given for match
            else
            {
                Variables.Stat_Exchanger.CurrentMatch.ResetAllStats();
                Variables.Stat_Exchanger.CurrentMatch.MatchName = textBoxMatchNameInput.Text;
                Variables.Stat_Exchanger.CreateNewFileByMatchName();

                Variables.Form_UpdateStats.LabelMatchNameText = textBoxMatchNameInput.Text;
                Variables.Form_UpdateStats.LabelMatchName.Location = new System.Drawing.Point((Variables.Form_UpdateStats.ClientSize.Width - Variables.Form_UpdateStats.LabelMatchName.Size.Width) / 2, 9);

                acceptNameClicked = true;
                this.Close();
                Variables.Form_UpdateStats.Show();
            }
        }

        //Form Closed
        private void FormNewMatchWarning_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (acceptNameClicked == false && yesClicked == true)
            {
                FormChangesNotification formNotification = new FormChangesNotification();
                formNotification.ShowDialog();
            }
        }
    }
}
