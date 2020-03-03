using System.Collections.Generic;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }//ligando con todas las prop de usuarios

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}