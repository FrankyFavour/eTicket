using eTicket.Data.Base;
using eTicket.Models;
using System;

namespace eTicket.Data.Services
{
    public interface IActorsService:IEntityBaseRespository<Actor> /* a "to-do list" for any class that
    wants to manage actor data instead of using the AppDbcontext(kinda same function)*/
    {
        //Task <IEnumerable<Actor>> GetAllAsync(); //To make it async
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);
        //Task DeleteAsync(int id);
    }
}
