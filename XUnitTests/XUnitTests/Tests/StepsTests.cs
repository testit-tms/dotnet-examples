using Tms.Adapter.Core.Attributes;
using Tms.Adapter.XUnit.Attributes;

namespace XUnitTests.Tests;

public class StepsTests : IDisposable
{
    [Before]
    public StepsTests()
    {
    }

    [After]
    public void Dispose()
    {
    }

    [Step]
    private void Step01()
    {
    }

    [Step]
    private void Step02(int _)
    {
    }

    [TmsFact]
    public void StepsWithoutAttributes_Success()
    {
        Step01();
        Step02(2);

        Assert.True(true);
    }

    [TmsFact]
    public void StepsWithoutAttributes_Failed()
    {
        Step01();
        Step02(2);

        Assert.True(false);
    }

    [Step]
    [Title("Step03 Title")]
    private void Step03()
    {
    }

    [Step]
    [Title("Step04 {_} Title")]
    private void Step04(int _)
    {
    }

    [TmsFact]
    public void StepsWithTitleAttribute_Success()
    {
        Step03();
        Step04(3);

        Assert.True(true);
    }

    [TmsFact]
    public void StepsWithTitleAttribute_Failed()
    {
        Step03();
        Step04(3);

        Assert.True(false);
    }

    [Step]
    [Description("Step03 Description")]
    private void Step05()
    {
    }

    [Step]
    [Description("Step04 {_} Description")]
    private void Step06(int _)
    {
    }

    [TmsFact]
    public void StepsWithDescriptionAttribute_Success()
    {
        Step05();
        Step06(4);

        Assert.True(true);
    }

    [TmsFact]
    public void StepsWithDescriptionAttribute_Failed()
    {
        Step05();
        Step06(4);

        Assert.True(false);
    }

    [Step]
    [Title("Step07 Title")]
    [Description("Step03 Description")]
    private void Step07()
    {
    }

    [Step]
    [Title("Step08 {_} Title")]
    [Description("Step04 {_} Description")]
    private void Step08(int _)
    {
    }

    [TmsFact]
    public void StepsWithAllAttributes_Success()
    {
        Step07();
        Step08(5);

        Assert.True(true);
    }

    [TmsFact]
    public void StepsWithAllAttributes_Failed()
    {
        Step07();
        Step08(5);

        Assert.True(false);
    }
}