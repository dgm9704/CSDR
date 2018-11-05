namespace Diwen.CSDR
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:auth.072.001.01")]
    public partial class SettlementInternaliserFinancialInstrument1
    {
        public InternalisationData1 Eqty { get; set; }

        public InternalisationData1 SvrgnDebt { get; set; }

        public InternalisationData1 Bd { get; set; }

        public InternalisationData1 OthrTrfblScties { get; set; }

        public InternalisationData1 XchgTradgFnds { get; set; }

        public InternalisationData1 CllctvInvstmtUdrtkgs { get; set; }

        public InternalisationData1 MnyMktInstrm { get; set; }

        public InternalisationData1 EmssnAllwnc { get; set; }

        public InternalisationData1 OthrFinInstrms { get; set; }
    }
}