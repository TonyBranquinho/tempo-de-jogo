using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_de_jogo {
    class Program {
        static void Main(string[] args) {

            int HInicial, HFinal, duracao, parcial;

            Console.Write("Hora Inicial: ");
            HInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            HFinal = int.Parse(Console.ReadLine());

            if (HInicial > HFinal) {
                parcial = 24 - HInicial;
                duracao = parcial + HFinal;            
            }
            else if (HInicial < HFinal) {
                duracao = HFinal - HInicial;
            }
            else {
                duracao = 24;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");

        }
    }
}
