using Dwapi.ExtractsManagement.Core.Model.Destination.Dwh;
using Dwapi.UploadManagement.Core.Interfaces.Exchange.Ct;
using Dwapi.UploadManagement.Core.Model.Dwh;

namespace Dwapi.UploadManagement.Core.Exchange.Dwh.Smart
{
    public class AllergiesChronicIllnessMessageSourceBag : MessageSourceBag<AllergiesChronicIllnessExtractView>
    {
        public override string EndPoint => "AllergiesChronicIllness";
        public override string ExtractName => $"AllergiesChronicIllnessExtract";
    }
}
