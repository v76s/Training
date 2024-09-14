namespace Singleton_Best_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
        }
    }

    public sealed class Singleton
    {
        public static string ClassName;

        public static Singleton Instance => Nested.Instance;

        private class Nested
        {
            internal static Singleton Instance { get; } = new();

            static Nested()
            {
                Console.WriteLine("Nested class static constructor");
            }
        }

        private Singleton()
        {
            Console.WriteLine("Nested class static constructor");
        }

        static Singleton()
        {
            ClassName = "A Temp value";
            Console.WriteLine("Static constructor");
        }
    }
}


// FOR .NET 8.0 we implement the Singleton pattern much easily as below ; 

//using Microsoft.Extensions.DependencyInjection;

//IServiceCollection services = new ServiceCollection();

//services.AddSingleton<Logger>();

//var serviceProvider = services.BuildServiceProvider();

//var logger1 = serviceProvider.GetRequiredService<Logger>();
//var logger2 = serviceProvider.GetRequiredService<Logger>();
//var logger3 = serviceProvider.GetRequiredService<Logger>();
//var logger4 = serviceProvider.GetRequiredService<Logger>();
//class Logger
//{
//}
