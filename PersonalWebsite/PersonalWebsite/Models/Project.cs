using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class Project
    {
        [Key, Required]
        int ID { get; set; }


        [StringLength(maximumLength: 64), Required]
        public string Title { get; set; }

        [StringLength(maximumLength: 1024)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Display(Name = "GitHub Link")]
        public string GitHubLink { get; set; }

        [Display(Name = "YouTube Link")]
        public string YoutubeLink { get; set; }

    }
}
