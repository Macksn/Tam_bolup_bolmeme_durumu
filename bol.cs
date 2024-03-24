using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASS_BOL_
{
    class bol
    {
        public int sayı , bölen ;
        public string sonuc ;
        public string bul()
        {
            if (sayı % bölen == 0)
                sonuc = "tam böler";
            else
                sonuc = "tam bölmez";
            return sonuc;
        }

    }
}
