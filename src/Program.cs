using System;
using StatistCalc.src.models;
 namespace Main
 {
  class Program
  {
    static void Main(string[] args)
    {
      //SÓ TESTES POR ENQUANTO
              //SIMPLES//
      Simples simples = new Simples(19, 20);
      Console.WriteLine("Hello");
      double x = simples.X = 91;
      int f = simples.FreqAbs = 92;
      double x2 = simples.X = 56;
      int f2 = simples.FreqAbs = 10;
      double x3 = simples.X = 20;
    Console.WriteLine("fx: " + simples.FX());
    Tabela tabela= new Tabela();
    
    tabela.AddTabela(x,f);
    tabela.AddTabela(x2,f2);
    tabela.AddTabela(x3,0);
    tabela.ExibirTabela();
    //Console.WriteLine("Sigma: " + tabela.SigmaS());

              //INTERVALO//
    // IntervaloClasse intervaloClasse= new IntervaloClasse();
    // intervaloClasse.Linf = 60;
    // intervaloClasse.Lsup = 70;
    // Console.WriteLine("Linf: " + intervaloClasse.XInterv[0] + "\nLsup: " + intervaloClasse.XInterv[1]);

    }
  }
}