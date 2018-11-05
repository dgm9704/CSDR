namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class IssuerCSDIdentification1
    {
        public string LEI { get; set; }

        public string FrstTwoCharsISIN { get; set; }

        public string Ctry { get; set; }
    }
}