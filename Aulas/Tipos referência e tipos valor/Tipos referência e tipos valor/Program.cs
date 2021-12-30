using System;

namespace Tipos_referência_e_tipos_valor {

    internal class Program {

        private static void Main(string[] args) {
            Point p; // STRUCT
            p.X = 10; // MESMO SENDO UM TIPO STRUCT EU TENHO QUE INICIALIZAR
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
