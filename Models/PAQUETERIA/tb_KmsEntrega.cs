using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.PAQUETERIA;

public partial class tb_KmsEntrega
{
    public int cve_oficinaOri { get; set; }

    public int cve_CiudadDes { get; set; }

    public int? Kms { get; set; }
}
