using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Depatment depatment = new Depatment();
            //var result = depatment.GetEmployee("Muba");
            //Console.WriteLine(result.Salary);
           

            Console.WriteLine(depatment[102].EmpName);
            Console.WriteLine(depatment["Alex2"].Id);

        }


        class Employee
        {
            public int Id { get; set; }
            public string EmpName { get; set; }
            public double Salary { get; set; }
        }

        class Depatment
        {
            public int DepId { get; set; }
            public string DepName { get; set; }
            Employee[] EmpList;

            public Depatment()
            {
                DepId = 10;
                DepName = "Sales";
                EmpList = new Employee[3]
                {
                new Employee {Id=101,EmpName="Alex Py", Salary=35000},
                new Employee {Id=102,EmpName="Alex", Salary=35000},
                new Employee {Id=103,EmpName="Alex", Salary=35000},
                };
            }

            public Employee GetEmployee(int id)
            {
                foreach (Employee emp in EmpList)
                {
                    if (id == emp.Id)
                    {
                        return emp;
                    }
                }
                return null;
            }


            public Employee GetEmployee(string name)
            {
                foreach (var item in EmpList)
                {
                    if (name == item.EmpName)
                    {
                        return item;
                    }
                }
                return null;
            }



            public Employee this[int id]
            {
                get
                {
                    foreach (Employee emp in EmpList)
                    {
                        if (id == emp.Id)
                        {
                            return emp;
                        }
                    }
                    return null;
                }

            }


            public Employee this[string name]
            {
                get
                {
                    foreach (Employee emp in EmpList)
                    {
                        if (name == emp.EmpName)
                        {
                            return emp;
                        }

                    }
                    return null;
                }
            }
        }
    } 
}
