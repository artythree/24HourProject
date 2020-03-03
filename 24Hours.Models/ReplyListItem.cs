using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class ReplyListItem
    {
        public int ReplyId { get; set; }//EAC added this so ReplyServices.cs > GetReplies() ReplyId could refer to this

        [MinLength(1, ErrorMessage = "Please enter at least 1 character.")]
        [MaxLength(1000)]//EAC - confirm with group
        public string Content { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
