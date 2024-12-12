using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Exceptions
{
    public class NoRowsReturnedException : Exception
    {
        public NoRowsReturnedException() : base() { }

        public NoRowsReturnedException(string message) : base(message) { }

        public NoRowsReturnedException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}