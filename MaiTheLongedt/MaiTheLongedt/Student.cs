using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiTheLongedt
{
     class Student:IStudent
    {
        public int StudentId { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }
        public Student instance;
      

        public void Print()
        {
            Console.WriteLine($"StudenID :{StudentId}");
            Console.WriteLine($"StudName :{StudName}");
            Console.WriteLine($"StudGender :{StudGender}");
            Console.WriteLine($"StudAge :{StudAge}");
            Console.WriteLine($"StudClass :{StudClass}");
            Console.WriteLine($"StudAvgMark :{StudAvgMark}");
        }
        public  int[] MarkList=new int[3];
        public Student()
        {
            for(int i=0;i<3;i++)
            {
                MarkList[i]=i;
            }
        }
        public int this[int index]
        {
            get
            {
                int tmp;

                if (index >= 0 && index <=2)
                {
                    tmp = MarkList[index];
                }
                else
                {
                    tmp = 0;
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= 2)
                {
                    MarkList[index] = value;
                }
            }
        }
        public void CallAvg()
        {
            int total=0;
            
            for (int i = 0; i < 3; i++)
            {
               total+= MarkList[i]; 
            }
            StudAvgMark=total/3;
        }
    }
}
