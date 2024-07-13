namespace oop_03
{
    internal class Program
    {

        internal struct Employee
        {
            #region Attributes
            public int Id;
            public string? name;
            public decimal salary;
            #endregion

            #region constructors
            public Employee(int _id, string? _name, decimal _salary)
            {
                Id = _id;
                name = _name;
                salary = _salary;
            }

            #endregion

            #region methods
            public override string ToString()
            {
                return $"Id = {Id}\nName = {name}\nsalary = {salary}";
            }
            #endregion

            #region Encapsulation by geeters ans setters
            //GETTER
            public string? GetName()
            {
                return name;
            }

            //SETTER
            public void SetName(string? _name)
            {
                name = _name?.Length > 5 ? _name.Substring(0, 3) : _name;
            }
            #endregion

            #region Encapsulation by Property
            //property (Full Property - Automatic Property -INdexer)
            public decimal Salary
            {
                get
                {
                    return salary;
                }
                set
                {
                    salary = value > 9000 ? value : 9000;
                }
            }

            //full property--propfull
            private int test;
            public int Test
            {
                get
                {
                    return test;
                }
                set
                {
                    test = value;
                }

                //automatic property

            }
            public int Test1 { get; set; }
            #endregion


        }

        internal struct phoneBook
        {
            string[] names;
            int[] numbers;
            int size;

            public int Size
            {
                get
                {
                    return size;
                }
            }
            public phoneBook(int _size)
            {
                size = _size;
                names = new string[size];
                numbers = new int[size];
            }

            public void AddPerson(int position, string name, int number)
            {
                if (names != null && numbers != null)
                {
                    if (position < Size)
                    {
                        names[position] = name;
                        numbers[position] = number;
                    }
                }
            }

            public int GetPersonNumber(string _name)
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == _name)
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }

            public void SetPersonNumber(string name, int newNum)
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = newNum;
                            break;
                        }
                    }
                }
            }

            public int this[string _name]
            {
                get
                {
                    if (names != null && numbers != null)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == _name)
                            {
                                return numbers[i];
                            }
                        }
                    }
                    return -1;
                }
                set
                {
                    if (names != null && numbers != null)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == _name)
                            {
                                numbers[i] = value;
                                break;
                            }
                        }
                    }

                }
            }

            public string this[int index]
            {
                get
                {
                    return $"Name : {names[index]} phone number : {numbers[index]}";
                }
            }
        }
            static void Main(string[] args)
            {
                //Employee employee = new Employee(1, "", 9000);
                //Console.WriteLine(employee);

                //employee.SetName("NADINE");
                //Console.WriteLine(employee.GetName());

                //employee.Salary = 5000;
                //Console.WriteLine(employee.Salary);


                //employee.Test = 99;
                //Console.WriteLine(employee.Test);

                //employee.Test1 = 5;
                //Console.WriteLine(employee.Test1);

                //phoneBook Note = new phoneBook(3);
                //Note.AddPerson(0, "Nadine", 01099);
                //Note.AddPerson(1, "zein", 01033);
                //Note.AddPerson(2, "amr", 01066);
                //Console.WriteLine(Note.GetPersonNumber("zein") == -1 ? "person not found" : Note.GetPersonNumber("zein"));
                //Note["amr"] = 1000;
                //Console.WriteLine(Note["amr"]);
                //Console.WriteLine(Note[0]);

            //Car c1 = new Car();
            //Console.WriteLine(c1);

            //Parent p = new Parent(5, 10);
            //Child ch = new Child(9, 3, 7);
            // Console.WriteLine( p.ToString());
            //Console.WriteLine(p.Product());
            //Console.WriteLine(ch.ToString());
            //Console.WriteLine(ch.Product());


        }
        }
    }

