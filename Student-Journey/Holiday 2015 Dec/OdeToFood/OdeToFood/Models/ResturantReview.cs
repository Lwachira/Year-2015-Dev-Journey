using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class ResturantReview
    {

        public int Id { get; set; }
        [Range(1, 10)]
        [Required]
        public int Rating { get; set; }

        [Required(ErrorMessageResourceType = typeof(Views.Home.Resource),ErrorMessageResourceName ="Greeting")]
        [StringLength(1024)]
        public string Body { get; set; }

        [Display(Name = "User Name")]
        [DisplayFormat(NullDisplayText = "Anonymous")]
        public string ReviewerName { get; set; }

        
        public int RestaurantId { get; set; }




    }
}
