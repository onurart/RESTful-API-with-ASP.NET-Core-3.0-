using BandAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.ValiDationsAttributes
{
         [TitleAndDecriptionAttribute]
    public class TitleAndDecriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var album = (AlbumForCreatingDto)validationContext.ObjectInstance;
            if(album.Title == album.Description)
            {
                return new ValidationResult("The Title And The  Description Need To Be Different", new[] { "AlbumForCreatingDto" });

            }
            return ValidationResult.Success;
        }

    }
}
