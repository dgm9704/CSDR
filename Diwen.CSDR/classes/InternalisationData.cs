namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class InternalisationData
    {
        [XmlElement("Aggt")]
        public AggregationData Aggregate { get; set; }

        [XmlElement("FaildRate")]
        public RateData FailedRate { get; set; }
    }
}