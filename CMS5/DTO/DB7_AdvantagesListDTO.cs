﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTO
{
    public class DB7_AdvantagesListDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required]
        public string text { get; set; }
        public string additional_text { get; set; }
        public string icon_url { get; set; }

        [ForeignKey("advantages")]
        public int advantages_id { get; set; }
        public virtual DB7_AdvantagesDTO advantages { get; set; }
    }
}
