using System.Collections.Generic;

namespace LoginExample.Models
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Hight { get; set; }
        public string Sex { get; set; }
        List<Person> persons = new List<Person>();
    }}