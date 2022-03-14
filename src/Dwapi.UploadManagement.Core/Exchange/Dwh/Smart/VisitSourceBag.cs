using Dwapi.ExtractsManagement.Core.Model.Destination.Dwh;
using Dwapi.UploadManagement.Core.Interfaces.Exchange.Ct;
using Dwapi.UploadManagement.Core.Model.Dwh;

namespace Dwapi.UploadManagement.Core.Exchange.Dwh.Smart
{
    public class VisitMessageSourceBag : MessageSourceBag<PatientVisitExtractView>
    {
        public override string EndPoint => "PatientVisits";
        public override string ExtractName => $"PatientVisitExtract";
    }
}
