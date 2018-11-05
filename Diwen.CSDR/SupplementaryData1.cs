namespace Diwen.CSDR
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SupplementaryData1
    {
        public string PlcAndNm { get; set; }

        public XmlElement Envlp { get; set; }
    }
}