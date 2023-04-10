using Tms.Adapter.Attributes;
using Tms.Adapter.Models;

namespace NUnitTests;

public class AttributesTests
{
    [Test]
    public void WithoutAttributes_Success()
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void WithoutAttributes_Failed()
    {
        Assert.IsTrue(false);
    }

    [ExternalId("ExternalIdAttribute_Success")]
    [Test]
    public void ExternalIdAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [ExternalId("ExternalIdAttribute_Failed")]
    [Test]
    public void ExternalIdAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [DisplayName("DisplayNameAttribute_Success DisplayName")]
    [Test]
    public void DisplayNameAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [DisplayName("DisplayNameAttribute_Failed DisplayName")]
    [Test]
    public void DisplayNameAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Title("TitleAttribute_Success Title")]
    [Test]
    public void TitleAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Title("TitleAttribute_Failed Title")]
    [Test]
    public void TitleAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Success")]
    [Test]
    public void DescriptionAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Failed")]
    [Test]
    public void DescriptionAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Labels("Label1", "Label2")]
    [Test]
    public void LablesAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Labels("Label1", "Label2")]
    [Test]
    public void LablesAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Links("htts://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("htts://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [Test]
    public void LinksAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Links("htts://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("htts://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [Test]
    public void LinksAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [WorkItemIds("123", "321")]
    [Test]
    public void WorkItemIdsAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [WorkItemIds("123", "321")]
    [Test]
    public void WorkItemIdsAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [ExternalId("WithAllAttributes_Success")]
    [DisplayName("WithAllAttributes_Success DisplayName")]
    [Title("WithAllAttributes_Success Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Success Description")]
    [Labels("Label1", "Label2")]
    [Links("htts://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("htts://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("123", "321")]
    [Test]
    public void WithAllAttributes_Success()
    {
        Assert.IsTrue(true);
    }

    [ExternalId("WithAllAttributes_Failed")]
    [DisplayName("WithAllAttributes_Failed DisplayName")]
    [Title("WithAllAttributes_Failed Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Failed Description")]
    [Labels("Label1", "Label2")]
    [Links("htts://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("htts://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("123", "321")]
    [Test]
    public void WithAllAttributes_Failed()
    {
        Assert.IsTrue(false);
    }

    [Parameterized]
    [TestCase(1, "string1")]
    [TestCase(2, "string2")]
    [TestCase(3, "string3")]
    [ExternalId("ParametrizedTest_Success_{number}_{str}")]
    [Title("ParametrizedTest_Success Title {number} {str}")]
    [DisplayName("ParametrizedTest_Success DisplayName {number} {str}")]
    [Test]
    public void ParametrizedTest_Success(int number, string str)
    {
        Assert.IsTrue(true);
    }

    [Parameterized]
    [TestCase(1, "string1")]
    [TestCase(2, "string2")]
    [TestCase(3, "string3")]
    [ExternalId("ParametrizedTest_Failed_{number}_{str}")]
    [Title("ParametrizedTest_Failed Title {number} {str}")]
    [DisplayName("ParametrizedTest_Failed DisplayName {number} {str}")]
    [Test]
    public void ParametrizedTest_Failed(int number, string str)
    {
        Assert.IsTrue(false);
    }
}