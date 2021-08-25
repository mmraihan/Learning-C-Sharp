using System;

namespace Class_11
{
    class Program
    {
        static void Main(string[] args)
        {
            IClosable a = new Bottle();
            IColorable b = new Bottle();
            IContainer c = new Bottle();

            //a.Open();
            a.Close();

            var color= b.Color;

            c.AddContent(2);
            c.RemoveContent(3);
            var capacity = c.Capacity;



            //Bottle bottle = new Bottle();
            //bottle.Open();
            ////////////////////////Base and new In Interface///////////////////

            CorneredBottle cbottle = new CorneredBottle();
            cbottle.Open();



           

           
          
            
            

        }
    }
}
