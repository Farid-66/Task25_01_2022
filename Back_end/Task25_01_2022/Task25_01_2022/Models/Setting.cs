using System.ComponentModel.DataAnnotations;

namespace Task25_01_2022.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; } 
        [MaxLength(20)]
        public string LogoName { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Info { get; set; }
    }
}
