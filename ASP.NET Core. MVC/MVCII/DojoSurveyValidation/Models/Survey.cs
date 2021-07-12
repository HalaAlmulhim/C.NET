using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        //The following fields are required: Name, Location, Favorite Language
        [Required]
        //Name should be no less than two characters
        [MinLength(2, ErrorMessage = "Name must be no less than two characters")]
        public string Name {set; get;}
        
        [Required]
        public string Location {set; get;}

        [Required]
        public string FavLang {get; set;}
        //Comment isn't required, but if included, should be more than 20 characters
        [MinLength(20, ErrorMessage = "Comment isn't required, but if included, should be more than 20 characters")]
        public string Comment {get; set;}
    }
}