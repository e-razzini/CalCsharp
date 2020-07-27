using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_Com_Obj.Classes
{
    class Operador
    {

        public double Somar(double nu1, double nu2)
        {
            double r;
            r = nu1 + nu2;
            return r;
        } public double Subtracao(double nu1, double nu2)
        {
            double r;
            r = nu1 - nu2;
            return r;
        } public double Divisao(double nu1, double nu2)
        {
            double r;
            r = nu1 / nu2;
            return r;
        } public double Multiplicar(double nu1, double nu2)
        {
            double r;
            r = nu1 * nu2;
            return r;
        }


    }
}
