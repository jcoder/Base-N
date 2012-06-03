using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// Easy access to some predefined converters
    /// </summary>
    public class BaseNPredefined
    {
        private static BaseNConverter binary = new Base2();
        private static BaseNConverter octal = new Base8();
        private static BaseNConverter dec = new Base10();
        private static BaseNConverter hexadec = new Base16();
        private static BaseNConverter sixty = new Base60();

        private BaseNPredefined() { }

        /// <summary>
        /// Gets a binary converter
        /// </summary>
        public static BaseNConverter Binary
        {
            get
            {
                return binary;
            }
        }

        /// <summary>
        /// Gets an octal converter
        /// </summary>
        public static BaseNConverter Octal
        {
            get
            {
                return octal;
            }
        }

        /// <summary>
        /// Gets a decimal converter
        /// </summary>
        public static BaseNConverter Dec
        {
            get
            {
                return dec;
            }
        }

        /// <summary>
        /// Gets a hexadecimal converter
        /// </summary>
        public static BaseNConverter Hexadec
        {
            get
            {
                return hexadec;
            }
        }

        /// <summary>
        /// Gets a NewBase60 converter, see http://tantek.pbworks.com/w/page/19402946/NewBase60
        /// </summary>
        public static BaseNConverter Sixty
        {
            get
            {
                return sixty;
            }
        }

    }
}
