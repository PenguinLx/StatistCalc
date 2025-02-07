using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatistCalc.src.models {

   public class Simples: CalculosEstatisticos {
   // private List<Simples> tabela = new List<Simples>();
    private List<Simples> variableList = new List<Simples>();
private double x;
private int freqAbs;
//private double freqAbsX;
//private double media;
public Simples(double x, int freqAbs){
    this.x = x;
    this.freqAbs = freqAbs;
}
public double X{
    get{return x;}
    set{x = value;}
}
public int FreqAbs{
    get{return freqAbs;}
    set{freqAbs = value;}
}

public override double FX(){
    return FreqAbs * X; 
}

public override void FreqAcumulada(){

}
public override void MediaCalc(){

}
// public void AddTabela(double x, int freqAbs){
// tabela.Add(new Simples(x,freqAbs));
// }
}

}
