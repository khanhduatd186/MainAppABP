using MainApp.Samples;
using Xunit;

namespace MainApp.EntityFrameworkCore.Domains;

[Collection(MainAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MainAppEntityFrameworkCoreTestModule>
{

}
