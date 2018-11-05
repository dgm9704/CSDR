namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserReportHeader1
    {
        public DateTime CreDtTm { get; set; }

        [XmlElement(DataType = "date")]
        public System.DateTime RptgDt { get; set; }

        public string Ccy { get; set; }

        public TransactionOperationType4Code RptSts { get; set; }
    }
}