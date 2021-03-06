namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01", IsNullable = false)]
    public partial class Document
    {
        [XmlElement("SttlmIntlrRpt")]
        public SettlementInternaliserReportV01 SettlementInternaliserReport { get; set; }
    }
}