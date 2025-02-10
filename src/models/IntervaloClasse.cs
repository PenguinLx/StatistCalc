using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace StatistCalc.src.models {
    
public class IntervaloClasse: CalculosEstatisticos {
     TipoCalc tipo = TipoCalc.INTERVALO;
    public IntervaloClasse() {
       
    }
// private double x;
private double linf;
private double lsup;
private double[] intervalo = new double[2]; /*aqui vai dois números(limite inferior e superior)*/
//  public double X {
//     get{return MediaIntervalo();}
//     //set{x = value;}
//  }
private double freqAbs;
private double mediaX;
public double Linf{
    get{return linf;}
    set{linf = value;
    atualizarInterv();
    }
}
public double Lsup{
    get{return lsup;}
    set{lsup = value;
    atualizarInterv();
    }
}
 public double[] Interv{
     get{return intervalo;}
 }
 
 private void atualizarInterv()
    {
        intervalo[0] = linf;
        intervalo[1] = lsup;
    }
    
   
// public override void FreqAcumulada(){

// }
/*
   TODO: x̅ = Σfm/Σf;
*/
public override double MediaCalc(double sigmafreqM, double sigmafreqAbs){
    return 0;
}
// public double MediaIntervalo(){
    
//     return (Linf + Lsup) / 2;
// }
 public override double CalculoX() => (Linf + Lsup) / 2;
public double MX(){
    return FrequenciaAbs * CalculoX();
}
public string showIntervalo(){
    return $"{Linf} |- {Lsup}";
}
}}