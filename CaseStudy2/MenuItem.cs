using System;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy2
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Free Delivery")]
        public Boolean freeDelivery { get; set; }

        [Required]
        public double Price { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfLaunch { get; set; }

        public Boolean Active { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
