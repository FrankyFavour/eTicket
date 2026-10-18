using eTicket.Data.Base;
using eTicket.Models;

namespace eTicket.Data.Services
{
    public class CinemasService:EntityBaseRespository<Cinema>,ICinemasService
    {
        public CinemasService(AppDbContext context):base(context) { }
    }
}
