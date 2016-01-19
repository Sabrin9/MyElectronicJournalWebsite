using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyElectronicJournalWebsite.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var users = new List<User>
            {
                new User {Name = "Сабрин", Surname = "Аль-Таясне", Patronimicname = "Нидаловна", Email = "Adm@gmail.com", Password = "123456", Role = "Администратор"},
                new User {Name = "Ирина", Surname = "Киселева", Patronimicname = "Анатольевна", Email = "Kiseleva@gmail.com", Password = "1", Role = "Учитель"},
                new User {Name = "Нина", Surname = "Алексеева", Patronimicname = "Сергеевна", Email = "Alexeeva@gmail.com", Password = "1", Role = "Учитель"},
                new User {Name = "Людмила", Surname = "Белкина", Patronimicname = "Васильевна", Email = "Belkina@gmail.com", Password = "1", Role = "Учитель"},
                new User {Name = "Татьяна", Surname = "Мисюрова", Patronimicname = "Ивановна", Email = "Misurova@gmail.com", Password = "1", Role = "Учитель"},
                new User {Name = "Наталья", Surname = "Путкова", Patronimicname = "Владимировна", Email = "Putkova@gmail.com", Password = "1", Role = "Учитель"},
                new User {Name = "Альбина", Surname = "Грачева", Patronimicname = "Васильевна", Email = "Gracheva@gmail.com", Password = "1", Role = "Учитель"}
            };

            foreach (var temp in users)
                context.Users.Add(temp);

            context.SaveChanges();
        }
    }
}