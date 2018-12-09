namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class ContactDetails
    {
        [XmlElement("Nm")]
        public string Name { get; set; }

        [XmlElement("PhneNb")]
        public string PhoneNumber { get; set; }

        [XmlElement("EmailAdr")]
        public string EmailAddress { get; set; }

        [XmlElement("Fctn")]
        public string Function { get; set; }
    }
}