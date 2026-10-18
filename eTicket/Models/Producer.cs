using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer: IEntityBase //model blueprint for adding new producer when you click on +add new 
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "Picture Required")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Full Name Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bio Required")]
        public string Bio { get; set; }

        //Relationships (one to many: meaning producer can produce more than one movies)
        public List<Movie> Movies { get; set; }
    }
}
