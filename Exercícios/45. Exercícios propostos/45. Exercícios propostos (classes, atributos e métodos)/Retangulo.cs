using System;

namespace _45._Exercícios_propostos__classes__atributos_e_métodos_ {

    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
