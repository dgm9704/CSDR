namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserIdentification
    {
        [XmlElement("LEI")]
        public string LEI { get; set; }

        [XmlElement("RspnsblPrsn")]
        public ContactDetails ResponsiblePerson { get; set; }

        [XmlElement("Ctry")]
        public string Country { get; set; }

        [XmlElement("BrnchCtry")]
        public string BranchCountry { get; set; }
    }
}