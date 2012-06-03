using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Decimal base converter
    /// </summary>
    public class Base10 : BaseNConverter
    {
        public const string ALPHABET = "0123456789";

        public Base10()
            : base(ALPHABET)
        {
        }

    }
}
