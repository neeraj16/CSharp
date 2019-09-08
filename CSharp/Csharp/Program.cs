using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            RegularExpression re = new RegularExpression();

            do
            {
                Console.Write("Enter Phone Number: ");
                string pn = Console.ReadLine();
                bool b = re.IsValidPhoneNumber(pn);
                Console.WriteLine(b);
                Console.WriteLine("Do you want to continue(Y/N): ");

            }
            while (Console.ReadLine() == "Y");
            
        }
    }
}
