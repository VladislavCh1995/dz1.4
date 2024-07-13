using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во золота!");
            int gold = Convert.ToInt32(Console.ReadLine());
            int priceCristal = 10;
            int cristal = 0;
            Console.WriteLine($"У вас {gold} золота, сколько вы хотите купить кристаллов по цене {priceCristal}");

            cristal = Convert.ToInt32(Console.ReadLine());
            gold -= cristal * priceCristal;

            if (gold  >= 0)
            {
                Console.WriteLine($"У вас осталось {gold} золотых, а так же вы купили {cristal} кристалов");
            }
            else
            {
                Console.WriteLine("У вас нету стока денех!");
            }
        }
    }
}
