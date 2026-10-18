using eTicket.Data.Base;
using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsService : EntityBaseRespository<Actor>, IActorsService /*to use the interface*/
    {
        private readonly AppDbContext _context; //we need the AppDbcontext here to be able to work with the Database which is no longer in the ActorsController cos it not good practice
        public ActorsService(AppDbContext context) : base(context) { }

        //    public async Task AddAsync(Actor actor) we are now using entityBaseRepo 
        //    {
        //        _context.Actors.Add(actor);
        //        await _context.SaveChangesAsync();
        //    }

        //    public async Task DeleteAsync(int id) // to remove the actor
        //    {
        //        var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        //        _context.Actors.Remove(result);
        //        await _context.SaveChangesAsync();
        //    }
        //    public async Task<IEnumerable<Actor>> GetAllAsync() //To make it Async...it was later commented out because it will be in
        //    //EntityBaseRespository which will make all the model have this feature
        //    {
        //        var result = await _context.Actors.ToListAsync();// to get the data
        //        return result;
        //    }

        //    public async Task<Actor> GetByIdAsync(int id)// it was later commented out because it will be in
        //   // EntityBaseRespository which will make all the model have this feature (tried commenting out but 
        //   // gave me error but in the video is cut it out same with GetAllAsync)
        //    {
        //        var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);// to get the data
        //        return result;
        //}


        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    //first get the actor
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync();
        //    return newActor;
        //} //    public async Task AddAsync(Actor actor)
        //    {
        //        _context.Actors.Add(actor);
        //        await _context.SaveChangesAsync();
        //    }

        //    public async Task DeleteAsync(int id) // to remove the actor
        //    {
        //        var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        //        _context.Actors.Remove(result);
        //        await _context.SaveChangesAsync();
        //    }
        //    public async Task<IEnumerable<Actor>> GetAllAsync() //To make it Async...it was later commented out because it will be in
        //    //EntityBaseRespository which will make all the model have this feature
        //    {
        //        var result = await _context.Actors.ToListAsync();// to get the data
        //        return result;
        //    }

        //    public async Task<Actor> GetByIdAsync(int id)// it was later commented out because it will be in
        //   // EntityBaseRespository which will make all the model have this feature (tried commenting out but 
        //   // gave me error but in the video is cut it out same with GetAllAsync)
        //    {
        //        var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);// to get the data
        //        return result;
        //}


        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    //first get the actor
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync();
        //    return newActor;
        //}
    }
}
