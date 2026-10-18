using eTicket.Data.Base;
using eTicket.Models;

namespace eTicket.Data.Services
{
    public class ProducersService:EntityBaseRespository<Producer>,IProducersServices
    {
        public ProducersService(AppDbContext context):base(context) { }
    }
}
