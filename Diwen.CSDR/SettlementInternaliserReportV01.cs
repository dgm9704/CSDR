namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserReportV01
    {
        public SettlementInternaliserReportHeader1 RptHdr { get; set; }

        public SettlementInternaliser1 SttlmIntlr { get; set; }

        [XmlElement("IssrCSD")]
        public IssuerCSDReport1[] IssrCSD { get; set; }

        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData { get; set; }
    }
}