using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class ClassSample
    {
        //private variable
        private string _stringProperty;
        //getter setter
        public string StringProperty {

            get { return _stringProperty; }

            set { _stringProperty = value; }
        }
        //shorthand getter setter
        public int IntProperty { get; set; }
        
        //void method
        public void WriteToConsole()
        {
            Console.WriteLine($"String Property value: { this.StringProperty} ");
        }
        //override method
        public override string ToString()
        {
            return $"Welcome { this.StringProperty }";
        }

    }
}
