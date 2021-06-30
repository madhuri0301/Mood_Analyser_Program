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
        /// <summary>
        /// if there is any other mood it will return happy
        /// if there is empty mood it will also return happy
        /// beacuse mood should be null or empty
        /// </summary>
        /// <returns></returns>
        public string AnalyseMoodLive()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MACustomException(MACustomException.ExceptionType.EMPTY_MESSAGE, "mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MACustomException(MACustomException.ExceptionType.NULL_MESSAGE, "mood should not be null");
            }
        }
    }
}
