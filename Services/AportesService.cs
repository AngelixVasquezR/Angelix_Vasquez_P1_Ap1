using Angelix_Vasquez_P1_Ap1.DAL;
using Angelix_Vasquez_P1_Ap1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Angelix_Vasquez_P1_Ap1.Services
{
    public class AportesService
    {
        private readonly IDbContextFactory<Contexto> _dbFactory;

        public AportesService(IDbContextFactory<Contexto> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<bool> Existe(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Aportes.AnyAsync(c => c.AporteId == id);
        }

        private async Task<bool> Insertar(Aportes aporte)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            contexto.Aportes.Add(aporte);
            return await contexto.SaveChangesAsync() > 0;
        }

        private async Task<bool> Modificar(Aportes aporte)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            contexto.Aportes.Update(aporte);
            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Aportes aporte)
        {

            if (!await Existe(aporte.AporteId))
                return await Insertar(aporte);
            else
                return await Modificar(aporte);
        }

        public async Task<bool> Eliminar(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            var aporte = await contexto.Aportes.FindAsync(id);
            if (aporte == null) return false;

            contexto.Aportes.Remove(aporte);
            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<Aportes?> Buscar(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Aportes.AsNoTracking()
                .FirstOrDefaultAsync(i => i.AporteId == id);
        }

        public async Task<List<Aportes>> Listar(Expression<Func<Aportes, bool>> criterio)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Aportes.AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}