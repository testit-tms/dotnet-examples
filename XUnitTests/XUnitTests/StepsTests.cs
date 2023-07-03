using Tms.Adapter.Core.Attributes;
using Tms.Adapter.XUnit.Attributes;

namespace XUnitTests;


public class StepsTests: IDisposable
{
    
    [Before]
    public StepsTests()
    {
    }
    
    [Tms.Adapter.XUnit.Attributes.Step]
    private void Step01()
    {
    }

    [Tms.Adapter.XUnit.Attributes.Step]
    private void Step02(int number)
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

    [Tms.Adapter.XUnit.Attributes.Step]
    [Title("Step03 Title")]
    private void Step03()
    {
    }

    [Tms.Adapter.XUnit.Attributes.Step]
    [Title("Step04 {number} Title")]
    private void Step04(int number)
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

    [Tms.Adapter.XUnit.Attributes.Step]
    [Description("Step03 Description")]
    private void Step05()
    {
    }

    [Tms.Adapter.XUnit.Attributes.Step]
    [Description("Step04 {number} Description")]
    private void Step06(int number)
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

    [Tms.Adapter.XUnit.Attributes.Step]
    [Title("Step07 Title")]
    [Tms.Adapter.Core.Attributes.Description("Step03 Description")]
    private void Step07()
    {
    }

    [Tms.Adapter.XUnit.Attributes.Step]
    [Title("Step08 {number} Title")]
    [Description("Step04 {number} Description")]
    private void Step08(int number)
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
    
    [After]
    public void Dispose()
    {
    }
}