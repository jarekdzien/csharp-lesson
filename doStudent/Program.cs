using System;
using System.IO;


namespace doStudent
{
    class Program
    {
        static void Main(string[] args)
        {

            // why do i need that?

            //string id = string.Empty;

            //if (args.Length == 1)
            //{
            //    id = args[0];
            //}

            
            listStudentFile();

            var xxx = true;

            while (xxx == true) {
                
                Console.Write("Choose student id (enter q to quit): ");
                
                var id = Console.ReadLine();


                if ( id == "q")
                {

                    xxx = false;
                }
                else  {
                    doStudentFile(id);

                }
            }

        }

        public static void listStudentFile()
        {

            //string dir = Directory.GetCurrentDirectory();
            //Console.WriteLine(dir);

            
            var FileName = "studentfile.txt";

            Console.WriteLine($"Listing the student file: {FileName}.");


            var lines = File.ReadAllLines(FileName);

            string v = DateTime.Now.Date.ToShortDateString();


            Console.WriteLine("Date: "+v);

            //var text = "COS nowego\n";
            //File.WriteAllText(FileName, text);

            string[] liness = { "4|Name4|Surname4", "5|Name5|Surname5", "6|Name6|Surname6" };
        
            //File.AppendAllLines(    //File.AppendAllLines(@"C:\Users\Jarek_Dzien\source\repos\doStudent\doStudent\"+FileName, liness);FileName, liness);


            //for (int i = 0; i < lines.Length; i++)
            //{

            //    Console.WriteLine(lines[i]);

            //}

            foreach (var line in lines)
            {
               Console.WriteLine(line);
            }
        }

        public static void doStudentFile(string id)
        {

            Console.Clear();
            
            var FileName = "studentfile.txt";
            var StudentFile = File.ReadAllLines(FileName);
            var foundStudent = false;

            foreach (var student in StudentFile)
            {
                try
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
                catch (Exception e)
                {
                    Console.Write("There's some data error -> ");
                    Console.WriteLine(e.Message);
                }
            }

            if (!foundStudent)
            {
                Console.WriteLine($"student with {id} was not found.");
            }
        }
    }
}