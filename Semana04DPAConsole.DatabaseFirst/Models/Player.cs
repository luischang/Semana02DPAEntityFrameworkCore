using System;
using System.Collections.Generic;

namespace Semana04DPAConsole.DatabaseFirst.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Dorsal { get; set; }
        public bool? Status { get; set; }
        public int? TeamId { get; set; }
        public string? Country { get; set; }

        public virtual Team? Team { get; set; }
    }
}
