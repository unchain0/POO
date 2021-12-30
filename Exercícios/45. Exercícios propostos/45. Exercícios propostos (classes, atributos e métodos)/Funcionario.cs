namespace _45._Exercícios_propostos__classes__atributos_e_métodos_ {

    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = (SalarioBruto * (porcentagem / 100)) + SalarioBruto;
        }
    }
}
