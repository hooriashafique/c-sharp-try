using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryapp
{
    internal class Table
    {
        public int Number;
        private int range;
        public int Range
        {
            get
            {
                return range;
            }

            set
            {
                if (value >= 0)
                {
                    range = value;
                }
                else { range = 0; }
            }
        }
    

        public Table()
        {
            Number = 0;
            Range = 10; 
        }
        public Table(int number,int range)
        {
            Number = number;
            Range = range;
        }
        public void PrintTable()
        {
            for(int i=1;i<=Range;i++)
            {
                Console.WriteLine("{0}x{1}={2}",Number,i,Number*i);
                

            }
        }


    }
}
