using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12082021
{
    class Colecciones
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            EmployeeList.Add("Jose Flores", "Programador");
            EmployeeList.Add("Miranda Campos", "Gerente");
            EmployeeList.Add("Carmen Valladares", "Arquitecta");

            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Jose Flores", 22);
            Students.Add("Miranda Campos", 20);
            Students.Add("Carmen Valladares", 25);

            foreach (KeyValuePair<string, string> employee in EmployeeList)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

            Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList);

            Console.ReadKey();
        }
    }
}
