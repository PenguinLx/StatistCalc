using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatistCalc.src.models {
    
public class IntervaloClasse {
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
}