using TaiwainStockUtility.TradingTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaiwainStockUtility.TradingTime.TaiwainStockUtilityCl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入時間(yyyy/MM/dd HH:mm:ss)");
            string dt =Console.ReadLine();

            var time = new TaiwainStockUtilityCl();
            
            if( DateTime.TryParse(dt, out DateTime dateTime) == false)
            {
                Console.WriteLine("請重新輸入時間(yyyy/MM/dd HH:mm:ss)");
                return;
            }

            if (time.Input(dateTime).IsOpen == true)
            {
                Console.WriteLine($"{dateTime:yyyy/MM/dd HH:mm:ss dddd}是股市營業時間"); 
            }
            else
            {
                Console.WriteLine($"{dateTime:yyyy/MM/dd HH:mm:ss dddd}不是股市營業時間");
            }
        }
        
    }
    
}
