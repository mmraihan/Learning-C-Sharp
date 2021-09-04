using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_DI
{
    //class Consumer
    //{
    //    MyDependency _dependency = new MyDependency();

    //    public void ConsumeThings()
    //    {
    //        _dependency.WriteMessage("Hello from Consumer!");
    //    }

    //}


    public class Consumer
    {
        IMyDependency _dependency;

        public Consumer(IMyDependency dependency)
        {
            _dependency = dependency;
        }

        public void ConsumeThings()
        {
            _dependency.writeMessage("Hello from Consumer");
        }
    }


}
