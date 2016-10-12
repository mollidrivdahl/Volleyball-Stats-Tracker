using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Statistics_Tracker
{
    public class Variables
    {
        static FormViewStats _formViewStats;
        static FormUpdateStats _formUpdateStats;
        static StatExchanger _statExchanger;

        private Variables()
        {
            _formViewStats = null;
            _formUpdateStats = null;
            _statExchanger = null;
        }

        public Variables(Form formMainMenu)
        {
            _formViewStats = new FormViewStats(formMainMenu);
            _formUpdateStats = new FormUpdateStats(formMainMenu);
            _statExchanger = new StatExchanger();
        }

        public static FormViewStats Form_ViewStats
        {
            get { return _formViewStats; } //Read only
        }

        public static FormUpdateStats Form_UpdateStats
        {
            get { return _formUpdateStats; } //Read only
        }

        public static StatExchanger Stat_Exchanger
        {
            get { return _statExchanger; } //Read only
        }
    }
}
