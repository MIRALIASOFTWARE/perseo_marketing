using System;
using System.Collections.Generic;
using System.Text;

namespace PerseoMarketing.Core.Entities
{
    public class LogPublicacion
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AnuncioId { get; set; }
        public Guid GrupoId { get; set; }

        public string TextoGeneradoIA { get; set; } = string.Empty; // Muestra la variación de Ollama
        public DateTime FechaEjecucion { get; set; } = DateTime.UtcNow;
        public bool Exitoso { get; set; }
        public string? MensajeError { get; set; }
    }
}
