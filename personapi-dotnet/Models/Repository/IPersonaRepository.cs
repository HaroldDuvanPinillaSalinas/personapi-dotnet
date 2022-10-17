﻿using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IPersonaRepository
    {
        Task<Persona> CrearPersonaAsync(Persona persona);
        Task<bool> EliminarPersonaAsync(Persona persona);
        Persona ObtenerPersonaById(int id);
        IEnumerable<Persona> ObtenerPersonas();
        Task<bool> ActualizarPersonaAsync(Persona persona);
    }
}