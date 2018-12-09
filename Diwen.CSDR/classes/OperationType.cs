namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public enum OperationType
    {
        [XmlEnum("NEWT")]
        NewTransaction,

        [XmlEnum("AMND")]
        Amendment,

        [XmlEnum("CANC")]
        CAncellation,
    }
}