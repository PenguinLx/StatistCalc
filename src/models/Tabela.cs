using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

//namespaces é a mesma ideia dos packages
namespace StatistCalc.src.models {

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
    private double SigmaS(){
    double soma = 0;
    foreach(var item in tabela){
        soma += item.X;
    }
    return soma;
  } 
public void ExibirTabela(){
    Console.WriteLine("           x | f  | f(x)                       ");

foreach (var item in tabela){
    
    Console.WriteLine($"          {item.X} | {item.FreqAbs}  | {item.FX()}     ");
}
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("          Σ |                                    ");
    Console.WriteLine($"         {SigmaS()}                                     ");


}
 }
}