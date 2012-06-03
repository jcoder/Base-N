using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Hexadecimal base converter
    /// </summary>
    public class Base16 : BaseNConverter
    {
        public const string ALPHABET = "0123456789ABCDEF";

        public Base16()
            : base(ALPHABET)
        {
        }

        protected override int ResolveCharToIndex(char c)
        {
            c = Char.ToUpper(c);
            return base.ResolveCharToIndex(c);
        }

    }
}
