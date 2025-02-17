using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatistCalc.src.models {

   public class Simples: CalculosEstatisticos {

    TipoCalc tipo = TipoCalc.SIMPLES;
    public TipoCalc tipoCalc{ get;}
private double x;
private int freqAbs;
//private double freqAbsX;
//private double media;
internal protected Simples(double x, int freqAbs){
    this.x = x;
    this.freqAbs = freqAbs;
}
    // public void setX(double x){
    //     this.x = x;
    // }

        public override double CalculoX() => x;
        // public override int FrequenciaAbs{
        //     get{return freqAbs;}
        //     set{freqAbs = value;}
        // }
public override double CalculoXVezesFrequencia(){
    return FrequenciaAbs * CalculoX(); 
}

// public override void FreqAcumulada(){

// }
/*
    x̅ = Σf(x)/Σf;
*/
public override double MediaCalc(double sigmaFx,double sigmaFreqAbs){

    return sigmaFx / sigmaFreqAbs;

}
// public void AddTabela(double x, int freqAbs){
// tabela.Add(new Simples(x,freqAbs));
// }
}

}
