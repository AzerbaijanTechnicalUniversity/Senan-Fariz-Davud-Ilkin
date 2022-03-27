using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shebeke
{
   public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://restoranmobile-default-rtdb.firebaseio.com/");

        //butun melumatlari cek
        public async Task<List<Person>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Select(item => new Person
              {
                  Name = item.Object.Name,
                  PersonId = item.Object.PersonId
              }).ToList();
        }

        //yeni login parol yarat
        public async Task AddPerson(string personId, string name)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Person() { PersonId = personId, Name = name });
        }

        //logini yoxla
        public async Task<Person> GetPerson(string personId, string name_)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.PersonId == personId && a.Name == name_).FirstOrDefault();
        }
    }
}
