using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIAPQ;

public partial class TbEmpleado
{
    public int CveEmpleado { get; set; }

    public string NomEmpleado { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Rfc { get; set; }

    public string? Direccion { get; set; }

    public byte Tipo { get; set; }

    public double? Saldo { get; set; }

    public string? CuentaContable { get; set; }

    public double? Recoleccion { get; set; }

    public bool? Activo { get; set; }

    public string? Nss { get; set; }

    public string? Tels { get; set; }

    public byte? CvePuesto { get; set; }

    public string? Foto { get; set; }

    public long? NumNomina { get; set; }

    public DateTime? FechaIng { get; set; }

    public byte? CveOficina { get; set; }

    public bool? PagoXviaje { get; set; }

    public double? SalarioInt { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaBajaSis { get; set; }

    public double? SalarioDiario { get; set; }

    public int? TipoSueldo { get; set; }

    public int? CveUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public int? CveUsuBaja { get; set; }

    public string? NomUsuBaja { get; set; }

    public int? CveUsuReactiva { get; set; }

    public string? NomUsuReactiva { get; set; }

    public double? Percepcion { get; set; }

    public double? Deduccion { get; set; }

    public int? DiasSal { get; set; }

    public int? CveDepto { get; set; }

    public double? Infonavit { get; set; }

    public string? Licencia { get; set; }

    public DateTime? Vigencialic { get; set; }

    public bool? RecibeMcia { get; set; }

    public bool? Supervisor { get; set; }

    public int? CveSupervisor { get; set; }

    public string? NomSupervisor { get; set; }

    public string? Cuadrante { get; set; }

    public int? DiasVac { get; set; }

    public int? CveOperador { get; set; }

    public double? MontoXkm { get; set; }

    public bool? DescNomLiq { get; set; }

    public int? CveEmpresa { get; set; }

    public string? Celular { get; set; }

    public byte? TipoLic { get; set; }

    public string? IdAppEnt { get; set; }

    public bool? Paqueteria { get; set; }

    public bool? Trafico { get; set; }

    public decimal? OrdenOper { get; set; }

    public bool? Recolecta { get; set; }

    public string? AptoMedico { get; set; }

    public DateOnly? VigenciaAptoMedico { get; set; }

    public string? CelularPersonal { get; set; }

    public byte? CveMotivoBaja { get; set; }

    public string? DescMotivoBaja { get; set; }

    public bool? ProbLaboral { get; set; }

    public DateOnly? FechaAudiencia { get; set; }

    public string? LicProbLaboral { get; set; }

    public string? ExpProbLaboral { get; set; }

    public bool? Prebaja { get; set; }

    public DateTime? FechaPreBaja { get; set; }

    public string? NomUsuPreBaja { get; set; }

    public byte[]? Pdfexp { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly? FechaAudienciaUlt { get; set; }

    public string? Colonia { get; set; }

    public string? Cp { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public string? CveColonia { get; set; }

    public string? CveLocalidad { get; set; }

    public string? CveMunicipio { get; set; }

    public string? CveEstado { get; set; }

    public string? NomLocalidad { get; set; }

    public string? NomMunicipio { get; set; }

    public string? NomEstado { get; set; }

    public string? DirFotosGuias { get; set; }

    public bool? AppComanda { get; set; }

    public DateOnly? FechaAppComanda { get; set; }
}
