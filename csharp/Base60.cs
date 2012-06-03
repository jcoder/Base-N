using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseN
{
    /// <summary>
    /// NewBase60 base converter, see http://tantek.pbworks.com/w/page/19402946/NewBase60
    /// </summary>
    public class Base60 : BaseNConverter
    {
        public const string ALPHABET = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ_abcdefghijkmnopqrstuvwxyz";

        public Base60()
            : base(ALPHABET)
        {
        }

    }
}
