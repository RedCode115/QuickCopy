using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain
{
    public class User
    {
        public User(int id, string firstname, string lastname, string email, string userName, string password, DateTime dateOfBirth,
            bool? gender, string country, string mainuse)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            UserName = userName;
            Password = password;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Country = country;
            Hobby = true;
            Mainuse = mainuse;
        }
        public User(int id, string firstname, string lastname, string email, string userName, string password, DateTime dateOfBirth,
            bool? gender, string country, string bussinus, string sector, string position, string mainuse)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            UserName = userName;
            Password = password;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Country = country;
            Hobby = false;
            Bussinuss = bussinus;
            Sector = sector;
            Position = position;
            Mainuse = mainuse;
        }

        private int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string Country { get; set; }
        public bool Hobby { get; set; }
        public string? Bussinuss { get; set; }
        public string? Sector { get; set; }
        public string? Position { get; set; }
        public string Mainuse { get; set; } 

        public override bool Equals(object? obj)
        {
            return obj is User personeel && Id == personeel.Id && Password == personeel.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
