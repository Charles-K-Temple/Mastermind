using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Mastermind
{

        public class GlobalData
        {            
            private static string currentFilePath = "customerList.txt";


            //classes
            //public static PlayerClass newPlayer = new PlayerClass(); // figure out error
            public static CurrentFile newCurrentFile = new CurrentFile(currentFilePath);
        }
    }