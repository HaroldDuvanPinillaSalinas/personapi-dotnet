using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        protected readonly persona_dbContext _context;

        public PersonaRepository(persona_dbContext context) => _context = context;


        public IEnumerable<Persona> ObtenerPersonas()
        {
            return _context.Personas.ToList();
        }

        public async Task<bool> ActualizarPersonaAsync(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Persona> CrearPersonaAsync(Persona persona)
        {
            await _context.Set<Persona>().AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task<bool> EliminarPersonaAsync(Persona persona)
        {
            if (persona is null)
            {
                return false;
            }
            _context.Set<Persona>().Remove(persona);
            await _context.SaveChangesAsync();

            return true;
        }

        public Persona ObtenerPersonaById(int id)
        {
            return _context.Personas.Find(id);
        }
    }
}
