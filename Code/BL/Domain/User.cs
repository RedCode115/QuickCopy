using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Email { get; set; }

        public User(int id, string voornaam, string familienaam, string email, DateTime geboortedatum )
        {
            Id = id;
            Voornaam = voornaam;
            Familienaam = familienaam;
            Email = email;
            Geboortedatum = geboortedatum;
        }

        public DateTime Geboortedatum { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User personeel &&
                   Id == personeel.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
