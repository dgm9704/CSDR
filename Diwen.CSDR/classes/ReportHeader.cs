namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class ReportHeader
    {
        [XmlElement("CreDtTm")]
        public DateTime CreationDateTime { get; set; }

        [XmlElement("RptgDt", DataType = "date")]
        public System.DateTime ReportingDate { get; set; }

        [XmlElement("Ccy")]
        public string Currency { get; set; }

        [XmlElement("RptSts")]
        public OperationType ReportStatus { get; set; }
    }
}