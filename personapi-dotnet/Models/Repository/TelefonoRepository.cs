using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class TelefonoRepository : ItelefonoRepository
    {
        protected readonly persona_dbContext _context;
        public TelefonoRepository(persona_dbContext context) => _context = context;

        public async Task<bool> ActualizarTelefonoAsync(Telefono telefono)
        {
            _context.Entry(telefono).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Telefono> CrearTelefonoAsync(Telefono telefono)
        {
            await _context.Set<Telefono>().AddAsync(telefono);
            await _context.SaveChangesAsync();
            return telefono;
        }

        public async Task<bool> EliminarTelefonoAsync(Telefono telefono)
        {
            if (telefono is null)
            {
                return false;
            }
            _context.Set<Telefono>().Remove(telefono);
            await _context.SaveChangesAsync();

            return true;
        }

        public Telefono ObtenerTelefonoById(int numero)
        {
            return _context.Telefonos.Find(numero);
        }

        public IEnumerable<Telefono> ObtenerTelefonos()
        {
            return _context.Telefonos.ToList();
        }
    }
}
