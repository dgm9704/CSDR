namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserReportV01
    {
        [XmlElement("RptHdr")]
        public ReportHeader ReportHeader { get; set; }

        [XmlElement("SttlmIntlr")]
        public SettlementInternaliser SettlementInternaliser { get; set; }

        [XmlElement("IssrCSD")]
        public IssuerCSDReport[] IssrCSD { get; set; }

        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }
    }
}