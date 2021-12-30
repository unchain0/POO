using System;
using System.Globalization;

namespace _45._Exercícios_propostos__classes__atributos_e_métodos_ {

    internal class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) return true;
            else return false;
        }

        public void Reprovado() {
            Console.WriteLine("REPROVADO\nFALTARAM {0} PONTOS", NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
        }

        public double NotaRestante() {
            return 60.0 - NotaFinal();
        }
    }
}
