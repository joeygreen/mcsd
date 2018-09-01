using System;

namespace StudentReportCard
{
    class Program
    {
        static void Main(string[] args)
        {
           var students = new string[PromptForNumberOfStudents()][];

           EnterStudentData(students);

           var reportCard = GetReportCard(students);

           DisplayReportCard(reportCard);
        }

        static int PromptForNumberOfStudents() 
        {
            Console.WriteLine("Enter total students:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void EnterStudentData(string[][] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new string[4] 
                {
                    PromptForStudentName(),
                    PromptForEnglishScore(),
                    PromptForMathScore(),
                    PromptForComputerScore()
                };
            }
        }

        static string PromptForStudentName()
        {
            Console.WriteLine("\r\nEnter Student Name:");
            return Console.ReadLine();
        }

        static string PromptForEnglishScore()
        {
            Console.WriteLine("Enter English Marks (Out of 100):");
            return Console.ReadLine();
        }

        static string PromptForMathScore()
        {
            Console.WriteLine("Enter Math Marks (Out of 100):");
            return Console.ReadLine();
        }

        static string PromptForComputerScore()
        {
            Console.WriteLine("Enter Computer Marks (Out of 100):");
            return Console.ReadLine();
        }

        static string[] GetReportCard(string[][] students)
        {
            var reportCard = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                var totalScore = 0;
                var studentName = "";
                var position = (i + 1);
                
                for (int j = 0; j < students[i].Length; j++)
                {                    
                    if (j == 0)
                    {
                        studentName = $"Student Name: {students[i][j]}";
                    }
                    else 
                    {
                        totalScore += Convert.ToInt32(students[i][j]);
                    }
                }
                
                reportCard[i] = $"Student Name: {studentName}, Position: {position.ToString()}, Total: {totalScore.ToString()}/300";
            }

            return reportCard;
        }

        static void DisplayReportCard(string[] reportCard)
        {
            foreach (var report in reportCard)
            {
                Console.WriteLine("********************");
                Console.WriteLine(report);
                Console.WriteLine("********************");
            }
        }
    }
}
