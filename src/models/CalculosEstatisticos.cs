using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatistCalc.src.models {

    public abstract class CalculosEstatisticos
    {
        //tornar essa classe a mãe de Simples e IntervaloClasse, aqui terá o x(abstrato) e o freqabs(não abstrato, pois os dois podem implementar da mesma forma), as classes filhas vão herdar tudo, assim posso economizar algumas linhas de código//
        //NÃO TENHO CERTEZA SE VOU MANTER O X E O FrequenciaAbs AQUI
        public abstract double CalculoX();
        //public abstract double X {get{return x;}}
        public int FrequenciaAbs{get;}
        //  public abstract double FX(); /* calculo fx*/
         //public abstract double Sigma(Tabela tabela);
        // public abstract void FreqAcumulada(); /* calculo frequencia acumulada*/
        public abstract double MediaCalc(double a,double b); /* calculo media*/
        public abstract double CalculoXVezesFrequencia();
    }
}