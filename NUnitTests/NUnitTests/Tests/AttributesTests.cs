using Tms.Adapter.Attributes;
using Tms.Adapter.Models;

namespace NUnitTests.Tests;

public class AttributesTests
{
    [Test]
    public void WithoutAttributes_Success()
    {
        Assert.That(true);
    }

    [Test]
    public void WithoutAttributes_Failed()
    {
        Assert.That(false);
    }

    [ExternalId("ExternalIdAttribute_Success")]
    [Test]
    public void ExternalIdAttribute_Success()
    {
        Assert.That(true);
    }

    [ExternalId("ExternalIdAttribute_Failed")]
    [Test]
    public void ExternalIdAttribute_Failed()
    {
        Assert.That(false);
    }

    [DisplayName("DisplayNameAttribute_Success DisplayName")]
    [Test]
    public void DisplayNameAttribute_Success()
    {
        Assert.That(true);
    }

    [DisplayName("DisplayNameAttribute_Failed DisplayName")]
    [Test]
    public void DisplayNameAttribute_Failed()
    {
        Assert.That(false);
    }

    [Title("TitleAttribute_Success Title")]
    [Test]
    public void TitleAttribute_Success()
    {
        Assert.That(true);
    }

    [Title("TitleAttribute_Failed Title")]
    [Test]
    public void TitleAttribute_Failed()
    {
        Assert.That(false);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Success")]
    [Test]
    public void DescriptionAttribute_Success()
    {
        Assert.That(true);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Failed")]
    [Test]
    public void DescriptionAttribute_Failed()
    {
        Assert.That(false);
    }

    [Labels("Label1", "Label2")]
    [Test]
    public void LabelsAttribute_Success()
    {
        Assert.That(true);
    }

    [Labels("Label1", "Label2")]
    [Test]
    public void LabelsAttribute_Failed()
    {
        Assert.That(false);
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [Test]
    public void LinksAttribute_Success()
    {
        Assert.That(true);
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [Test]
    public void LinksAttribute_Failed()
    {
        Assert.That(false);
    }

    [WorkItemIds("24528", "24529")]
    [Test]
    public void WorkItemIdsAttribute_Success()
    {
        Assert.That(true);
    }

    [WorkItemIds("123", "321")]
    [Test]
    public void WorkItemIdsAttribute_Failed()
    {
        Assert.That(false);
    }

    [ExternalId("WithAllAttributes_Success")]
    [DisplayName("WithAllAttributes_Success DisplayName")]
    [Title("WithAllAttributes_Success Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Success Description")]
    [Labels("Label1", "Label2")]
    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("24528", "24529")]
    [Test]
    public void WithAllAttributes_Success()
    {
        Assert.That(true);
    }

    [ExternalId("WithAllAttributes_Failed")]
    [DisplayName("WithAllAttributes_Failed DisplayName")]
    [Title("WithAllAttributes_Failed Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Failed Description")]
    [Labels("Label1", "Label2")]
    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("24528", "321")]
    [Test]
    public void WithAllAttributes_Failed()
    {
        Assert.That(false);
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
        Assert.That(true);
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
        Assert.That(false);
    }
}