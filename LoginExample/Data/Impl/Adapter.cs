using System.Collections.Generic;
using System.Linq;
using LoginExample.Models;
using LoginExample.Persistance;

namespace LoginExample.Data.Impl
{
    public class Adapter : IAdultService
    {
        private FileContext file;


        public Adapter()
        {
            file = new FileContext();
        }

        public void AddAdult(Adult addAdult)
        {
            int max = file.Adults.Max(a => a.id);
            addAdult.id = (++max);
            file.Adults.Add(addAdult);
            file.SaveChanges();
        }


        public IList<Adult> ReadAllAdults()
        {
            return file.Adults;
        }

        public void UpdateAdult(Adult updateAdult)
        {
            foreach (var adult in file.Adults)
            {
                if (adult.id == updateAdult.id)
                {
                    file.SaveChanges();
                    return;
                }
                
            }
            
            
        }
        public void DeleteAdult(Adult deleteAdult)
        {
            foreach (var adult in file.Adults)
            {
                if (adult.id == deleteAdult.id)
                {
                    file.Adults.Remove(adult);
                    file.SaveChanges();
                    return;
                }
            }
        }

    }
}