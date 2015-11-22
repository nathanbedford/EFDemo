using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        static string USERNAME = "nathanbedford";

        static void Main(string[] args)
        {

            var db = new DemoDbContext();
            //db.Configuration.AutoDetectChangesEnabled = false;

            var user = db.Users.SingleOrDefault(x => x.UserName == USERNAME);
            if(user == null)
            {
                user = new User()
                {
                    UserName = USERNAME
                };
                                
                db.Users.Add(user);
                db.SaveChanges();
            }

            if(user.Roles.Count() == 0)
            {
                var adminRole = new Role()
                {
                    Name = "Admin"
                };
                var userRole = new Role() 
                {
                    Name = "User"
                };

                user.Roles.Add(adminRole);
                user.Roles.Add(userRole);
            }


            db.SaveChanges();

            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
