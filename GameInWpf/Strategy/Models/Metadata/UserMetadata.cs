using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Metadata
{
    public class UserMetadata
    {
        [Required, MaxLength(50)]
        public string? Login { get; set; }
        [Required, MaxLength(50)]
        public string? Password { get; set; }
    }
}
