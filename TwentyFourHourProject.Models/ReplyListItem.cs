using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;

namespace TwentyFourHourProject.Models
{
    public class ReplyListItem
    {
        public Comment ReplyComment { get; }

        [MinLength(1, ErrorMessage = "Please enter at least 1 character.")]
        [MaxLength(1000)]//EAC - confirm with group
        public string Content { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
