using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
        }

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }

        //public List<Student> getStudent()
        //{
        //    List<Student> student = new List<Student>();
        //    student.Add(new Student("1", "張三"));
        //    student.Add(new Student("2", "李四")); 

        //    return student;
        //}

        public List<Student> getStudent()
        {
            return new List<Student>(new[] 
            {
                new Student(){ Id ="1", Name = "紀五"},
                new Student(){ Id ="2", Name = "陳六"},
                new Student(){ Id ="3", Name = "飛七"},
                new Student(){ Id ="4", Name = "王八"},
            });
        }

        public List<StudentScore> getScore()
        {
            List<StudentScore> scoreList = new List<StudentScore>();

            scoreList.Add(new StudentScore("1", 63, 78));
            scoreList.Add(new StudentScore("2", 81, 86));
            scoreList.Add(new StudentScore("3", 55, 73));

            return scoreList;
        }

    }

    class StudentScore
    {
        public string Id { get; set; }
        public double CsScore { get; set; }
        public double DbScore { get; set; }
        public Dictionary<string, double> CsScoreList;
        public Dictionary<string, double> DbScoreList;

        public StudentScore()
        {
            CsScoreList = new Dictionary<string, double>();
            DbScoreList = new Dictionary<string, double>();
        }

        public StudentScore(string id, int csScore, int dbScore)
        {
            Id = id;
            CsScore = csScore;
            DbScore = dbScore;

            CsScoreList = new Dictionary<string, double>();
            DbScoreList = new Dictionary<string, double>();
            CsScoreList.Add(id, CsScore);
            DbScoreList.Add(id, CsScore);
        }

    }


}
