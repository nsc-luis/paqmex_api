using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbOficina
{
    public byte CveOficina { get; set; }

    public string DescOficina { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CveCiudad { get; set; }

    public int CveEstado { get; set; }

    public string? CuentaIva { get; set; }

    public int? PesoMin { get; set; }

    public double ImporteMin { get; set; }

    public double CuotaTonelada { get; set; }

    public double CuotaForanea { get; set; }

    public bool Matriz { get; set; }

    public string? Tels { get; set; }

    public long ConsecNc { get; set; }

    public long ConsecComanda { get; set; }

    public bool Activo { get; set; }

    public int PrefijoCamion { get; set; }

    public byte Grupo { get; set; }

    public int? CveUsuGerente { get; set; }

    public int? CveUsuAutViaje { get; set; }

    public int? CveConceptoGto { get; set; }

    public string? Prefijo { get; set; }

    public int? CveSeriefac { get; set; }

    public int? CveSerienc { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public string? Colonia { get; set; }

    public string? Cp { get; set; }

    public int? CveSerieNca { get; set; }

    public string? Servidor { get; set; }

    public byte? CveEstatuscob { get; set; }

    public int? Main { get; set; }

    public int? CveDestino { get; set; }

    public string? Abreviatura { get; set; }

    public long? CveSerieFac2 { get; set; }

    public long? CveSerieNc2 { get; set; }

    public int? CveSerieSus { get; set; }

    public double? PesoMinRe { get; set; }

    public double? PesoMinFlete { get; set; }

    public double? Recol { get; set; }

    public double? Entrega { get; set; }

    public double? PorcRecol { get; set; }

    public double? PorcEntrega { get; set; }

    public byte? CveOriTarKgs { get; set; }

    public byte? OrdenCtrlDiso { get; set; }

    public string? CveNomina { get; set; }

    public int? DepNomina { get; set; }

    public string? CuentaEmp { get; set; }

    public int? CveEmpresa { get; set; }

    public int? CveRespCont { get; set; }

    public string? NomRespCont { get; set; }

    public bool? Pagina { get; set; }

    public string? NomOficinaPag { get; set; }

    public byte? Clasif { get; set; }

    public byte? OrdenRep { get; set; }

    public int? CveZona { get; set; }

    public byte? OrdenVtasDest { get; set; }

    public bool? MapaPortal { get; set; }

    public string? DirPortal { get; set; }

    public bool? OrigenPortal { get; set; }

    public string? NomPortal { get; set; }

    public int? CantOper { get; set; }

    public int? CveZonahorario { get; set; }

    public int? CveSerieVal { get; set; }

    public double? KgMinSemana { get; set; }

    public double? KgMinSabado { get; set; }

    public int? UnidadesReq { get; set; }

    public int? EstatusCobro { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public int? CveEmpRep { get; set; }

    public int? RecolPortal { get; set; }

    public string? CveSatColonia { get; set; }

    public string? CveSatLocalidad { get; set; }

    public string? CveSatMunicipio { get; set; }

    public string? CveSatEstado { get; set; }
}
