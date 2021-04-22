using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IActorsManager
    {
        public Task<IEnumerable<Actors>> GetAllActors();
        public Task<IEnumerable<string>> GetActorsByMovie(string movieName);
    }
}
