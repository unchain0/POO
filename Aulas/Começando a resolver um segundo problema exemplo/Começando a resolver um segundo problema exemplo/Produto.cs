using System.Globalization;

namespace Começando_a_resolver_um_segundo_problema_exemplo {

    internal class Produto {
        private string _nome;
        public double Preço { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        // public Produto() { }
        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preço) : this() {
            _nome = nome;
            Preço = preço;
        } // Construtor com 2 argumentos

        public Produto(string nome, double preço, int quantidade) : this(nome, preço) {
            Quantidade = quantidade;
        } // Referenciar outro construtor em um construtor

        public double ValorTotalEmEstoque() {
            double total = Preço * Quantidade;
            return total;
        } // Multiplicar o Preço pela Quantidade

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        } // Buscar a Quantidade e adicionar x

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        } // Buscar a Quantidade e remover x

        public override string ToString() {
            return $"{_nome}, " +
                $"$ {Preço.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        } // Serve p/ evitar repetições
    }
}
