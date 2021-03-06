using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtMuseum
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists(bool trackChanges);
    }
}
