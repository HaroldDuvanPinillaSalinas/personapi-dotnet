using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface ItelefonoRepository
    {
        Task<Telefono> CrearTelefonoAsync(Telefono telefono);
        Task<bool> EliminarTelefonoAsync(Telefono telefono);
        Telefono ObtenerTelefonoById(int numero);
        IEnumerable<Telefono> ObtenerTelefonos();
        Task<bool> ActualizarTelefonoAsync(Telefono telefono);

    }
}
