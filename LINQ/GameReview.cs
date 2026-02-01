using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class GameReview
    {
        [Required]
        public string Title { get; set; }
        public string Reviewer { get; set; }
    }
}
