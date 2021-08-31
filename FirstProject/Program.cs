// ReSharper disable All
using System;
using System.Reflection;

namespace FirstProject
{
   
    class Program
    {
        static void Display(object obj)
        {
            Type objType = obj.GetType();
            var properties = objType.GetProperties();

            foreach (var property in properties)
            {
                var propValue = property.GetValue(obj);

                var propType = propValue.GetType();

                if (propType.IsPrimitive || propType == typeof(string))
                {
                    var displayPropertyAttribute = property.GetCustomAttribute<DisplayPropertyAttribute>();


                    if (displayPropertyAttribute != null)
                    {
                        Console.WriteLine($"{displayPropertyAttribute.DisplayName}: {propValue}");

                    }
                    else
                    {
                        Console.WriteLine($"{property.Name}: {propValue}");

                    }


                }
            }
        }

        class RepoWrapper<T>
        {
            public Repository<T> Repository { get; set; }
        }
        public class Repository<T>
        {
            public Repository(object options)
            {

            }
        }

        static void Main(string[] args)
        {
            var repo = new Repository<string>(args);

            var repoWrapper = new RepoWrapper<string>
            {
                Repository = repo
            };


            var genericArg = repoWrapper.GetType().GetGenericArguments()[0];

            var repoType = typeof(Repository<>);
            var stringRepoType = repoType.MakeGenericType(typeof(string));

            var newRepo = Activator.CreateInstance(stringRepoType, (object)args);




            Console.WriteLine();


        }

        static void SetValue<T>(T obj, string propName, string value)
        {
            Type objType = typeof(T);

            var propertyToUpdate = objType.GetProperty(propName);
            if (propertyToUpdate != null)
            {
                propertyToUpdate.SetValue(obj, value);
            }
        }
            

    }
}


