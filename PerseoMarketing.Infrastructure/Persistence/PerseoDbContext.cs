using Microsoft.EntityFrameworkCore;
using PerseoMarketingCore.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace PerseoMarketing.Infrastructure.Persistence;

public class PerseoDbContext : DbContext
{
    public PerseoDbContext(DbContextOptions<PerseoDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<GrupoFacebook> GruposFacebook => Set<GrupoFacebook>();
    public DbSet<Anuncio> Anuncios => Set<Anuncio>();
    public DbSet<LogPublicacion> LogsPublicacion => Set<LogPublicacion>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Escanea y aplica automáticamente todas las configuraciones en esta capa
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}