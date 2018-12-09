namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class AggregationData
    {
        [XmlElement("Sttld")]
        public VolumeData Settled { get; set; }

        [XmlElement("Faild")]
        public VolumeData Failed { get; set; }

        [XmlElement("Ttl")]
        public VolumeData Total { get; set; }
    }
}