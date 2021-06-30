using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Program
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public MoodAnalysisException(ExceptionType Type) 
        {
            if (Type == ExceptionType.NULL_MESSAGE)    
            {
                Console.WriteLine(Type +"Message Can't Be Null");
            }
            if (Type == ExceptionType.NO_SUCH_CLASS)
            {
                Console.WriteLine(Type + "No such class present");
            }
            if (Type == ExceptionType.EMPTY_MESSAGE)
            {
                Console.WriteLine(Type + "empty message");
            }
        }
    }
}
