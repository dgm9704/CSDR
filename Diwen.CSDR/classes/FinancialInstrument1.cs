namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class FinancialInstrument
    {
        [XmlElement("Eqty")]
        public InternalisationData Equity { get; set; }

        [XmlElement("SvrgnDebt")]
        public InternalisationData SovereignDebt { get; set; }

        [XmlElement("Bd")]
        public InternalisationData Bond { get; set; }

        [XmlElement("OthrTrfblScties")]
        public InternalisationData OtherTransferableSecurities { get; set; }

        [XmlElement("XchgTradgFnds")]
        public InternalisationData ExchangeTradingFunds { get; set; }

        [XmlElement("CllctvInvstmtUdrtkgs")]
        public InternalisationData CollectiveInvestmentUndertakings { get; set; }

        [XmlElement("MnyMktInstrm")]
        public InternalisationData MoneyMarketInstrument { get; set; }

        [XmlElement("EmssnAllwnc")]
        public InternalisationData EmissionAllowance { get; set; }

        [XmlElement("OthrFinInstrms")]
        public InternalisationData OtherFinancialInstruments { get; set; }
    }
}