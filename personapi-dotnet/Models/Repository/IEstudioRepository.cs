using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IEstudioRepository
    {
        Task<Estudio> CrearEstudioAsync(Estudio Estudio);
        Task<bool> EliminarEstudioAsync(Estudio Estudio);
        Estudio ObtenerEstudioById(int id);
        IEnumerable<Estudio> ObtenerEstudios();
        Task<bool> ActualizarEstudioAsync(Estudio Estudio);
    }
}
