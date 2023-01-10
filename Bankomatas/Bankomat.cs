using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    public class Bankomat
    {
public string PAN { get; set; }
       public static void addCard()
        {
            List<string> listPans = new List<string>();
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine("Įvesk PAN");
                Banque.PAN = Console.ReadLine();
                listPans.Add(Banque.PAN);
            }
            foreach (string pan in listPans)
            {
                Console.WriteLine($"{pan}");
            }
        }
    }
}
