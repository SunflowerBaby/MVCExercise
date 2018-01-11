using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////運算
            //Student student = new Student();
            //List<Student> students = student.getStudent();
            //List<StudentScore> studentScores = student.getScore();
            //Console.WriteLine("C# 課程分數加總 : {0}, 平均: {1}", studentScores.Sum(c => c.CsScore), studentScores.Average(c => c.CsScore).ToString("0.00"));
            //Console.WriteLine("DB 課程分數加總 : {0}, 平均: {1}", studentScores.Sum(c => c.DbScore), studentScores.Average(c => c.DbScore).ToString("0.00"));

            // Use LINQ
            //UseLINQ();

            //// 擴充 Extenson
            //int money = 123456789;
            //double p = 0.11029;
            //Console.WriteLine("{0}", money.FormForMoney());
            //Console.WriteLine("{0}", p.FormatPercent());

            SetOperations();

            Console.ReadLine();
        }

        private static void UseLINQ()
        {
            Student student = new Student();
            List<Student> students = student.getStudent();
            List<StudentScore> studentScores = student.getScore();

            var studentScoreQuery = from s in students
                                    join scores in studentScores on s.Id equals scores.Id
                                    select new
                                    {
                                        Id = s.Id,
                                        Name = s.Name,
                                        ScoreSum = scores.CsScore + scores.DbScore,
                                        ScoreAvg = (scores.CsScore + scores.DbScore) / 2
                                    };
            foreach (var studentScore in studentScoreQuery)
            {
                Console.WriteLine("學生 {0} 分數加總: {1} 平均:{2}", studentScore.Name, studentScore.ScoreSum, studentScore.ScoreAvg.ToString("0.00"));
            }
        }

        private static void SetOperations()
        {
            int[] numberA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numberB = { 1, 3, 5, 7, 8};

            var unionResultes = numberA.Union(numberB);
            var intersectResultes = numberA.Intersect(numberB);
            var exceptResultes = numberA.Except(numberB);

            Console.WriteLine("== Union ==");
            foreach (var q in unionResultes)
                Console.Write(q + " ");

            Console.WriteLine();
            Console.WriteLine("== Intersect ==");
            foreach (var q in intersectResultes)
                Console.Write(q + " ");

            Console.WriteLine();
            Console.WriteLine("== Except ==");
            foreach (var q in exceptResultes)
                Console.Write(q + " ");

            Console.WriteLine();

            //dixtinct
            int[] numberSeries = { 2, 2, 3, 5, 5 };
            var distincValues = numberSeries.Distinct();
            Console.WriteLine("Distinct Values from numberSeries");
            foreach (var q in distincValues)
                Console.Write(q + " ");
            Console.WriteLine();
        }
    }

    public static class Int32Extenson
    {
        public static string FormForMoney(this int Value)
        {
            return Value.ToString("$###,###,###,##0");
        }
    }

    public static class DoubleExtension
    {
        public static string FormatPercent(this double Value)
        {
            return Value.ToString("#0.00%");
        }
    }
}
