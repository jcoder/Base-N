using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Converting a value to a different base
    /// </summary>
    public class BaseNConverter
    {
        protected string alphabetChars = "";
        protected int baseValue = 0;

        /// <summary>
        /// Creates a new converter, using a given string as alphabet for values, e.g. "01" for binary or "0123456789ABCDEF" for hexadecimal
        /// </summary>
        /// <param name="alphabet">alphabet</param>
        public BaseNConverter(string alphabet)
        {
            if (string.IsNullOrEmpty(alphabet) == false)
            {
                this.alphabetChars = alphabet;
                this.baseValue = this.alphabetChars.Length;
            }
        }

        /// <summary>
        /// Converts the long value to chars, e.g. "23231" to "5ABF" in Hexadecimal
        /// </summary>
        /// <param name="l">positive long value</param>
        /// <returns>char representation in base, empty on error</returns>
        public virtual string ToChars(long l)
        {
            if (l < 0)
            {
                return "";
            }
            if (this.baseValue < 2)
            {
                return "";
            }
            StringBuilder buffer = new StringBuilder();
            while (l > 0) {
                int index = (int)(l % this.baseValue);
                char c = this.ResolveIndexToChar(index);
                buffer.Insert(0, c);
                l = (l - index) / this.baseValue;
            }

            if (buffer.Length == 0)
            {
                buffer.Append(this.ResolveIndexToChar(0));
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Converts the string in char representation to long value, e.g. "23B" to "571" in Hexadecmial
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>long value, -1 on error</returns>
        public virtual long ToLong(string s)
        {
            if (string.IsNullOrEmpty(s) == true)
            {
                return -1;
            }
            long sum = 0;
            long multiplier = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                int index = this.ResolveCharToIndex(c);
                if (index < 0)
                {
                    return -1;
                }
                sum = sum + multiplier * index;
                if (sum < 0)
                {
                    return -1;
                }
                multiplier = multiplier * this.baseValue;
            }
            return sum;
        }

        /// <summary>
        /// Resolves the index to char
        /// </summary>
        /// <param name="index">index to resolve</param>
        /// <returns>char</returns>
        protected virtual char ResolveIndexToChar(int index)
        {
            return this.alphabetChars[index];
        }

        /// <summary>
        /// Resolves char to index, returning -1 if invalid
        /// </summary>
        /// <param name="c">char to resolve</param>
        /// <returns>index position, -1 if invalid</returns>
        protected virtual int ResolveCharToIndex(char c)
        {
            return this.alphabetChars.IndexOf(c);
        }

        /// <summary>
        /// Returns the base value of this converter
        /// </summary>
        public virtual int Base
        {
            get
            {
                return this.baseValue;
            }
        }

        /// <summary>
        /// Returns the alphabet of this converter
        /// </summary>
        public virtual string Alphabet
        {
            get
            {
                return this.alphabetChars;
            }
        }

    }
}
