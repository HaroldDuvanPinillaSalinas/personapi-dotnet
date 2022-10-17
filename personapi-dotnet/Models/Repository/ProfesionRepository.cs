using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class ProfesionRepository : IProfesionRepository
    {

        protected readonly persona_dbContext _context;

        public ProfesionRepository(persona_dbContext context) => _context = context;
        public  async Task<bool> ActualizarProfesionAsync(Profesion Profesion)
        {
            _context.Entry(Profesion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true; 
        }

        public async Task<Profesion> CrearProfesionAsync(Profesion Profesion)
        {
            await _context.Set<Profesion>().AddAsync(Profesion);
            await _context.SaveChangesAsync();
            return Profesion;
        }

        public async Task<bool> EliminarProfesionAsync(Profesion Profesion)
        {
            if (Profesion is null)
            {
                return false;
            }
            _context.Set<Profesion>().Remove(Profesion);
            await _context.SaveChangesAsync();

            return true;
        }

        public Profesion ObtenerProfesionById(int id)
        {
            return _context.Profesions.Find(id);
        }

        public IEnumerable<Profesion> ObtenerProfesiones()
        {
            return _context.Profesions.ToList();
        }
    }
}
