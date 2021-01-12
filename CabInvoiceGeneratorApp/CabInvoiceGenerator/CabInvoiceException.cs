using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorApp.CabInvoiceGenerator
{
    public class CabInvoiceException   :Exception
    {
        public enum ExceptionType
        {
            INVALID_USER_ID,
        }

        public ExceptionType exceptionType;

        public CabInvoiceException(string message, ExceptionType exceptionType)
            : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
