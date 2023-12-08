using Tms.Adapter.Attributes;
using Tms.Adapter.Models;

namespace MsTest;

[TestClass]
public class AttributesTests
{
    [TestMethod]
    public void WithoutAttributes_Success()
    {
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void WithoutAttributes_Failed()
    {
        Assert.IsTrue(false);
    }

    [ExternalId("ExternalIdAttribute_Success")]
    [TestMethod]
    public void ExternalIdAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [ExternalId("ExternalIdAttribute_Failed")]
    [TestMethod]
    public void ExternalIdAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [DisplayName("DisplayNameAttribute_Success DisplayName")]
    [TestMethod]
    public void DisplayNameAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [DisplayName("DisplayNameAttribute_Failed DisplayName")]
    [TestMethod]
    public void DisplayNameAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Title("TitleAttribute_Success Title")]
    [TestMethod]
    public void TitleAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Title("TitleAttribute_Failed Title")]
    [TestMethod]
    public void TitleAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Success")]
    [TestMethod]
    public void DescriptionAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Failed")]
    [TestMethod]
    public void DescriptionAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Labels("Label1", "Label2")]
    [TestMethod]
    public void LabelsAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Labels("Label1", "Label2")]
    [TestMethod]
    public void LabelsAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [TestMethod]
    public void LinksAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [TestMethod]
    public void LinksAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [WorkItemIds("123", "321")]
    [TestMethod]
    public void WorkItemIdsAttribute_Success()
    {
        Assert.IsTrue(true);
    }

    [WorkItemIds("123", "321")]
    [TestMethod]
    public void WorkItemIdsAttribute_Failed()
    {
        Assert.IsTrue(false);
    }

    [ExternalId("WithAllAttributes_Success")]
    [DisplayName("WithAllAttributes_Success DisplayName")]
    [Title("WithAllAttributes_Success Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Success Description")]
    [Labels("Label1", "Label2")]
    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("123", "321")]
    [TestMethod]
    public void WithAllAttributes_Success()
    {
        Assert.IsTrue(true);
    }
    
    [ExternalId("WithAllAttributes_Failed")]
    [DisplayName("WithAllAttributes_Failed DisplayName")]
    [Title("WithAllAttributes_Failed Title")]
    [Tms.Adapter.Attributes.Description("WithAllAttributes_Failed Description")]
    [Labels("Label1", "Label2")]
    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("123", "321")]
    [TestMethod]
    public void WithAllAttributes_Failed()
    {
        Assert.IsTrue(false);
    }

    [Parameterized]
    [DataRow(1, "string1")]
    [DataRow(2, "string2")]
    [DataRow(3, "string3")]
    [ExternalId("ParametrizedTest_Success_{number}_{str}")]
    [Title("ParametrizedTest_Success Title {number} {str}")]
    [DisplayName("ParametrizedTest_Success DisplayName {number} {str}")]
    [TestMethod]
    public void ParametrizedTest_Success(int number, string str)
    {
        Assert.IsTrue(true);
    }

    [Parameterized]
    [DataRow(1, "string1")]
    [DataRow(2, "string2")]
    [DataRow(3, "string3")]
    [ExternalId("ParametrizedTest_Failed_{number}_{str}")]
    [Title("ParametrizedTest_Failed Title {number} {str}")]
    [DisplayName("ParametrizedTest_Failed DisplayName {number} {str}")]
    [TestMethod]
    public void ParametrizedTest_Failed(int number, string str)
    {
        Assert.IsTrue(false);
    }
}