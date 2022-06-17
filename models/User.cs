using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo name é obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo email é obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo password é obrigatorio")]
        public string Password { get; set; }
    }
}