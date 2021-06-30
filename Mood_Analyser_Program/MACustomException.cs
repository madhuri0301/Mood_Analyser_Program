using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Program
{
    public class MACustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
        }
        private readonly ExceptionType type;
        public MACustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
