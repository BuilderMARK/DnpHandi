using System.Text.Json;

namespace LoginExample.Models
{
    public class Adult : Person
    {
        public string Jobtitle { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        
    }
}