using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;

namespace TwentyFourHourProject.Models
{
    public class ReplyCreate
    {
        [MinLength(1, ErrorMessage = "Please enter at least 1 character.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        public string Content { get; set; }
        public Comment ReplyComment { get; }
    }
}
