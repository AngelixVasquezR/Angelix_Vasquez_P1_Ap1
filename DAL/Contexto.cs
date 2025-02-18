using Angelix_Vasquez_P1_Ap1.Models;
using Microsoft.EntityFrameworkCore;

namespace Angelix_Vasquez_P1_Ap1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }


    public DbSet<Aportes> Aportes { get; set; }
    





}
