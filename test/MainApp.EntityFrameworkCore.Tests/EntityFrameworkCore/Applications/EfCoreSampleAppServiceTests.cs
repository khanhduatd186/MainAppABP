using MainApp.Samples;
using Xunit;

namespace MainApp.EntityFrameworkCore.Applications;

[Collection(MainAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MainAppEntityFrameworkCoreTestModule>
{

}
