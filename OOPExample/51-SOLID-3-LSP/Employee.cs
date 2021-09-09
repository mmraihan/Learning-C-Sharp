using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_SOLID_3_LSP
{
   public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Employee()
        {

        }

        public Employee (int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format($"Id: {Id}, Name: {Name}");
        }


        public class PermanentEmployee : Employee
        {
            public PermanentEmployee()
            {

            }
            public PermanentEmployee(int id, string name) : base(id, name)
            {

            }
            public override decimal CalculateBonus(decimal salary)
            {
                return (salary * .15M);
            }


        }


        public class TemporaryEmployee : Employee
        {

            public TemporaryEmployee()
            {

            }

            public TemporaryEmployee(int id, string name): base(id, name)
            {

            }
            public override decimal CalculateBonus(decimal salary)
            {
                return (salary * 0.5M);
            }
        }


        public class ContractEmployee : Employee
        {
            public ContractEmployee()
            {

            }
            public ContractEmployee(int id , string name) :base(id,name)
            {

            }

            public override decimal CalculateBonus(decimal salary)
            {
                throw new NotImplementedException();
            }
        }
    }
}
