using Tms.Adapter.Attributes;

namespace NUnitTests;

public class StepsTests
{
    [Step]
    private void Step01()
    {
    }

    [Step]
    private void Step02(int number)
    {
    }

    [Test]
    public void StepsWithoutAttributes_Success()
    {
        Step01();
        Step02(2);

        Assert.IsTrue(true);
    }

    [Test]
    public void StepsWithoutAttributes_Failed()
    {
        Step01();
        Step02(2);

        Assert.IsTrue(false);
    }

    [Step]
    [Title("Step03 Title")]
    private void Step03()
    {
    }

    [Step]
    [Title("Step04 {number} Title")]
    private void Step04(int number)
    {
    }

    [Test]
    public void StepsWithTitleAttribute_Success()
    {
        Step03();
        Step04(3);

        Assert.IsTrue(true);
    }

    [Test]
    public void StepsWithTitleAttribute_Failed()
    {
        Step03();
        Step04(3);

        Assert.IsTrue(false);
    }

    [Step]
    [Tms.Adapter.Attributes.Description("Step03 Description")]
    private void Step05()
    {
    }

    [Step]
    [Tms.Adapter.Attributes.Description("Step04 {number} Description")]
    private void Step06(int number)
    {
    }

    [Test]
    public void StepsWithDescriptionAttribute_Success()
    {
        Step05();
        Step06(4);

        Assert.IsTrue(true);
    }

    [Test]
    public void StepsWithDescriptionAttribute_Failed()
    {
        Step05();
        Step06(4);

        Assert.IsTrue(false);
    }

    [Step]
    [Title("Step07 Title")]
    [Tms.Adapter.Attributes.Description("Step03 Description")]
    private void Step07()
    {
    }

    [Step]
    [Title("Step08 {number} Title")]
    [Tms.Adapter.Attributes.Description("Step04 {number} Description")]
    private void Step08(int number)
    {
    }

    [Test]
    public void StepsWithAllAttributes_Success()
    {
        Step07();
        Step08(5);

        Assert.IsTrue(true);
    }

    [Test]
    public void StepsWithAllAttributes_Failed()
    {
        Step07();
        Step08(5);

        Assert.IsTrue(false);
    }
}