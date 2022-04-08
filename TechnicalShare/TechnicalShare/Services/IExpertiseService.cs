using System.Collections.Generic;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public interface IExpertiseService
    {
        List<Expertise> FindAll();
        Expertise FindbyId(int id);
        List<Mentor> FilterById(int id);
    }
}