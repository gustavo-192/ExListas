using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExListasOBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e depois os dados(id,nome e salario) de
             N funcionários. Não deve haver repetição de id.
            
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma 
            mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada.*/

            Console.WriteLine("How many amployees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());


            Employees emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porc);
            }
            else
            {
                Console.WriteLine("This id does not exist! ");
            }
            foreach (Employees obj in list)
            {
                Console.WriteLine(obj.ToString());
            }


            



           



        }

    }
}
