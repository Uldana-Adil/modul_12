using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_12pr
{
    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
    class Program
    {
        static void Main()
        {
            MyClass myObject = new MyClass();

            myObject.PropertyChanged += MyPropertyChangedHandler;

            myObject.MyProperty = 42;

            Console.ReadLine();
        }

        static void MyPropertyChangedHandler(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Property '{e.PropertyName}' changed.");
        }
    }


}
