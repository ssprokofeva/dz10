using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.WriteLine("Введите что-нибудь, чтобы закрыть окно...");
            Console.ReadKey();
        }

        private static void Task1()
        {
            string studentsFilePath = @"students.txt";
            string eventsFilePath = @"events.txt";
            int eventDate = 30;
            int participantsPerGroup = 3;
            List<Student> students = new List<Student>();
            Event currentEvent = null;

            try
            {
                using (StreamReader reader = new StreamReader(studentsFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var parts = line.Split(' ');
                            students.Add(new Student(parts[0], parts[1]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения файла студентов: {ex.Message}");
                return;
            }

            do
            {
                Random random = new Random();
                currentEvent = new Event(eventDate, participantsPerGroup, students.Count / participantsPerGroup);
            } while (currentEvent == null || !currentEvent.CanProceed());

            try
            {
                using (StreamWriter writer = new StreamWriter(eventsFilePath, true))
                {
                    writer.WriteLine(currentEvent.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи файла событий: {ex.Message}");
                return;
            }

            List<string> selectedStudents = currentEvent.GenerateParticipants();

            try
            {
                using (StreamWriter writer = new StreamWriter("selected_participants.txt", false))
                {
                    foreach (var student in selectedStudents)
                    {
                        writer.WriteLine(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи файла участников: {ex.Message}");
                return;
            }

            Console.WriteLine("Событие: " + currentEvent);
            Console.WriteLine("Выбранные участники: ");
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task2()
        {


        }
    }
}
