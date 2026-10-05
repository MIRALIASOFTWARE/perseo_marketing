using System;
using System.Collections.Generic;
using System.Text;

namespace PerseoMarketing.Core.Entities;

public class Anuncio
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid? ClienteId { get; set; }
    public Guid? UsuarioId { get; set; }

    public string TextoOriginal { get; set; } = string.Empty;
    public string Estado { get; set; } = "Programado"; // Programado, EnProceso, Finalizado
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public ICollection<LogPublicacion> HistorialPublicaciones { get; set; } = new List<LogPublicacion>();
}

