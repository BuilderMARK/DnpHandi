using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace ToDo.Data
{
    public interface IAdultService
    {
        Task <IList<Adult>> ReadAllAdults();
        Task  AddAdult(Adult addAdult);
        Task UpdateAdult(Adult updateAdult);
        Task DeleteAdult(int deleteAdult); 
    }
    }