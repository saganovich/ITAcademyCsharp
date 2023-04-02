using System.Data;
using System.Reflection;

namespace DllReader
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Assembly dll = Assembly.LoadFile(Directory.GetCurrentDirectory() + "\\" + "dz8.dll");

			Console.WriteLine("Types:");
			Type[] types = dll.GetTypes();
			foreach (Type t in types)
			{
				Console.WriteLine(t.Name);
			}

			Type type = dll.GetType("dz8_namespace.Class_dz8", false, true);

            Console.WriteLine("\nFields:");
			foreach(var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
			{
				Console.WriteLine($"{field.Name}: {field.FieldType}");
			}
            Console.WriteLine();
            Console.WriteLine("Properties:");
			foreach(var prop in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
			{
				Console.WriteLine($"{prop.Name}: {prop.PropertyType}");
			}
			Console.WriteLine();
            Console.WriteLine("Methods:");
			foreach(var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
			{
				Console.WriteLine($"{method.Name}({string.Join(", ", method.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name))}): {method.ReturnType}");
			}
            Console.WriteLine();

            MethodInfo showsecret = type.GetMethod("ShowSecretPassword", BindingFlags.NonPublic | BindingFlags.Instance);
			MethodInfo showhint = type.GetMethod("ShowHint");
            var inst = Activator.CreateInstance(type);
			Console.WriteLine($"E-mail - {type.GetProperty("Email").GetValue(inst, null)}");
			Console.WriteLine($"Checksum - {type.GetProperty("Checksum").GetValue(inst, null)}");
			Console.WriteLine($"SecretPass - {showsecret.Invoke(inst, null)}");
			showhint.Invoke(inst, new object[] {"Alexander"});
			
		}
	}
}