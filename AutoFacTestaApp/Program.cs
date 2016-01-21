using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTestaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterType<MyClass>();    //将MyClass注册到Autofac容器中

            //IContainer container = builder.Build();
            //MyClass obj = container.Resolve<MyClass>(); //从autofac容器中获取MyClass对象
            //Console.WriteLine(obj.id);

            var assembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(assembly);

            IContainer container = builder.Build();
            MyClass obj = container.Resolve<MyClass>();
            Console.WriteLine(obj.id);


            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
