using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Converter assuming a base with 2 &lt;= index &lt;= 36 and the chars "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    /// </summary>
    public class BaseNByIndex : BaseNConverter
    {
        protected static string BASE_ALPHABET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public BaseNByIndex(int index) : base(BASE_ALPHABET.Substring(0, (index >= 2 && index <= BASE_ALPHABET.Length) ? index : 0)) 
        {
        }

        protected override int ResolveCharToIndex(char c)
        {
            c = Char.ToUpper(c);
            return base.ResolveCharToIndex(c);
        }

    }
}
