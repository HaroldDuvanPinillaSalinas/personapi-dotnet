using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IProfesionRepository
    {
        Task<Profesion> CrearProfesionAsync(Profesion Profesion);
        Task<bool> EliminarProfesionAsync(Profesion Profesion);
        Profesion ObtenerProfesionById(int id);
        IEnumerable<Profesion> ObtenerProfesiones();
        Task<bool> ActualizarProfesionAsync(Profesion Profesion);

    }
}
