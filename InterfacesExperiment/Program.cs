using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExperiment
{
    class Program
    {
        static void Main()
        {
            TestClass test = new TestClass();
            
            while (true) ;
        }
    }

    public interface ITestInterface
    {
        void SampleFunction();
        int SampleProperty
        {
            get;
            set;
        }
    }

    public class TestClass : ITestInterface
    {
        private int sampleVariable;
        public void SampleFunction()
        {
            Console.WriteLine("This is my implementation for Sample Function. Sample Variable is equal to: " + sampleVariable);
        }
        public int SampleProperty
        {
            get
            {
                return sampleVariable;
            }
            set
            {
                sampleVariable = value;
            }
        }
    }
}
