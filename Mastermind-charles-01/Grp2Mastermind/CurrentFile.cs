using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Grp2Mastermind
{
    public class CurrentFile
    {
        private string currentFilePath;
        private StreamReader currentFileSR; //reference variable for StreamReader type
        private int recordReadCount;
        //create instance of StreamReader type and store reference value
        public CurrentFile(string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;

            try
            {
                currentFileSR = new StreamReader(currentFilePath);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + currentFilePath + "Terminate Program.", "Ouput File Connection Error.",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //read record from file
        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            string nextRecord;
            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
                recordReadCount += 1;

            return (nextRecord);
        }
        //get number of records read in file
        public int getRecordReadCount()
        {
            return recordReadCount;
        }
        //close input file
        public void closeFile()
        {
            currentFileSR.Close();
        }
        //rewind input file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }
    }
}

