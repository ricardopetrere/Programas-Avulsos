using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //o tipo do retorno do delegate deve coincidir com o tipo do retorno do método usado na construção do objeto delegate
    delegate void MyDelegate(String texto);
    
    //o(s) tipo do parâmetro passado no delegate deve coincidir com o(s) tipo do parâmetro passado no método usado
    //o parâmetro passado na assinatura do delegate será passado no objeto delegate
    public delegate int MyDelegate2(String a);
    class Program
    {
        static void MandaA(String texto)
        {
            Console.WriteLine("A: " + texto);
        }
        static void MandaB(String texto)
        {
            Console.WriteLine("B: " + texto);
        }
        static void Main(string[] args)
        {
            MyDelegate a, b, c, d;

            //é possível construir um delegate com new delegate(<método>)
            a = new MyDelegate(MandaA);

            //é possível construir um delegate apenas com o nome do método
            b = MandaB;

            //é possível construir um delegate com método anônimo (método criado "na hora")
            MyDelegate2 d1 = delegate(String dado)
            {
                return Convert.ToInt32(dado) * 2;
            };

            //constrói c com as duas chamadas, tornando c delegate composto de a e b (executando ambos os métodos associados à estes delegates
            c = a + b;

            //d = a - b retorna a, pois b não está contido em a, não tendo o que remover
            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("Texto 1");
            Console.WriteLine("Invoking delegate b:");
            b("Texto 2");
            Console.WriteLine("Invoking delegate c:");
            c("Texto 3");
            Console.WriteLine("Invoking delegate d:");
            d("Texto 4");

            Console.WriteLine(d1("7"));

            Console.ReadLine();
        }
    }
}
