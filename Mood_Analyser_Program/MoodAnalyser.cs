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
        public string AnalyseMood()
        {
            try
            {
                if(this.message==null || message==string.Empty)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE);
                }


                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
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
        //public string AnalyseMoodLive()
        //{
        //    try
        //    {
        //        if (this.message.Equals(string.Empty))
        //        {
        //            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "mood should not be empty");
        //        }
        //        if (this.message.Contains("sad"))
        //            return "SAD";
        //        else
        //            return "HAPPY";
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "mood should not be null");
        //    }
        //}
    }
}
