using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoMembrosEstaticos {
    internal class ConversorDeMoedas {

       public static double ValorEmReais(double Cotacao, double QuantidadeDolares) {
            return Cotacao * (QuantidadeDolares * 1.06);
        }
    }
}
