using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            var helloPasswordList = users.Where(u => u.Password == "hello");

            Console.WriteLine("1) List of all users with password equal 'hello':");
            foreach (var user in helloPasswordList)
                Console.WriteLine($"\t Name: {user.Name}\t Password: {user.Password}");

            Console.WriteLine("\n\n2) List of users' passwords that are not the lowercase version of their names:");
            int NoUserNameAsPasswordList = users.RemoveAll(u => u.Password == u.Name.ToLower());
            foreach (var user in users)
                Console.WriteLine($"\t Name: {user.Name}\t Password: {user.Password}");

            Console.WriteLine("\n\n3) List of users after removing the first 'hello' password:");
            users.Remove(users.FirstOrDefault(u => u.Password == "hello"));
            foreach (var user in users)
                Console.WriteLine($"\t Name: {user.Name}\t Password: {user.Password}");
        }
    }
}
