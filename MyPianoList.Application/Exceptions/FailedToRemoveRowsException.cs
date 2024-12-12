using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Exceptions
{
    public class FailedToRemoveRowsException : Exception
    {
        public FailedToRemoveRowsException() : base() { }

        public FailedToRemoveRowsException(string message) : base(message) { }

        public FailedToRemoveRowsException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}