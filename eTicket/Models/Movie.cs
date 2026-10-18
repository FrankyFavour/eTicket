using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTicket.Data;

namespace eTicket.Models
{
    public class Movie //model blueprint for adding new cinema when you click on +add new 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageFile  { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships (many to many: meaning movies can produce more by many actors )
        //so what we did here is to create model for the many to many(Actors_Movie) and connect it to the model
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema (one to many: meaning)
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer (one to many)
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer producer { get; set; }
    }
}

