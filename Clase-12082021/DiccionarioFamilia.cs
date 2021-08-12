using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12082021
{
    class DiccionarioFamilia
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Familia = new Dictionary<string, int>();
            Familia.Add("René Eduardo Fuentes Treminio", 45);
            Familia.Add("Flor de Maria Benítez de Fuentes",43);
            Familia.Add("Eduardo Ernesto Fuentes Benítez", 20);
            Familia.Add("René Ismael Fuentes Benítez", 18);

            //leer el diccionario y mostrar los datos
            foreach (KeyValuePair<string, int> familia in Familia)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", familia.Key, familia.Value);
            }

            //ordenar elementos del diccionario
            var dic = Familia.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Diccionario ordenado");
            foreach (var item in dic)
            {
               Console.WriteLine("{0}: {1}", item, Familia[item]);
            }
            Console.WriteLine("Elementos en el diccionario: {0}", Familia.Count);

            Console.ReadKey();
        }


        
    }
}
