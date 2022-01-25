using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task25_01_2022.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string  Icon { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Content { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
