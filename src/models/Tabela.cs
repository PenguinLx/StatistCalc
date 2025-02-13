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
        tabela.Add(new Simples(x,freqAbs));
    }
    public double Sigma(SigmaTipo tipo){ //TODO:colocar uma string como parâmetro para testar o tipo de sigma para calcular, tipo: de x, fx, m ou fm
    //USAR O ENUM AQUI?
    
    double soma = 0;

    foreach(var item in tabela){

    switch (tipo)
    {
        case SigmaTipo.XM:
        soma += item.CalculoX();
        break;

        case SigmaTipo.F:
        soma += item.FrequenciaAbs;
        break;

        case SigmaTipo.FXM:
        soma += item.CalculoXVezesFrequencia();
        break;

        default:
        throw new ArithmeticException("Algo deu errado com o cálculo!");
    }
    }
    return soma;
   
  }
  public double FreqAcumulada(){
    throw new NotImplementedException();
  } 
public void ExibirTabela(TipoCalc tipo){
    string c;
    
    if(tipo == TipoCalc.SIMPLES){
        c = "f(x)";
    }
    else{
        c = "fm(x)";
    }
    Console.WriteLine($"          x | f  | {c}                        ");

foreach (var item in tabela){
    
    Console.WriteLine($"         {item.CalculoX()} | {item.FrequenciaAbs}  | {item.CalculoXVezesFrequencia()}     ");
}
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("          Σ |                                    ");
    Console.WriteLine($"         {Sigma(SigmaTipo.XM)}                                     ");


}
 }
}