using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Binary base converter
    /// </summary>
    public class Base2 : BaseNConverter
    {
        public const string ALPHABET = "01";

        public Base2()
            : base(ALPHABET)
        {
        }

    }
}
