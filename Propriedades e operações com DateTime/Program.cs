using System;

namespace Propriedades_e_operações_com_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2021, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine("1 - Date: " + d.Date);
            Console.WriteLine("2 - Day: "  + d.Day);
            Console.WriteLine("3 - Day Of Week: " + d.DayOfWeek);
            Console.WriteLine("4 - Day Of Year: " + d.DayOfYear);
            Console.WriteLine("5 - Hour: " + d.Hour);
            Console.WriteLine("6 - Kind: " + d.Kind);
            Console.WriteLine("7 - Millisecond: " + d.Millisecond);
            Console.WriteLine("8 - Minute: " + d.Minute);
            Console.WriteLine("9 - Month: " + d.Month);
            Console.WriteLine("10 - Second: " + d.Second);
            Console.WriteLine("11 - Ticks: " + d.Ticks);
            Console.WriteLine("12 - Time Of Day: " + d.TimeOfDay);
            Console.WriteLine("13 - Year: " + d.Year);
        }
    }
}
