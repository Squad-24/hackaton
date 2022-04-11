using System.Collections.Generic;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public interface IMentorService
    {
        void Insert(Mentor obj);
        List<Mentor> FindAll();
        List<Mentor> FilterById(int Id);
        Mentor FindbyId(int id);
    }
}