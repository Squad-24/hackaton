using System.Collections.Generic;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public interface IMentorService
    {
        Mentor AddMentor(Mentor mentor);
        List<Mentor> FindAll();
        List<Mentor> FilterById(int Id);
        Mentor FindbyId(int id);
    }
}