using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Task25_01_2022.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        


    }
}
