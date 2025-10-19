using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryapp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("table is created");

            Table table = new Table();
            Console.Write("please enter a number: ");
            string strNum = Console.ReadLine();
           
            table.Number = int.Parse(strNum);


            Console.Write("please enter a range: ");
            strNum = Console.ReadLine();
            table.Range = int.Parse(strNum);
            //table.SetRange(Int32.Parse(strNum));
            Console.WriteLine(" value of range:={0}", table.Range);
            table.PrintTable();
            Console.ReadKey();
            
            


        


        }
    }


}
 