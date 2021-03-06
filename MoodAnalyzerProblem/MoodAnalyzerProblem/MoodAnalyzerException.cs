using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
   public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType 
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        ExceptionType type;
        public MoodAnalyzerException(ExceptionType type, string messege) : base(messege)
        {
            this.type = type;
        }
    }
}