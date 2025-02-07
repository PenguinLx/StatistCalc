using System;
using System.Collections.Generic;
using System.Xml;   

namespace CalculadoraEstatistica {


    public abstract class CalculosEstatisticos{
        public abstract void FX(); /* calculo fx*/
        public abstract void FreqAcumulada(); /* calculo frequencia acumulada*/
        public abstract void MediaCalc(); /* calculo media*/
        public abstract String VisualizarTabela();
    }
public class Simples: CalculosEstatisticos {
   // private List<Simples> tabela = new List<Simples>();
    
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

public override void FX(){

}

public override void FreqAcumulada(){

}
public override void MediaCalc(){

}
// public void AddTabela(double x, int freqAbs){
// tabela.Add(new Simples(x,freqAbs));
// }
    


public override String VisualizarTabela(){
    return "";
}


}

public class IntervaloClasse{
    private double linf;
    private double lsup;
private double[] x = new double[2]; /*aqui vai dois números(limite inferior e superior)*/
private double freqAbs;
private double freqAbsX;
private double media;
public double Linf{
    get{return linf;}
    set{linf = value;
    AtualizarXInterv();
    }
}
public double Lsup{
    get{return lsup;}
    set{lsup = value;
    AtualizarXInterv();
    }
}
public double[] XInterv{
    get{return x;}
}

 private void AtualizarXInterv()
    {
        x[0] = linf;
        x[1] = lsup;
    }
}


 public class Tabela{
     //aqui vai ficar a criação da tabela, fazendo listas dos dados
  private List<Simples> tabela = new List<Simples>(); // Inicializa a lista corretamente

    public List<Simples> TabelaG
    {
        get { return tabela; }
    }

    public void AddTabela(double x, int freqAbs)
    {
        tabela.Add(new Simples(x, freqAbs));
    }
public void ExibirTabela(){
    Console.WriteLine("           x | f                         ");
foreach (var item in tabela){
    
    Console.WriteLine($"          {item.X} | {item.FreqAbs}     ");
}
}
 }
 }
