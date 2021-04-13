using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Models
{
    public class UserData
    {
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Username { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string Password { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string Sex { get; set; }
        [Range(8, 130)]
        public int Age { get; set; }
        public string State { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Score { get; set; }

        public UserData()
        {

        }

        public UserData(string u, string p, int s)
        {
            Username = u;
            Password = p;
            Score = s;
        }

        public UserData(string username, string password, string firstName, string lastName, string sex, int age, string state, string email, int score)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            State = state;
            Email = email;
            Score = score;
        }
    }
}
