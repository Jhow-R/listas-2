using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Add(): adiciona novo item no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Beatriz");
            list.Add("Ana");
            list.Add("Matheus");
            list.Add("Jorge");
            list.Add("Leonardo");
            list.Add("Aline");

            // Insert(): adiciona novo item conforme índice especificado
            list.Insert(2, "Marco");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Count: número de elementos na lista
            Console.WriteLine(list.Count);

            string s1;

            // Find(): encontra primeiro elemento na lista conforme um predicado, recebe um Predicate que é um ponteiro para um método que retorna true ou false conforme lógica implementada
            Predicate<string> predicate = new Predicate<string>(Test);
            s1 = list.Find(predicate);
            // Ou 
            s1 = list.Find(Test);
            // Ou
            s1 = list.Find(x => x[0] == 'A');

            Console.WriteLine("First A: " + s1);

            // FindLast(): encontra último elemento na lista conforme predicado
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            // FindLast(): encontra primeiro índice de um elemento na lista conforme predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position A: " + pos1);

            // FindLast(): encontra último índice de um elemento na lista conforme predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position A: " + pos2);

            //FindAll(): filtra a lista conforme predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            // Remove(): remove a primeira ocorrência de um elemento na lista
            bool retorno = list.Remove("Alex");
            Console.WriteLine("Alex removido: " + retorno);

            // RemoveAll(): remove todos elementos da lista conforme predicado
            int resultado = list.RemoveAll(x => x.StartsWith("M"));
            Console.WriteLine("Quantidade de remoções: "+ resultado);

            Console.WriteLine("Lista atualizada");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // RemoveAt(): remove elemento conforme índice especificado
            list.RemoveAt(1);
            Console.WriteLine("Alex removido: " + retorno);

            // RemoveRange(): remove elementos a partir de um índice até uma contagem especificada
            list.RemoveRange(1, 3);

            Console.WriteLine("Lista atualizada");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
