//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("shemoitane tarigi :");
//        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
//        {
//            string season = GetSeason(date);
//            string dayOfWeek = date.DayOfWeek.ToString();

//            Console.WriteLine("sezoni: " + season);
//            Console.WriteLine("kviris dge: " + dayOfWeek);
//        }
//        else
//        {
//            Console.ReadLine();
//            return;
//        }
//    }

//    static string GetSeason(DateTime date)
//    {
//        int month = date.Month;
//        string season = "";

//        if (month >= 3 && month <= 5)
//            season = "gazafxuli";
//        else if (month >= 6 && month <= 8)
//            season = "zamtari";
//        else if (month >= 9 && month <= 11)
//            season = "gazafxuli";
//        else
//            season = "zamtari";

//        return season;
//    }
//}