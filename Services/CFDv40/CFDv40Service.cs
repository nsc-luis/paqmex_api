using System.Xml;
using System.Xml.Serialization;

namespace PAQMEX_API.Services.CFDv40
{
    public class CFDv40Service : ICFDv40Service
    {
        string pathXML = $"{Environment.CurrentDirectory}\\Temp\\CFDv40.xml";
        public void GeneraCFDv40()
        {
            //Llenamos la clase COMPROBANTE--------------------------------------------------------

            Comprobante oComprobante = new Comprobante();
            oComprobante.Version = "3.3";
            oComprobante.Serie = "H";
            oComprobante.Folio = "1";
            oComprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            //oComprobante.Sello = "faltante"; //sig video
            oComprobante.FormaPago = c_FormaPago.Item01;
            oComprobante.NoCertificado = "12312312313112121212"; //sig video
            //oComprobante.Certificado = ""; //sig video
            oComprobante.SubTotal = 10m;
            oComprobante.Descuento = 1;
            oComprobante.Moneda = c_Moneda.MXN;
            oComprobante.Total = 9;
            oComprobante.TipoDeComprobante = c_TipoDeComprobante.I;
            oComprobante.MetodoPago = c_MetodoPago.PUE;
            oComprobante.LugarExpedicion = "20131";

            ComprobanteEmisor oEmisor = new ComprobanteEmisor();

            oEmisor.Rfc = "POWE870601DM7";
            oEmisor.Nombre = "Una razón rh de cv";
            oEmisor.RegimenFiscal = c_RegimenFiscal.Item612;

            ComprobanteReceptor oReceptor = new ComprobanteReceptor();
            oReceptor.Nombre = "Pepe SA DE CV";
            oReceptor.Rfc = "PEPE080801JH1";
            oReceptor.UsoCFDI = c_UsoCFDI.I06;

            //asigno emisor y receptor
            oComprobante.Emisor = oEmisor;
            oComprobante.Receptor = oReceptor;

            List<ComprobanteConcepto> lstConceptos = new List<ComprobanteConcepto>();
            ComprobanteConcepto oConcepto = new ComprobanteConcepto();
            oConcepto.Importe = 10m;
            oConcepto.ClaveProdServ = "92111704";
            oConcepto.Cantidad = 1;
            oConcepto.ClaveUnidad = "C81";
            oConcepto.Descripcion = "Un misil para la guerra";
            oConcepto.ValorUnitario = 10m;
            oConcepto.Descuento = 1;

            lstConceptos.Add(oConcepto);

            oComprobante.Conceptos = lstConceptos.ToArray();

            //SERIALIZAMOS.-------------------------------------------------
            

            XmlSerializer oXmlSerializar = new XmlSerializer(typeof(Comprobante));

            string sXml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writter = XmlWriter.Create(sww))
                {

                    oXmlSerializar.Serialize(writter, oComprobante);
                    sXml = sww.ToString();
                }

            }

            //guardamos el string en un archivo
            System.IO.File.WriteAllText(pathXML, sXml);
        }
    }
}
