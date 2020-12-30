using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace AutofacStartableComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");

            InitializeAutofac();

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        private static void InitializeAutofac()
        {
            var builder = new ContainerBuilder();

            builder
               .RegisterType<Startable1>()
               .AsSelf()
               .As<IStartable>()
               .SingleInstance();

            builder
               .RegisterType<Startable2>()
               .AsSelf()
               .As<IStartable>()
               .SingleInstance();

            builder
               .RegisterType<Startable3>()
               .AsSelf()
               .As<IStartable>()
               .SingleInstance();

            builder.Build();

            Console.WriteLine("Initialized Autofac!");
        }
    }

    class Startable1 : IStartable
    {
        public void Start()
        {
            Console.WriteLine($"Starting {nameof(Startable1)}");
        }
    }

    class Startable2 : IStartable
    {
        public void Start()
        {
            Console.WriteLine($"Starting {nameof(Startable2)}");
        }
    }

    class Startable3 : IStartable
    {
        public void Start()
        {
            Console.WriteLine($"Starting {nameof(Startable3)}");
        }
    }
}
