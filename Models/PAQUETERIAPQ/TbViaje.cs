using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbViaje
{
    public long CveViaje { get; set; }

    public DateTime Fecha { get; set; }

    public int CveCamion { get; set; }

    public int CveOperador { get; set; }

    public int CveRuta { get; set; }

    public bool Liquidado { get; set; }

    public string? NomOperador { get; set; }

    public string? DescCamion { get; set; }

    public double? KmsSale { get; set; }

    public double? KmsLlega { get; set; }

    public double? KmsRecorrido { get; set; }

    public DateTime? Fecha2 { get; set; }

    public DateTime? Fecha3 { get; set; }

    public DateTime? Fecha4 { get; set; }

    public bool? Foraneo { get; set; }

    public byte? CveOfiOri { get; set; }

    public byte? CveOfiDes { get; set; }

    public byte? TipoCarga { get; set; }

    public string? HoraAct { get; set; }

    public int? CveAyudante1 { get; set; }

    public int? CveAyudante2 { get; set; }

    public int? CveAyudante3 { get; set; }

    public string? NomAyudante1 { get; set; }

    public string? NomAyudante2 { get; set; }

    public string? NomAyudante3 { get; set; }

    public int? CveRutaaut { get; set; }

    public long? FolioDisel { get; set; }

    public string? UsuAutoriza { get; set; }

    public int? CveDestino { get; set; }

    public string? DescDestino { get; set; }

    public bool? Recoleccion { get; set; }
}
