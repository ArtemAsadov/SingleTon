using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            computer.Launch("Windows LInux");
            computer.Display();
            computer.Launch("asd");
            computer.Display();
            Console.ReadKey();
        }
    }
    class Computer {
        public OS OS { get; set; }
        public void Launch(string osName) {
            OS = OS.getInstance(osName);
        }
        public void Display() {
            Console.WriteLine($"OS.name: {OS.Name}");
        }
    }
    class OS {
        private static OS instance;
        public string Name { get; private set; }
        protected OS(string name) {
            Name = name;
        }
        public static OS getInstance(string name) {
            if (instance == null) {
                instance = new OS(name);
            }
                return instance;
        }
    }
   

}
