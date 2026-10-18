using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Cinema: IEntityBase//model blueprint for adding new cinema when you click on +add new 
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships (one to many: meaning one cinema can produce more than one movies)
        public List<Movie> Movies { get; set; }
    }
}
