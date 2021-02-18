using System;

namespace Parcial_1_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] caja = { 18, 19, 23, 50 };
            int[] valores = { 1000, 500, 200, 100 };
            int b1 = 0, b2 = 0, b3 = 0, b4 = 0, rt, retiro, cajero;

            for (int i = 0; i < 20; i++) {

                Console.Write("\nFavor ingresar valor de retiro: ");
                retiro = int.Parse(Console.ReadLine());
                rt = retiro;
                b1 = (retiro / 1000);

                if (retiro - (b1 * valores[0])  >= 10000 & retiro - (b1 * valores[0]) <= 20000) {};
                b2 = (retiro / 1000);
                if (retiro - (b2 * valores[1]) >= 10000 & retiro - (b2 * valores[1]) <= 20000) { };
                b3 = (retiro / 500);
                if (retiro - (b3 * valores[2]) >= 10000 & retiro - (b3 * valores[2]) <= 20000) { };
                b4 = (retiro / 200);
                if (retiro - (b4 * valores[3]) >= 10000 & retiro - (b3 * valores[3]) <= 20000) { };

                if ((rt % 100) == 0)
                {
                    cajero = caja[18] * valores[0] + caja[19] * valores[1] + caja[23] * valores[2] + caja[50] * valores[3];
                    if (cajero >= retiro)
                    {
                        caja[18] = caja[18] - b1;
                        caja[19] = caja[19] - b2;
                        caja[23] = caja[23] - b3;
                        caja[50] = caja[50] - b4;
                        Console.Write("Retiro exitoso");

                    }else 
                        Console.Write("\nSin efectivo en el cajero para esta transaccion ");

                }else 
                    Console.Write("\nFavor ingresar una cantidad rendodeada en billetes de 1000, 500, 200, 100");

            }
            Console.Write("\n\nBilletes en cajero: \n1000: " + (caja[18]) + "\n500: " + (caja[19]) + "\n200: " + (caja[23]) + "\n100: " + (caja[50]));

            Console.ReadKey();

        }
    }
}

