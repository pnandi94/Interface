using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IJatekos
    {
        void Nyert();
        void Veszitett();
        int NyertDB { get; }
        int VeszitettDB { get; }
    }
}
