using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequenciaMedica
{
    public class DtoFuncionario
    {

        public int NUMCRA { get; set; }//1
        public int NUMCAD { get; set; }//2
        public int TIPCOL { get; set; }//3
        public string NOMFUN { get; set; }//4
        public int NUMEMP { get; set; }//5
        public int CODESC { get; set; }//6
        public int SITAFA { get; set; }//7
        public string EMPTOTVS { get; set;}
        public long NUMCPF { get; set; }
        public string DATBLO { get; set; }
        public string DESMOT { get; set; }

    }
}
