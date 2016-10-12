using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Volleyball_Statistics_Tracker
{
    public class StatExchanger
    {
        Match _curMatch;
        List<Match> _pastMatches;
        public StatExchanger()
        {
            _curMatch = new Match();
            _pastMatches = new List<Match>();
        }

        public Match CurrentMatch
        {
            get { return _curMatch; }
            set { _curMatch = value; }
        }

        public List<Match> PastMatches
        {
            get { return _pastMatches; }    //read only
        }

        public void CreateNewFileByMatchName()
        {
            File.Create(@"..\..\stats\" + _curMatch.MatchName + ".txt").Close();
        }

        public bool CheckFileExists(string fileName)
        {
            return File.Exists(@"..\..\stats\" + fileName + ".txt");
        }

        public bool CheckFileEmpty(string filePath)
        {
            return (new FileInfo(filePath).Length == 0);
        }

        public string GetCurrentMatchFileNameAndExt()
        {
            DirectoryInfo statsDirectory = new DirectoryInfo(@"..\..\stats");
            FileInfo currentMatchFile = statsDirectory.GetFiles().OrderByDescending(file => file.LastAccessTime).First();
            return currentMatchFile.Name;
        }

        public void LoadCurrentMatchInfo()
        {
            _curMatch.MatchName = GetCurrentMatchFileNameAndExt();
            _curMatch.MatchName = _curMatch.MatchName.Remove((_curMatch.MatchName.Length - 4), 4);
            
            //If file not empty, read current match data
            if (!CheckFileEmpty(@"..\..\stats\" + _curMatch.MatchName + ".txt"))
            {
                ReadStatsFromFile(@"..\..\stats\" + _curMatch.MatchName + ".txt", _curMatch);
            }
        }

        public void WriteCurrentMatchStatsToFile()
        {
            using (StreamWriter output = new StreamWriter(@"..\..\stats\" + _curMatch.MatchName + ".txt", false))
            {
                output.WriteLine(_curMatch.MatchName);
                output.WriteLine(_curMatch.ServeAttempts);
                output.WriteLine(_curMatch.ServeAces);
                output.WriteLine(_curMatch.ServeErrors);
                output.WriteLine(_curMatch.AttackAttempts);
                output.WriteLine(_curMatch.AttackKills);
                output.WriteLine(_curMatch.AttackErrors);
                output.WriteLine(_curMatch.SetAttempts);
                output.WriteLine(_curMatch.SetAssists);
                output.WriteLine(_curMatch.SetErrors);
                output.WriteLine(_curMatch.DigAttempts);
                output.WriteLine(_curMatch.DigErrors);
                output.WriteLine(_curMatch.BlockSolos);
                output.WriteLine(_curMatch.BlockAssists);
                output.WriteLine(_curMatch.BlockErrors);

                foreach (int score in _curMatch.GetReceiveScores())
                {
                    output.WriteLine(score);
                }
            }
        }

        public void ReadStatsFromFile(string filePath, Match match)
        {
            using (StreamReader input = new StreamReader(filePath))
            {
                match.MatchName = input.ReadLine();
                match.ServeAttempts = Convert.ToInt32(input.ReadLine());
                match.ServeAces = Convert.ToInt32(input.ReadLine());
                match.ServeErrors = Convert.ToInt32(input.ReadLine());
                match.AttackAttempts = Convert.ToInt32(input.ReadLine());
                match.AttackKills = Convert.ToInt32(input.ReadLine());
                match.AttackErrors = Convert.ToInt32(input.ReadLine());
                match.SetAttempts = Convert.ToInt32(input.ReadLine());
                match.SetAssists = Convert.ToInt32(input.ReadLine());
                match.SetErrors = Convert.ToInt32(input.ReadLine());
                match.DigAttempts = Convert.ToInt32(input.ReadLine());
                match.DigErrors = Convert.ToInt32(input.ReadLine());
                match.BlockSolos = Convert.ToInt32(input.ReadLine());
                match.BlockAssists = Convert.ToInt32(input.ReadLine());
                match.BlockErrors = Convert.ToInt32(input.ReadLine());

                match.GetReceiveScores().Clear();
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    match.EditReceiveScores(Convert.ToInt32(line));
                }
            }
        }

        public void ReadStatsFromAllFiles()
        {
            DirectoryInfo statsDir = new DirectoryInfo(@"..\..\stats");
            FileInfo[] statsFiles = statsDir.GetFiles();
            int pastMatchesCount = 0;
            _pastMatches.Clear();

            foreach (FileInfo file in statsFiles)
            {
                //only load stats from past matches
                if (file.Name != (_curMatch.MatchName + ".txt"))
                {
                    string fileWithoutExt = file.Name.Remove((file.Name.Length - 4), 4);
                    _pastMatches.Add(new Match(fileWithoutExt));

                    if (!CheckFileEmpty(@"..\..\stats\" + file.Name))
                    {
                        ReadStatsFromFile(@"..\..\stats\" + file.Name, _pastMatches[pastMatchesCount]);
                    }

                    pastMatchesCount++;
                }
            }
        }
    }
}