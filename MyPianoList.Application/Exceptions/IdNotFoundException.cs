using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Exceptions
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException() : base() { }

        public IdNotFoundException(string message) : base(message) { }

        public IdNotFoundException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}