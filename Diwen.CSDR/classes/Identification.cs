namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class Identification
    {
        [XmlElement("LEI")]
        public string LEI { get; set; }

        [XmlElement("FrstTwoCharsISIN")]
        public string FirstTwoCharactersISIN { get; set; }

        [XmlElement("Ctry")]
        public string Country { get; set; }
    }
}