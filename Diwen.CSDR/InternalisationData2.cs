namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class InternalisationData2
    {
        public InternalisationDataVolume1 Sttld { get; set; }

        public InternalisationDataVolume1 Faild { get; set; }

        public InternalisationDataVolume1 Ttl { get; set; }
    }
}