using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball_Statistics_Tracker
{
    public class Match
    {
        string _name;
        int _serveAttempts;
        int _serveAces;
        int _serveErrors;
        int _attackAttempts;
        int _attackKills;
        int _attackErrors;
        int _setAttempts;
        int _setAssists;
        int _setErrors;
        int _digAttempts;
        int _digErrors;
        int _blockSolos;
        int _blockAssists;
        int _blockErrors;
        List<int> _receiveScores;    //total receiving attempts is size of list

        public Match()
        {
            _name = "\0";
            _serveAttempts = 0;
            _serveAces = 0;
            _serveErrors = 0;
            _attackAttempts = 0;
            _attackKills = 0;
            _attackErrors = 0;
            _setAttempts = 0;
            _setAssists = 0;
            _setErrors = 0;
            _digAttempts = 0;
            _digErrors = 0;
            _blockSolos = 0;
            _blockAssists = 0;
            _blockErrors = 0;
            _receiveScores = new List<int>();
        }

        public Match(string matchName)
        {
            _name = matchName;
            _serveAttempts = 0;
            _serveAces = 0;
            _serveErrors = 0;
            _attackAttempts = 0;
            _attackKills = 0;
            _attackErrors = 0;
            _setAttempts = 0;
            _setAssists = 0;
            _setErrors = 0;
            _digAttempts = 0;
            _digErrors = 0;
            _blockSolos = 0;
            _blockAssists = 0;
            _blockErrors = 0;
            _receiveScores = new List<int>();
        }

        public string MatchName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ServeAttempts
        {
            get { return _serveAttempts; }
            set { _serveAttempts = value; }
        }

        public int ServeAces
        {
            get { return _serveAces; }
            set { _serveAces = value; }
        }

        public int ServeErrors
        {
            get { return _serveErrors; }
            set { _serveErrors = value; }
        }

        public int AttackAttempts
        {
            get { return _attackAttempts; }
            set { _attackAttempts = value; }
        }

        public int AttackKills
        {
            get { return _attackKills; }
            set { _attackKills = value; }
        }

        public int AttackErrors
        {
            get { return _attackErrors; }
            set { _attackErrors = value; }
        }

        public int SetAttempts
        {
            get { return _setAttempts; }
            set { _setAttempts = value; }
        }

        public int SetAssists
        {
            get { return _setAssists; }
            set { _setAssists = value; }
        }

        public int SetErrors
        {
            get { return _setErrors; }
            set { _setErrors = value; }
        }

        public int DigAttempts
        {
            get { return _digAttempts; }
            set { _digAttempts = value; }
        }

        public int DigErrors
        {
            get { return _digErrors; }
            set { _digErrors = value; }
        }

        public int BlockSolos
        {
            get { return _blockSolos; }
            set { _blockSolos = value; }
        }

        public int BlockAssists
        {
            get { return _blockAssists; }
            set { _blockAssists = value; }
        }

        public int BlockErrors
        {
            get { return _blockErrors; }
            set { _blockErrors = value; }
        }

        public void EditReceiveScores(int value)
        {
            _receiveScores.Add(value);
        }

        public List<int> GetReceiveScores()
        {
            return _receiveScores;
        }

        public void ResetAllStats()
        {
            _name = "\0";
            _serveAttempts = 0;
            _serveAces = 0;
            _serveErrors = 0;
            _attackAttempts = 0;
            _attackKills = 0;
            _attackErrors = 0;
            _setAttempts = 0;
            _setAssists = 0;
            _setErrors = 0;
            _digAttempts = 0;
            _digErrors = 0;
            _blockSolos = 0;
            _blockAssists = 0;
            _blockErrors = 0;
            _receiveScores.Clear();
        }

        public int GetTotalServes()
        {
            return _serveAttempts + _serveAces + _serveErrors;
        }

        public double GetServeAcePercent()
        {
            double avg = 1;

            if (GetTotalServes() != 0)
                avg = Convert.ToDouble(_serveAces) / Convert.ToDouble(GetTotalServes());

            return avg;
        }

        public double GetServeErrorPercent()
        {
            double avg = 1;

            if (GetTotalServes() != 0)
                return Convert.ToDouble(_serveErrors) / Convert.ToDouble(GetTotalServes());

            return avg;
        }

        public int GetTotalAttacks()
        {
            return _attackAttempts + _attackKills + _attackErrors;
        }

        public double GetAttackKillPercent()
        {
            double avg = 1;

            if (GetTotalAttacks() != 0)
                avg = Convert.ToDouble(_attackKills) / Convert.ToDouble(GetTotalAttacks());

            return avg;
        }

        public double GetAttackErrorPercent()
        {
            double avg = 1;

            if (GetTotalAttacks() != 0)
                avg = Convert.ToDouble(_attackErrors) / Convert.ToDouble(GetTotalAttacks());

            return avg;
        }

        public int GetTotalSets()
        {
            return _setAttempts + _setAssists + _setErrors;
        }

        public double GetSetAssistPercent()
        {
            double avg = 1;

            if (GetTotalSets() != 0)
                avg = Convert.ToDouble(_setAssists) / Convert.ToDouble(GetTotalSets());

            return avg;
        }

        public double GetSetErrorPercent()
        {
            double avg = 1;

            if (GetTotalSets() != 0)
                avg = Convert.ToDouble(_setErrors) / Convert.ToDouble(GetTotalSets());

            return avg;
        }

        public int GetTotalDigs()
        {
            return _digAttempts + _digErrors;
        }

        public double GetDigSuccessPercent()
        {
            double avg = 1;

            if (GetTotalDigs() != 0)
                avg = Convert.ToDouble(_digAttempts) / Convert.ToDouble(GetTotalDigs());

            return avg;
        }

        public double GetDigErrorPercent()
        {
            double avg = 1;

            if (GetTotalDigs() != 0)
                avg = Convert.ToDouble(_digErrors) / Convert.ToDouble(GetTotalDigs());

            return avg;
        }

        public int GetTotalBlocks()
        {
            return _blockSolos + _blockAssists + _blockErrors;
        }

        public int GetTotalSuccessBlocks()
        {
            return _blockSolos + _blockAssists;
        }

        public double GetBlockSuccessPercent()
        {
            double avg = 1;

            if (GetTotalBlocks() != 0)
                avg = Convert.ToDouble(GetTotalSuccessBlocks()) / Convert.ToDouble(GetTotalBlocks());

            return avg;
        }

        public double GetBlockErrorPercent()
        {
            double avg = 1;

            if (GetTotalBlocks() != 0)
                avg = Convert.ToDouble(_blockErrors) / Convert.ToDouble(GetTotalBlocks());

            return avg;
        }

        public int GetTotalReceiveAttempts()
        {
            return _receiveScores.Count;
        }

        public double GetReceiveScoreAverage()
        {
            int sumOfScores = 0;
            double avg = 0;

            if (GetTotalReceiveAttempts() != 0)
            {
                foreach (int score in _receiveScores)
                {
                    sumOfScores += score;
                }

                avg = Convert.ToDouble(sumOfScores) / Convert.ToDouble(GetTotalReceiveAttempts());
            }

            return avg;
        }

        public double GetReceiveZerosPercent()
        {
            int numOfZeros = 0;
            double avg = 1;

            if (GetTotalReceiveAttempts() != 0)
            {
                foreach (int score in _receiveScores)
                {
                    if (score == 0)
                        numOfZeros++;
                }

                avg = Convert.ToDouble(numOfZeros) / Convert.ToDouble(GetTotalReceiveAttempts());
            }

            return avg;
        }

        public double GetReceiveOnesPercent()
        {
            int numOfOnes = 0;
            double avg = 1;

            if (GetTotalReceiveAttempts() != 0)
            {
                foreach (int score in _receiveScores)
                {
                    if (score == 1)
                        numOfOnes++;
                }

                avg = Convert.ToDouble(numOfOnes) / Convert.ToDouble(GetTotalReceiveAttempts());
            }

            return avg;
        }

        public double GetReceiveTwosPercent()
        {
            int numOfTwos = 0;
            double avg = 1;

            if (GetTotalReceiveAttempts() != 0)
            {
                foreach (int score in _receiveScores)
                {
                    if (score == 2)
                        numOfTwos++;
                }

                avg = Convert.ToDouble(numOfTwos) / Convert.ToDouble(GetTotalReceiveAttempts());
            }

            return avg;
        }

        public double GetReceiveThreesPercent()
        {
            int numOfThrees = 0;
            double avg = 1;

            if (GetTotalReceiveAttempts() != 0)
            {
                foreach (int score in _receiveScores)
                {
                    if (score == 3)
                        numOfThrees++;
                }

                avg = Convert.ToDouble(numOfThrees) / Convert.ToDouble(GetTotalReceiveAttempts());
            }

            return avg;
        }
    }
}
