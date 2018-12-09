namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class TransactionType
    {
        [XmlElement("SctiesBuyOrSell")]
        public InternalisationData SecuritiesBuyOrSell { get; set; }

        [XmlElement("CollMgmtOpr")]
        public InternalisationData CollateralManagementOperation { get; set; }

        [XmlElement("SctiesLndgOrBrrwg")]
        public InternalisationData SecurititesLendingOrBorrowing { get; set; }

        [XmlElement("RpAgrmt")]
        public InternalisationData RepurchaseAgreement { get; set; }

        [XmlElement("OthrTxs")]
        public InternalisationData OtherTransactions { get; set; }
    }
}