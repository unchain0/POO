using System.Globalization;

namespace _60._Exercício_de_fixação {

    internal class ContaBancaria {

        public int Numero { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "\nConta " + Numero +
                ", Titular: " + Titular +
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
