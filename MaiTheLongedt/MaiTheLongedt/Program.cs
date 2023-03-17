using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiTheLongedt
{
     class Program
    {
        public static int StudentId { get; set; }
        public static string StudName { get; set; }
        public static string StudGender { get; set; }
        public static int StudAge { get; set; }
        public static string StudClass { get; set; }
        public static float StudAvgMark { get; set; }
        static void Main(string[] args)
        {
            
            IDictionary<int, Student> listStudent = new Dictionary<int, Student>();
            int chon=0;
            do
            {
                Console.WriteLine("Please select a option");
                Console.WriteLine("1.Insert a new student");
                Console.WriteLine("2.Display all the student list");
                Console.WriteLine("3.Calculate avg mark");
                Console.WriteLine("4.Search Student");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Option:");
               chon=Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.WriteLine("Nhap student ID: ");
                            student.StudentId=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nhap student name :");
                            student.StudName=Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Nhap student gender :");
                            student.StudGender = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Nhap student age :");
                            student.StudAge =Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nhap student class :");
                            student.StudClass =Convert.ToString(Console.ReadLine());
                          for(int i=0;i<3;i++)
                            {
                                Console.WriteLine($"Nhap mark :");
                                student.MarkList[i]=Convert.ToInt32(Console.ReadLine()) ;
                               
                            }
                          
                            listStudent.Add(student.StudentId, student);
                            
                        };break;
                        case 2: {
                            foreach (KeyValuePair<int, Student> item in listStudent)
                            {
                                item.Value.Print();
                            }
                        }
                        break;
                    case 3: {
                            foreach (KeyValuePair<int, Student> item in listStudent)
                            {
                                item.Value.CallAvg();
                                item.Value.Print();
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("6.Tim kiem theo ID: ");
                            Console.WriteLine("7.tim kiem theo name :");
                            Console.WriteLine("8.tim kiem theo class :");
                            int luachon = 0;
                            Console.WriteLine("nhap lua chon :");
                            luachon= Convert.ToInt32(Console.ReadLine());
                            if(luachon==6)
                            {
                            Console.WriteLine("nhap ID  can tim :");
                            int newID =Convert.ToInt32(Console.ReadLine()); 
                                foreach (KeyValuePair<int, Student> item in listStudent)
                                {
                                    if (item.Key == newID)
                                    {
                                        item.Value.Print();
                                    }
                                }
                            }else if(luachon==7)
                            {
                            Console.WriteLine("nhap name can tim :");
                            string newName=Convert.ToString(Console.ReadLine());
                                foreach (KeyValuePair<int, Student> item in listStudent)
                                {
                                    if (item.Value.StudName == newName)
                                    {
                                        item.Value.Print();
                                    }
                                }
                            }else if(luachon==8)
                            {
                                Console.WriteLine("nhap lop can tim :");
                            string newClass =Convert.ToString(Console.ReadLine());
                                foreach (KeyValuePair<int, Student> item in listStudent)
                                {
                                    if (item.Value.StudClass == newClass)
                                    {
                                        item.Value.Print();
                                    }
                                
                                }
                            } 
                           
                        } break;

                    case 5: break;
                }

            } while (chon != 0);
        }

    }
}
