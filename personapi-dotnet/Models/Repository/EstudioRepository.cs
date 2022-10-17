using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class EstudioRepository : IEstudioRepository
    {
        protected readonly persona_dbContext _context;

        public EstudioRepository(persona_dbContext context) => _context = context;
        public async Task<bool> ActualizarEstudioAsync(Estudio Estudio)
        {
            _context.Entry(Estudio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Estudio> CrearEstudioAsync(Estudio Estudio)
        {
            await _context.Set<Estudio>().AddAsync(Estudio);
            await _context.SaveChangesAsync();
            return Estudio;
        }

        public async Task<bool> EliminarEstudioAsync(Estudio Estudio)
        {
            if (Estudio is null)
            {
                return false;
            }
            _context.Set<Estudio>().Remove(Estudio);
            await _context.SaveChangesAsync();

            return true;
        }

        public Estudio ObtenerEstudioById(int id)
        {
            return _context.Estudios.Find(id);
        }

        public IEnumerable<Estudio> ObtenerEstudios()
        {
            return _context.Estudios.ToList();
        }
    }
}
