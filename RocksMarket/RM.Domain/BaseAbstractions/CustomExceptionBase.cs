using System;

namespace RM.Domain.BaseAbstractions
{
    public abstract class CustomExceptionBase: Exception
    {
        public CustomExceptionBase(string errorCode)
            : base(errorCode)
        {
            ErrorCode = errorCode;
        }
        
        public CustomExceptionBase(string errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public string ErrorCode { get; }
    }
}