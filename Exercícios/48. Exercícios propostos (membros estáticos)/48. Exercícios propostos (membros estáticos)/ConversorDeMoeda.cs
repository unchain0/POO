namespace _48._Exercícios_propostos__membros_estáticos_ {

    internal class ConversorDeMoeda {
        public double Cotacao;
        public double Dolar;

        public double Conversor() {
            return Dolar * Cotacao * 0.06 + Dolar * Cotacao;
        }
    }
}
