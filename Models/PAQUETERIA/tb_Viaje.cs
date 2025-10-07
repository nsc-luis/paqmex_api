using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Viaje
{
    public long cve_viaje { get; set; }

    public DateTime Fecha { get; set; }

    public int Cve_camion { get; set; }

    public int Cve_Operador { get; set; }

    public int Cve_Ruta { get; set; }

    public bool Liquidado { get; set; }

    public string? nom_operador { get; set; }

    public string? desc_camion { get; set; }

    public double? KmsSale { get; set; }

    public double? KmsLlega { get; set; }

    public double? KmsRecorrido { get; set; }

    public DateTime? FECHA2 { get; set; }

    public DateTime? FECHA3 { get; set; }

    public DateTime? FECHA4 { get; set; }

    public bool? FORANEO { get; set; }

    public byte? cve_OfiOri { get; set; }

    public byte? cve_OfiDes { get; set; }

    public byte? TipoCarga { get; set; }

    public string? HoraAct { get; set; }

    public int? CVE_AYUDANTE1 { get; set; }

    public int? CVE_AYUDANTE2 { get; set; }

    public int? CVE_AYUDANTE3 { get; set; }

    public string? nom_AYUDANTE1 { get; set; }

    public string? nom_AYUDANTE2 { get; set; }

    public string? nom_AYUDANTE3 { get; set; }

    public int? CVE_RUTAAUT { get; set; }

    public long? FolioDisel { get; set; }

    public string? UsuAutoriza { get; set; }

    public int? CVE_DESTINO { get; set; }

    public string? DESC_DESTINO { get; set; }

    public bool? Recoleccion { get; set; }
}
