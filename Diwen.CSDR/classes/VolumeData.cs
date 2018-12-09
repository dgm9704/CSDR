namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class VolumeData
    {
        [XmlElement("Vol")]
        public decimal Volume { get; set; }

        [XmlElement("Val")]
        public decimal Value { get; set; }
    }
}