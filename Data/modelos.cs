// Accidente.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
       // Models/Accidente.cs
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

using System;
public class Accidente
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Descripcion { get; set; }
    public decimal CostoEconomico { get; set; }
    public int Muertos { get; set; }
    public int Heridos { get; set; }
    public int CantidadVehiculos { get; set; }
}
