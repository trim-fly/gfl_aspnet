using System;
using Microsoft.EntityFrameworkCore;

namespace forummvc.Models
{
    public class UserData
    {
        public int Id {get; set;}
        public User User {get; set;}
        public int UserId {get; set;}
        public DateTime RegistrationDate {get; set;}
        public string DisplayName {get; set;}
    }
}