using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_Empleado
{
    public int Cve_empleado { get; set; }

    public string nom_empleado { get; set; } = null!;

    public string apellido { get; set; } = null!;

    public string? rfc { get; set; }

    public string? direccion { get; set; }

    public byte tipo { get; set; }

    public double? Saldo { get; set; }

    public string? Cuenta_contable { get; set; }

    public double? recoleccion { get; set; }

    public bool? ACTIVO { get; set; }

    public string? NSS { get; set; }

    public string? TELS { get; set; }

    public byte? CVE_PUESTO { get; set; }

    public string? FOTO { get; set; }

    public long? NUM_NOMINA { get; set; }

    public DateTime? FECHA_ING { get; set; }

    public byte? CVE_OFICINA { get; set; }

    public bool? PagoXViaje { get; set; }

    public double? SalarioInt { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaBajaSis { get; set; }

    public double? SalarioDiario { get; set; }

    public int? TipoSueldo { get; set; }

    public int? cve_usuario { get; set; }

    public string? nom_usuario { get; set; }

    public int? cve_usuBaja { get; set; }

    public string? nom_usuBaja { get; set; }

    public int? cve_usuReactiva { get; set; }

    public string? nom_usuReactiva { get; set; }

    public double? PERCEPCION { get; set; }

    public double? DEDUCCION { get; set; }

    public int? DiasSal { get; set; }

    public int? CVE_DEPTO { get; set; }

    public double? INFONAVIT { get; set; }

    public string? LICENCIA { get; set; }

    public DateTime? VIGENCIALIC { get; set; }

    public bool? RecibeMcia { get; set; }

    public bool? Supervisor { get; set; }

    public int? cve_supervisor { get; set; }

    public string? nom_supervisor { get; set; }

    public string? cuadrante { get; set; }

    public int? DiasVac { get; set; }

    public int? CVE_OPERADOR { get; set; }

    public double? MontoXKm { get; set; }

    public bool? DescNomLiq { get; set; }

    public int? cve_empresa { get; set; }

    public string? celular { get; set; }

    public byte? TipoLic { get; set; }

    public string? IdAppEnt { get; set; }

    public bool? Paqueteria { get; set; }

    public bool? Trafico { get; set; }

    public decimal? OrdenOper { get; set; }

    public bool? Recolecta { get; set; }

    public string? AptoMedico { get; set; }

    public DateOnly? VigenciaAptoMedico { get; set; }

    public string? CelularPersonal { get; set; }

    public byte? cve_MotivoBaja { get; set; }

    public string? desc_MotivoBaja { get; set; }

    public bool? ProbLaboral { get; set; }

    public DateOnly? FechaAudiencia { get; set; }

    public string? LicProbLaboral { get; set; }

    public string? ExpProbLaboral { get; set; }

    public bool? Prebaja { get; set; }

    public DateTime? FechaPreBaja { get; set; }

    public string? NomUsu_PreBaja { get; set; }

    public byte[]? PDFExp { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly? FechaAudienciaUlt { get; set; }

    public string? colonia { get; set; }

    public string? cp { get; set; }

    public string? NUMEXT { get; set; }

    public string? NUMINT { get; set; }

    public string? Cve_Colonia { get; set; }

    public string? Cve_Localidad { get; set; }

    public string? Cve_Municipio { get; set; }

    public string? Cve_Estado { get; set; }

    public string? Nom_Localidad { get; set; }

    public string? Nom_Municipio { get; set; }

    public string? Nom_Estado { get; set; }

    public string? DirFotosGuias { get; set; }

    public bool? AppComanda { get; set; }

    public DateOnly? FechaAppComanda { get; set; }
}
