using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

//namespaces é a mesma ideia dos packages
namespace StatistCalc.src.models {

   public class Tabela{
     //aqui vai ficar a criação da tabela, fazendo listas dos dados
  private List<Simples> tabela = new List<Simples>();

    public List<Simples> TabelaG
    {
        get { return tabela; }
    }
    //talvez receber um Simples//
    public void AddTabela(double x, int freqAbs)
    {
        tabela.Add(new Simples(x, freqAbs));
    }
    private double SigmaS(){ //TODO:colocar uma string como parâmetro para testar o tipo de sigma para calcular, tipo: de x, fx, m ou fm
    //USAR O ENUM AQUI?
    double soma = 0;
    foreach(var item in tabela){
        soma += item.CalculoX();
    }
    return soma;
  }
  public double FreqAcumulada(){
    return 0;
  } 
public void ExibirTabela(){
    Console.WriteLine("           x | f  | f(x)                       ");

foreach (var item in tabela){
    
    Console.WriteLine($"         {item.CalculoX()} | {item.FrequenciaAbs}  | {item.FX()}     ");
}
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("          Σ |                                    ");
    Console.WriteLine($"         {SigmaS()}                                     ");


}
 }
}