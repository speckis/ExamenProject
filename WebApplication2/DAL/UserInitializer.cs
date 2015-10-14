using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Marcus", LastName="Cooper", RegisterDate=DateTime.Parse("2009-04-29")},
                new User{FirstName="Genieve", LastName="Brand", RegisterDate=DateTime.Parse("2006-09-12")},
                new User{FirstName="Frank", LastName="Romlyn", RegisterDate=DateTime.Parse("2012-01-03")},
                new User{FirstName="Leonard", LastName="Griever", RegisterDate=DateTime.Parse("2006-10-18")},

            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var regions = new List<Region>
            {
                new Region{RegionID=1003, Name="Gothenburg", PostalCode=42433},
                new Region{RegionID=1004, Name="Alingsas", PostalCode=40245},
                new Region{RegionID=1005, Name="Uppsala", PostalCode=20034},
                new Region{RegionID=1006, Name="Falkenberg", PostalCode=32340},

            };

            regions.ForEach(s => context.Regions.Add(s));
            context.SaveChanges();

            var registers = new List<Register>
            {
                new Register{UserID=1, RegionID=1003},
                new Register{UserID=2, RegionID=1004},
                new Register{UserID=3, RegionID=1005},
                new Register{UserID=4, RegionID=1006},
            };

            registers.ForEach(s => context.Registers.Add(s));
            context.SaveChanges();


        }
    }
}