namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class RateData
    {
        [XmlElement("VolPctg")]
        public decimal VolumePercentage { get; set; }

        [XmlElement("Val")]
        public decimal Value { get; set; }
    }
}