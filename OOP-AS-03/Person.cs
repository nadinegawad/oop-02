using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_03
{
    internal struct Person
    {
        public string[] Names;
        public int[] Ages;
        public int size;

       public int Size
        {
            get
            {
                return size;
            }
        }

        public Person(int _size)
        {
            size = _size;
            Names = new string[size];
            Ages = new int[size];
        }
        public void AddPerson(int poistion , string name , int age)
        {
            if(Names is not null && Ages is not null)
            {
                for(int i = 0; i < Size;i++)
                {
                    Names[poistion] = name;
                    Ages[poistion] = age;
                }
            }
        }

       public void DisplayData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Name : {Names[i]} , Age : {Ages[i]}");

            }
        }

        public void GetOldestPerson()
        {
            int max = Ages[0];
            string PName="";
            for(int i = 0;i < size;i++)
            {
                if (Ages[i] > max)
                {
                    max = Ages[i];
                    PName = Names[i];
                }
            }
            Console.WriteLine($"The Oldest Person is : {PName} and his age is {max}");
        }
   
           
    }

      
    }

