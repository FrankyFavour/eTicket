using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor: IEntityBase //model blueprint for adding new actor when you click on +add new 
    {
        [Key]
        public int Id { get; set; }

        [Display (Name = "Profile Picture URL")]
        [Required (ErrorMessage = "Please provide a Picture")]
        public string ProfilePictureURL { get; set; }

        [Display (Name ="FullName")]
        [Required(ErrorMessage = "Please provide the FullName")]
        [StringLength (15,MinimumLength = 3, ErrorMessage ="The Name show be between 3 to 15 chars")]
        public string FullName { get; set; }

        [Display (Name = "Bio")]
        [Required(ErrorMessage = "Please provide the Biography")]
        public string Bio { get; set; }

        //Relationships (many to many: meaning actors can produce more than one movies)
        //so what we did here is to create model for the many to many(actor_movie) and connect it to the model
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
