using BandAPI.ValiDationsAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Models
{
    [TitleAndDecription(ErrorMessage = "Title Must Be Different From Description")]
    public class AlbumForCreatingDto // : IValidatableObject
    {
        [Required(ErrorMessage ="Title Needs To Be Filled In")]
         [MaxLength(200, ErrorMessage ="Title Needs To Be Up To 200 Characters"), MinLength(5, ErrorMessage = "Title Needs To Be down To 5 Characters")]
        public string Title { get; set; }
        [MaxLength(400), MinLength(20)]
        public string Description { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //        yield return new  ValidationResult("The Title And Desctiption Need To Be Different",
        //            new[] { "AlbumForCreatingDto" });

        //    }
        //}
    }
}
