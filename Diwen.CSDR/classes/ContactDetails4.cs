namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class ContactDetails4
    {
        public string Nm { get; set; }

        public string PhneNb { get; set; }

        public string EmailAdr { get; set; }

        public string Fctn { get; set; }
    }
}