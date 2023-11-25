using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_12pr
{
    public class MyClass : IPropertyChanged
    {
        private int myProperty;

        public int MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    OnMyPropertyChanged(nameof(MyProperty));
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        protected virtual void OnMyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }

}
