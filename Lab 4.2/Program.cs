using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Name :  Natalia Andrea Herrera Espinosa
// Date: 2023-09-18
// Description: Lab 4.2 – on struct and class datatype objects, array, placeholders and try and catch.

namespace Lab_4._2
{

    struct StudentS
    {
        private string name;
        private sbyte age;
        private uint id;
        private string collegeName;
        private string city;
        private string address;

        public sbyte Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public uint Id { get { return id; } set { id = value; } }
        public string CollegeName { get { return collegeName; } set { collegeName = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Address { get { return address; } set { address = value; } }

        public void Display()
        {
            Console.WriteLine($"Name: {this.name} | Age: {this.age} | Id: {this.id} | + " +
                $"College : {this.collegeName} | Address : {this.address} | City : {this.city}\n");
        }


    }

    class StudentC
    {
        private string name;
        private sbyte age;
        private uint id;
        private string collegeName;
        private string city;
        private string address;

        public sbyte Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public uint Id { get { return id; } set { id = value; } }
        public string CollegeName { get { return collegeName; } set { collegeName = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Address { get { return address; } set { address = value; } }


        public StudentC(string name, sbyte age, uint id, string collegeName, string city, string address)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.collegeName = collegeName;
            this.city = city;
            this.address = address;

        }

        public void Display()
        {
            Console.WriteLine($"Name: {this.name} | Age: {this.age} | Id: {this.id} | + " +
                $"College : {this.collegeName} | Address : {this.address} | City : {this.city}\n");
        }

    }


    internal class Program
    {
        static int countArrayS = 0;
        static int countArrayC = 0;
        static StudentS[] List_studentsS = new StudentS[5];
        static StudentC[] List_studentsC = new StudentC[5];

        static void Main(string[] args)
        {
            int choice; // variable for Menu         
            bool quit = true;


            do
            {
                Console.WriteLine();
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("║                    MAIN MENU                   ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Enter a new student's information (struct). ║");
                Console.WriteLine("║ 2. Enter a new student's information (class).  ║");
                Console.WriteLine("║ 3. Display student information (struct).       ║");
                Console.WriteLine("║ 4. Display student information (class).        ║");
                Console.WriteLine("║ 5. Quit.                                       ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CreateStudent(1);

                            break;
                        case 2:
                            CreateStudent(2);
                            break;
                        case 3:
                            DisplayStudent(1);
                            break;
                        case 4:
                            DisplayStudent(2);
                            break;
                        case 5:
                            Console.Write("\"Are you sure you want to quit? (Y/N): ");
                            if (Console.ReadLine().Trim().ToUpper() == "Y")
                            {
                                quit = false;
                                Console.WriteLine("Goodbye!");
                            }
                            else { quit = true; }
                            break;


                        default:
                            Console.WriteLine("Invalid Option. try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select a valid option.");
                }

            } while (quit);


        }
        static void DisplayStudent(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("\nList of Student into Struct Array:");
                foreach (var student in List_studentsS)
                {
                    if (student.Name != null)
                    {
                        student.Display();
                    }

                }
            }

            else
            {
                Console.WriteLine("\nList of Student into Class Array:");
                foreach (StudentC student in List_studentsC)
                {
                    if (student != null) // Check not null
                    {
                        student.Display();
                    }

                }

            }
        }

        public static void CreateStudent(int option)
        {
            // Inicia a Validacao dos INPUTS de Dados
            string in_Name, in_collegeName, in_city, in_address;
            Console.Write("Student Name: ");

            in_Name = Console.ReadLine();
            sbyte in_Age;

        ERRO_age: Console.Write("Age : ");
            try
            {
                in_Age = Convert.ToSByte(Console.ReadLine());
                if (in_Age < 15 || in_Age > 65)
                {
                    Console.WriteLine(" Invalid age. entered age value to be between 15 to 65 years old");
                    goto ERRO_age;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto ERRO_age;
            }


            uint in_id;
            Console.Write("Enter student's ID (7-digit numeric value): ");
            while (!uint.TryParse(Console.ReadLine(), out in_id) || in_id < 1000000 || in_id > 9999999)
            {
                Console.WriteLine("Invalid ID. Please enter a 7-digit numeric value.");
                Console.Write("Enter student's ID (7-digit numeric value): ");
            }
            

            Console.Write("College Name : ");
            in_collegeName = Console.ReadLine();

            Console.Write("City: ");
            in_city = Console.ReadLine();

            Console.Write("Address: ");
            in_address = Console.ReadLine();


            if (option == 1 && countArrayS < 5)
            {
                List_studentsS[countArrayS].Name = in_Name;
                List_studentsS[countArrayS].Age = in_Age;
                List_studentsS[countArrayS].City = in_city;
                List_studentsS[countArrayS].Id = in_id;
                List_studentsS[countArrayS].Address = in_address;
                List_studentsS[countArrayS].CollegeName = in_collegeName;
                countArrayS++;

                Console.WriteLine("Student Created into Struct Array\n");
            }
            else if (option == 2 && countArrayC < 5)
            {
                StudentC student = new StudentC(in_Name, in_Age, in_id, in_collegeName, in_city, in_address);
                List_studentsC[countArrayC] = student;
                countArrayC++;
                Console.WriteLine("Student Created into Class Array\n");

            }

        }


    }

}
