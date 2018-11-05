namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class IssuerCSDReport1
    {
        public IssuerCSDIdentification1 Id { get; set; }

        public InternalisationData1 OvrllTtl { get; set; }

        public SettlementInternaliserFinancialInstrument1 FinInstrm { get; set; }

        public SettlementInternaliserTransactionType1 TxTp { get; set; }

        public SettlementInternaliserClientType1 ClntTp { get; set; }

        public InternalisationData1 TtlCshTrf { get; set; }
    }
}