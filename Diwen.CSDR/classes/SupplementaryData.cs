namespace Diwen.CSDR
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SupplementaryData
    {
        [XmlElement("PlcAndNm")]
        public string PlaceAndName { get; set; }

        [XmlElement("Envlp")]
        public XmlElement Envelope { get; set; }
    }
}