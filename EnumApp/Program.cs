using System;

namespace EnumApp
{
    enum WeekDay
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    // we can set specific values if desired
    enum CustomValueEnum
    {
        a = 7,
        b = 3,
        c = -1,
    }
    
    // enum can have a custom (must be numeric) type
    enum ByteEnum : byte
    {
        Goblin,
        Troll,
        Hobit,
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeekDay day = WeekDay.Tuesday;

            foreach (WeekDay d in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine("{0} is a work day? {1}", d, isWorkDay(d));
            }

            foreach (CustomValueEnum v in Enum.GetValues(typeof(CustomValueEnum)))
            {
                Console.WriteLine("value for {0} is {1}", v, (int)v);
            }

            Console.WriteLine("day: {0}", day);
        }

        static bool isWorkDay(WeekDay day)
        {
            switch (day)
            {
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    return false;
                default:
                    return true;
            }
        }
    }
}
