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
    public partial class FormUpdateStats : Form
    {
        Form _formMainMenu;

        public FormUpdateStats()
        {
            InitializeComponent();
            _formMainMenu = null;
        }

        public FormUpdateStats(Form formMainMenu)
        {
            InitializeComponent();
            _formMainMenu = formMainMenu;
        }

        //***Serving Buttons***
        private void buttonServeAttempt_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.ServeAttempts += 1;
        }

        private void buttonServeAce_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.ServeAces += 1;
        }

        private void buttonServeError_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.ServeErrors += 1;
        }

        private void buttonServeAttempt_MouseEnter(object sender, EventArgs e)
        {
            buttonServeAttempt.BackColor = Color.Tan;
        }

        private void buttonServeAttempt_MouseLeave(object sender, EventArgs e)
        {
            buttonServeAttempt.BackColor = Color.LemonChiffon;
        }

        private void buttonServeAce_MouseEnter(object sender, EventArgs e)
        {
            buttonServeAce.BackColor = Color.Tan;
        }

        private void buttonServeAce_MouseLeave(object sender, EventArgs e)
        {
            buttonServeAce.BackColor = Color.LemonChiffon;
        }

        private void buttonServeError_MouseEnter(object sender, EventArgs e)
        {
            buttonServeError.BackColor = Color.Tan;
        }

        private void buttonServeError_MouseLeave(object sender, EventArgs e)
        {
            buttonServeError.BackColor = Color.LemonChiffon;
        }

        //***Receiving Buttons***
        private void buttonReceive0_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.EditReceiveScores(0);
        }

        private void buttonReceive1_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.EditReceiveScores(1);
        }

        private void buttonReceive2_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.EditReceiveScores(2);
        }

        private void buttonReceive3_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.EditReceiveScores(3);
        }

        private void buttonReceive0_MouseEnter(object sender, EventArgs e)
        {
            buttonReceive0.BackColor = Color.PowderBlue;
        }

        private void buttonReceive0_MouseLeave(object sender, EventArgs e)
        {
            buttonReceive0.BackColor = Color.LemonChiffon;
        }

        private void buttonReceive1_MouseEnter(object sender, EventArgs e)
        {
            buttonReceive1.BackColor = Color.PowderBlue;
        }

        private void buttonReceive1_MouseLeave(object sender, EventArgs e)
        {
            buttonReceive1.BackColor = Color.LemonChiffon;
        }

        private void buttonReceive2_MouseEnter(object sender, EventArgs e)
        {
            buttonReceive2.BackColor = Color.PowderBlue;
        }

        private void buttonReceive2_MouseLeave(object sender, EventArgs e)
        {
            buttonReceive2.BackColor = Color.LemonChiffon;
        }

        private void buttonReceive3_MouseEnter(object sender, EventArgs e)
        {
            buttonReceive3.BackColor = Color.PowderBlue;
        }

        private void buttonReceive3_MouseLeave(object sender, EventArgs e)
        {
            buttonReceive3.BackColor = Color.LemonChiffon;
        }

        //***Hitting Buttons***
        private void buttonHitAttempt_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.AttackAttempts += 1;
        }

        private void buttonHitKill_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.AttackKills += 1;
        }

        private void buttonHitError_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.AttackErrors += 1;
        }

        private void buttonHitAttempt_MouseEnter(object sender, EventArgs e)
        {
            buttonHitAttempt.BackColor = Color.MistyRose;
        }

        private void buttonHitAttempt_MouseLeave(object sender, EventArgs e)
        {
            buttonHitAttempt.BackColor = Color.LemonChiffon;
        }

        private void buttonHitKill_MouseEnter(object sender, EventArgs e)
        {
            buttonHitKill.BackColor = Color.MistyRose;
        }

        private void buttonHitKill_MouseLeave(object sender, EventArgs e)
        {
            buttonHitKill.BackColor = Color.LemonChiffon;
        }

        private void buttonHitError_MouseEnter(object sender, EventArgs e)
        {
            buttonHitError.BackColor = Color.MistyRose;
        }

        private void buttonHitError_MouseLeave(object sender, EventArgs e)
        {
            buttonHitError.BackColor = Color.LemonChiffon;
        }

        //***Digging Buttons***
        private void buttonDigAttempt_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.DigAttempts += 1;
        }

        private void buttonDigError_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.DigErrors += 1;
        }

        private void buttonDigAttempt_MouseEnter(object sender, EventArgs e)
        {
            buttonDigAttempt.BackColor = Color.DarkSeaGreen;
        }

        private void buttonDigAttempt_MouseLeave(object sender, EventArgs e)
        {
            buttonDigAttempt.BackColor = Color.LemonChiffon;
        }

        private void buttonDigError_MouseEnter(object sender, EventArgs e)
        {
            buttonDigError.BackColor = Color.DarkSeaGreen;
        }

        private void buttonDigError_MouseLeave(object sender, EventArgs e)
        {
            buttonDigError.BackColor = Color.LemonChiffon;
        }

        //***Setting Buttons***
        private void buttonSetAttempt_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.SetAttempts += 1;
        }

        private void buttonSetAssist_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.SetAssists += 1;
        }

        private void buttonSetError_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.SetErrors += 1;
        }

        private void buttonSetAttempt_MouseEnter(object sender, EventArgs e)
        {
            buttonSetAttempt.BackColor = Color.Thistle;
        }

        private void buttonSetAttempt_MouseLeave(object sender, EventArgs e)
        {
            buttonSetAttempt.BackColor = Color.LemonChiffon;
        }

        private void buttonSetAssist_MouseEnter(object sender, EventArgs e)
        {
            buttonSetAssist.BackColor = Color.Thistle;
        }

        private void buttonSetAssist_MouseLeave(object sender, EventArgs e)
        {
            buttonSetAssist.BackColor = Color.LemonChiffon;
        }

        private void buttonSetError_MouseEnter(object sender, EventArgs e)
        {
            buttonSetError.BackColor = Color.Thistle;
        }

        private void buttonSetError_MouseLeave(object sender, EventArgs e)
        {
            buttonSetError.BackColor = Color.LemonChiffon;
        }

        //***Blocking Buttons***
        private void buttonBlockSolo_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.BlockSolos += 1;
        }

        private void buttonBlockAssist_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.BlockAssists += 1;
        }

        private void buttonBlockError_Click(object sender, EventArgs e)
        {
            Variables.Stat_Exchanger.CurrentMatch.BlockErrors += 1;
        }

        private void buttonBlockSolo_MouseEnter(object sender, EventArgs e)
        {
            buttonBlockSolo.BackColor = Color.NavajoWhite;
        }

        private void buttonBlockSolo_MouseLeave(object sender, EventArgs e)
        {
            buttonBlockSolo.BackColor = Color.LemonChiffon;
        }

        private void buttonBlockAssist_MouseEnter(object sender, EventArgs e)
        {
            buttonBlockAssist.BackColor = Color.NavajoWhite;
        }

        private void buttonBlockAssist_MouseLeave(object sender, EventArgs e)
        {
            buttonBlockAssist.BackColor = Color.LemonChiffon;
        }

        private void buttonBlockError_MouseEnter(object sender, EventArgs e)
        {
            buttonBlockError.BackColor = Color.NavajoWhite;
        }

        private void buttonBlockError_MouseLeave(object sender, EventArgs e)
        {
            buttonBlockError.BackColor = Color.LemonChiffon;
        }

        //***Main Menu Button***
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            //save stats to file
            Variables.Stat_Exchanger.WriteCurrentMatchStatsToFile();

            //return to main menu
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

        //***Form Closed***
        private void FormUpdateStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //_formMainMenu.Close();
        }
    }
}
