using Angelix_Vasquez_P1_Ap1.DAL;
using Angelix_Vasquez_P1_Ap1.Models;
using Microsoft.EntityFrameworkCore;

namespace Angelix_Vasquez_P1_Ap1.Services;

public class Service(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return false;
    }
    private async Task<bool> Insertar()
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();

        return false;
    }
    private async Task<bool> Modificar()
    {
        await using var _context = await DbFactory.CreateDbContextAsync();

        return false;
    }
    public async Task<bool> Guardar()
    {
        return await Insertar();
    }
    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();

        return true;
    }
    public async Task<Modelo?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return null;

    }
    public async Task<Modelo?> BuscarDescripcion(string descripcion)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return null;
    }

    //public async Task<List<Modelo>> Listar(Expression<Func<Modelo, bool>> criterio)
    // {
    //await using var contexto = await DbFactory.CreateDbContextAsync();
}
