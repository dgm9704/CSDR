namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class IssuerCSDReport
    {
        [XmlElement("Id")]
        public Identification Identification { get; set; }

        [XmlElement("OvrllTtl")]
        public InternalisationData OverallTotal { get; set; }

        [XmlElement("FinInstrm")]
        public FinancialInstrument FinancialInstrument { get; set; }

        [XmlElement("TxTp")]
        public TransactionType TransactionType { get; set; }

        [XmlElement("ClntTp")]
        public ClientType ClientType { get; set; }

        [XmlElement("TtlCshTrf")]
        public InternalisationData TotalCashTransfer { get; set; }
    }
}