namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class ClientType
    {
        [XmlElement("Prfssnl")]
        public InternalisationData Professional { get; set; }

        [XmlElement("Rtl")]
        public InternalisationData Retail { get; set; }
    }
}