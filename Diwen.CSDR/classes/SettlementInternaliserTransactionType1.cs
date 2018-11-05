namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserTransactionType1
    {
        public InternalisationData1 SctiesBuyOrSell { get; set; }

        public InternalisationData1 CollMgmtOpr { get; set; }

        public InternalisationData1 SctiesLndgOrBrrwg { get; set; }

        public InternalisationData1 RpAgrmt { get; set; }

        public InternalisationData1 OthrTxs { get; set; }
    }
}