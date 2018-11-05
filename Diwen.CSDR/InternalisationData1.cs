namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class InternalisationData1
    {
        public InternalisationData2 Aggt { get; set; }

        public InternalisationDataRate1 FaildRate { get; set; }
    }
}