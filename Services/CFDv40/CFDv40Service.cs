using PAQMEX_API.Models.PAQUETERIAPQ;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using XSDToXML.Utils;

namespace PAQMEX_API.Services.CFDv40
{
    public class CFDv40Service : ICFDv40Service
    {
        static string pathXML = $"{Environment.CurrentDirectory}\\Temp\\CFDv40.xml";
        static string pathCer = $"{Environment.CurrentDirectory}\\Certificados\\CSD_Sucursal_1_EKU9003173C9_20230517_223850.cer";
        static string pathKey = $"{Environment.CurrentDirectory}\\Certificados\\CSD_Sucursal_1_EKU9003173C9_20230517_223850.key";
        static string clavePrivada = "12345678a";

        public void GeneraCFDv40(Comprobante comprobante)
        {
            //Inicializa objetos
            Comprobante oComprobante = new Comprobante();
            List<ComprobanteConcepto> lstConceptos = new List<ComprobanteConcepto>();
            List<ComprobanteConceptoImpuestosTraslado> comprobanteConceptoImpuestosTraslados = new List<ComprobanteConceptoImpuestosTraslado>();

            //Creando nodo de conceptos desde cada partida del formulario
            foreach (ComprobanteConcepto concepto in comprobante.Conceptos)
            {
                ComprobanteConcepto oConcepto = new ComprobanteConcepto
                {
                    //Campos desde el formulario
                    ClaveProdServ = concepto.ClaveProdServ,
                    Cantidad = concepto.Cantidad,
                    ClaveUnidad = concepto.ClaveUnidad,
                    Descripcion = concepto.Descripcion,
                    ValorUnitario = concepto.ValorUnitario,
                    Descuento = concepto.Descuento,
                    DescuentoSpecified = concepto.Descuento > 0 ? true : false,
                    Importe = (concepto.ValorUnitario - concepto.Descuento) * concepto.Cantidad,
                    ObjetoImp = c_ObjetoImp.Item02
                };

                //Creando nodo de traslado de impuestos a nivel de partida
                ComprobanteConceptoImpuestosTraslado comprobanteConceptoImpuestosTraslado = new ComprobanteConceptoImpuestosTraslado();
                comprobanteConceptoImpuestosTraslado.Impuesto = c_Impuesto.Item002;
                comprobanteConceptoImpuestosTraslado.Base = oConcepto.Importe;
                comprobanteConceptoImpuestosTraslado.TasaOCuota = 0.160000m;
                comprobanteConceptoImpuestosTraslado.TipoFactor = c_TipoFactor.Tasa;
                comprobanteConceptoImpuestosTraslado.Importe = comprobanteConceptoImpuestosTraslado.Base * comprobanteConceptoImpuestosTraslado.TasaOCuota;
                comprobanteConceptoImpuestosTraslados.Add(comprobanteConceptoImpuestosTraslado);

                //Creando nodo de impuestos a nivel de concepto
                ComprobanteConceptoImpuestos comprobanteConceptoImpuestos = new ComprobanteConceptoImpuestos();
                comprobanteConceptoImpuestos.Traslados = comprobanteConceptoImpuestosTraslados.ToArray();
                oConcepto.Impuestos = comprobanteConceptoImpuestos;

                //Agregando concepto al listado de conceptos
                lstConceptos.Add(oConcepto);
            }
            oComprobante.Conceptos = lstConceptos.ToArray();

            //Creando nodo de traslado de impuestos a nivel de comprobante
            List<ComprobanteImpuestosTraslado> comprobanteImpuestosTraslados = new List<ComprobanteImpuestosTraslado>();
            ComprobanteImpuestosTraslado comprobanteImpuestosTraslado002 = new ComprobanteImpuestosTraslado
            {
                Base = 0.00m,
                Importe = 0.00m,
                Impuesto = c_Impuesto.Item002,
                TasaOCuota = 0.16000m,
                TipoFactor = c_TipoFactor.Tasa
            };
            foreach (ComprobanteConceptoImpuestosTraslado ccit in comprobanteConceptoImpuestosTraslados)
            {
                if (ccit.Impuesto == c_Impuesto.Item002)
                {
                    comprobanteImpuestosTraslado002.Base = comprobanteImpuestosTraslado002.Base + ccit.Base;
                    comprobanteImpuestosTraslado002.Importe = comprobanteImpuestosTraslado002.Importe + ccit.Importe;
                }
            }
            comprobanteImpuestosTraslados.Add(comprobanteImpuestosTraslado002);

            //Creando nodo de impuestos a nivel de comprobante
            ComprobanteImpuestos impuestos = new ComprobanteImpuestos();
            impuestos.TotalImpuestosTrasladados = comprobanteImpuestosTraslado002.Importe;
            impuestos.Traslados = comprobanteImpuestosTraslados.ToArray();
            oComprobante.Impuestos = impuestos;

            //Obteniendo Numero de certificado
            string noCertificado, a, b, c;
            SelloDigital.leerCER(pathCer, out a, out b, out c, out noCertificado);

            //Poblando la clase COMPROBANTE con JSON del formulario
            //Campos estaticos
            oComprobante.Version = "4.0";
            oComprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            oComprobante.NoCertificado = noCertificado;
            //Campos desde el formulario
            oComprobante.LugarExpedicion = comprobante.LugarExpedicion;
            oComprobante.CondicionesDePago = comprobante.CondicionesDePago;
            //Campos desde el formulario obtenidos con base de datos
            oComprobante.FormaPago = c_FormaPago.Item01;
            oComprobante.Moneda = c_Moneda.MXN;
            oComprobante.Exportacion = c_Exportacion.Item01;
            oComprobante.TipoDeComprobante = c_TipoDeComprobante.I;
            oComprobante.MetodoPago = c_MetodoPago.PUE;
            //Campos calculados
            oComprobante.SubTotal = lstConceptos.Sum(concepto => concepto.ValorUnitario * concepto.Cantidad);
            oComprobante.Descuento = lstConceptos.Sum(conceptos => conceptos.Descuento * conceptos.Cantidad);
            oComprobante.DescuentoSpecified = oComprobante.Descuento > 0 ? true : false;
            oComprobante.Total = comprobanteConceptoImpuestosTraslados.Sum(impTrans => impTrans.Base) - comprobanteConceptoImpuestosTraslados.Sum(impTrans => impTrans.Importe);

            ComprobanteEmisor oEmisor = new ComprobanteEmisor();
            //Campos desde el formulario
            oEmisor.Rfc = comprobante.Emisor.Rfc;
            oEmisor.Nombre = comprobante.Emisor.Nombre;
            oEmisor.RegimenFiscal = comprobante.Emisor.RegimenFiscal;

            ComprobanteReceptor oReceptor = new ComprobanteReceptor();
            //Campos desde el formulario
            oReceptor.Nombre = comprobante.Receptor.Nombre;
            oReceptor.Rfc = comprobante.Receptor.Rfc;
            oReceptor.UsoCFDI = comprobante.Receptor.UsoCFDI;
            oReceptor.RegimenFiscalReceptor = comprobante.Receptor.RegimenFiscalReceptor;
            oReceptor.DomicilioFiscalReceptor = comprobante.Receptor.DomicilioFiscalReceptor;

            //asigno emisor y receptor
            oComprobante.Emisor = oEmisor;
            oComprobante.Receptor = oReceptor;


            GeneraXML(oComprobante);

            string cadenaOriginal = "";
            string pathXslt = $"{Environment.CurrentDirectory}\\Helpers\\cadenaoriginal_4_0.xslt";

            System.Xml.Xsl.XslCompiledTransform transform = new System.Xml.Xsl.XslCompiledTransform(true);
            transform.Load(pathXslt, new XsltSettings(true, true), new XmlUrlResolver());

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xwo = XmlWriter.Create(sw, transform.OutputSettings))
                {
                    transform.Transform(pathXML, xwo);
                    cadenaOriginal = sw.ToString();
                }
            }
            //Generamos el sello digital
            SelloDigital oSelloDigital = new SelloDigital();
            oComprobante.Certificado = oSelloDigital.Certificado(pathCer);
            oComprobante.Sello = oSelloDigital.Sellar(cadenaOriginal, pathKey, clavePrivada);

            GeneraXML(oComprobante);
        }

        public void GeneraXML(Comprobante oComprobante)
        {
            XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
            xmlSerializerNamespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            xmlSerializerNamespaces.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");
            xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-Instance");

            XmlSerializer oXmlSerializar = new XmlSerializer(typeof(Comprobante));
            string sXml = "";

            using (var sww = new StringWriterWithEncoding(System.Text.Encoding.UTF8))
            {
                using (XmlWriter writter = XmlWriter.Create(sww))
                {

                    oXmlSerializar.Serialize(writter, oComprobante, xmlSerializerNamespaces);
                    sXml = sww.ToString();
                }

            }

            //guardamos el string en un archivo
            System.IO.File.WriteAllText(pathXML, sXml);
        }
    }
}
