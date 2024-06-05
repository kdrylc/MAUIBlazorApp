using MAUIBlazorApp.Classes.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Services
{
    public class PersonalService
    {
        private List<Personal> list;
        public event Func<Task> OnChange;
        public event Func<string,Task> OnSearch;
        public PersonalService()
        {
            list = new List<Personal>();
            list.Add(new Personal
            {
                    Id = 1,
                    Name ="Kadir",
                     Surname="Yolcu"
            });

            list.Add(new Personal
            {
                Id = 2,
                Name = "Hüseyin",
                Surname = "Yolcu"
            });
        }
        
        public async Task<List<Personal>> List()
        {
            return list;
        }

        public async Task<Personal> GetById(int Id)
        {
            return list.Where(x => x.Id == Id).First();
        }

        public async Task<bool> addPersonal(Personal person)
        {
            try
            {
                list.Add(person);
                notificationCambios();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> delete(int id)
        {
            try
            {
                var query = list.Where(x => x.Id != id).ToList();
                list = query;
                notificationCambios();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private async Task notificationCambios()
        {
            OnChange?.Invoke();
        }

        public async Task<List<Personal>> personalSearch(string Name)
        {
           var query = list.Where(x=>(x.Name.ToUpper().Contains(Name.ToUpper()))).ToList();
            return query;
        }

        public async Task notificationSearch(string nameSearch)
        {
            OnSearch?.Invoke(nameSearch);
        }
    }
}
