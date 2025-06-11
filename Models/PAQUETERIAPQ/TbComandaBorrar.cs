using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbComandaBorrar
{
    public long CveComanda { get; set; }

    public long? Rampa { get; set; }

    public long? Camara { get; set; }

    public byte[]? Foto { get; set; }

    public bool? Recoleccion { get; set; }

    public int? CveCamion { get; set; }

    public int? CveOperador { get; set; }

    public string? NomOperador { get; set; }

    public bool? Estibable { get; set; }

    public bool? MciaCondicion { get; set; }

    public string? Condiciones { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public DateTime? Fecha { get; set; }
}
