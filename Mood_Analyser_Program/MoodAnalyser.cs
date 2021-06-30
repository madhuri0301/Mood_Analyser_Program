using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Program
{
    public class MoodAnalyser
    {
        //variable
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Checking mood : If Sad Return SAD,
        /// If Happy Return HAPPY.
        /// </summary>
        /// <param name="mesaage"></param>
        /// <returns></returns>
        public string AnalyseMood(string mesaage)
        {
            try
            {
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                //Returning Happy when case of Null exception
                return "HAPPY";
            }
        }
    }
}
