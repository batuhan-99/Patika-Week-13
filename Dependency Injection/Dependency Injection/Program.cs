using Dependency_Injection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IOgretmen, Teacher>() 
                .AddTransient<ClassRoom>() 
                .BuildServiceProvider();

         
            var teacher = new Teacher("John", "Doe"); 
            var classRoom = new ClassRoom(teacher); 

          
            Console.WriteLine(classRoom.GetTeacherInfo());
        }
    }
}