using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Mastermind
{
    class PlayerClass
    {
        string playerName;
        int playerScore;
        //string playerLevel;

        // constructor
        public PlayerClass()
        {
            playerName = "";
            playerScore = 0;
            //playerLevel = "";
        }

        // getter and setter for playername
        public string Name
        {
            get { return playerName; }
            set { playerName = value; }
        }

        // getter and setter for playerScore
        public int Score
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        // splits the text file
        // **need to create a textfile**

        public void SplitLine(string line)
        {            
            string[] info = line.Split('*');
            playerName = info[0];
            playerScore = int.Parse(info[1]);
        }

    }
}
