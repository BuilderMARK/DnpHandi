using System.Collections.Generic;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface IAdultService
    {
        IList<Adult> ReadAllAdults();
        void AddAdult(Adult addAdult);
        void UpdateAdult(Adult updateAdult);
        void DeleteAdult(Adult deleteAdult);
    }
}