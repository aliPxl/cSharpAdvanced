using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    internal class Bankrekening
    {
        public int HuidigSaldo { get; set; }
        public Bankrekening(int bedrag)
        {
            HuidigSaldo = bedrag;
        }
        public void Opname()
        {

        }

        public void Storting()
        {

        }
    }
}
