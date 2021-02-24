using System;
using System.IO;

namespace doStudent
{
    class Program
    {
        static void Main(string[] args)
        {

            string id = string.Empty;



            if (args.Length == 1)
            {
                
                id = args[0];

            }

            

            listStudentFile();

            while (true) { 

                doStudentFile();
            }

        }


        public static void listStudentFile()
        {

            //string dir = Directory.GetCurrentDirectory();
            //Console.WriteLine(dir);

      
            var FileName = "studentfile.txt";

            Console.WriteLine($"Listing the student file: {FileName}.");


            var lines = File.ReadAllLines(FileName);

            //for (int i = 0; i < lines.Length; i++)
            //{

            //    Console.WriteLine(lines[i]);

            //}

    
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void doStudentFile()
        {


            Console.Write("Choose student id: ");

            var id = Console.ReadLine();

            var FileName = "studentfile.txt";

            var StudentFile = File.ReadAllLines(FileName);
            var foundStudent = false;

            foreach (var student in StudentFile)
            {
                var splits = student.Split("|");
                var studentId = splits[0];
                var studentName = splits[1];
                var studentSurName = splits[2];

                if (studentId.Equals(id))
                {

                    foundStudent = true;

                    Console.WriteLine($"student with {id} was found.");
                    Console.WriteLine(studentId + " " + studentName + " " + studentSurName);
                    
                }

            }

            if (!foundStudent)
            {

                Console.WriteLine($"student with {id} was not found.");
            }
            
        }
    }
}

