using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Octal base converter
    /// </summary>
    public class Base8 : BaseNConverter
    {
        public const string ALPHABET = "01234567";

        public Base8()
            : base(ALPHABET)
        {
        }

    }
}
