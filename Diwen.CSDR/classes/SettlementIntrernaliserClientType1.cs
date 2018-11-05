namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserClientType1
    {
        public InternalisationData1 Prfssnl { get; set; }
    
        public InternalisationData1 Rtl { get; set; }
    }
}