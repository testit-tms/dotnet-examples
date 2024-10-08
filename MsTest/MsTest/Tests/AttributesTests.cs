using Tms.Adapter.Attributes;
using Tms.Adapter.Models;

namespace MsTest.Tests;

[TestClass]
public class AttributesTests
{
    [Step]
    public void AssertSuccess() {
        Assert.IsTrue(true);
    }

    
    [Step]
    public void AssertFailure() {
        Assert.IsTrue(false);
    }


    [TestMethod]
    public void WithoutAttributes_Success()
    {
        AssertSuccess();
    }

    [TestMethod]
    public void WithoutAttributes_Failed()
    {
        AssertFailure();
    }

    [ExternalId("ExternalIdAttribute_Success")]
    [TestMethod]
    public void ExternalIdAttribute_Success()
    {
        AssertSuccess();
    }

    [ExternalId("ExternalIdAttribute_Failed")]
    [TestMethod]
    public void ExternalIdAttribute_Failed()
    {
        AssertFailure();
    }

    [DisplayName("DisplayNameAttribute_Success DisplayName")]
    [TestMethod]
    public void DisplayNameAttribute_Success()
    {
        AssertSuccess();
    }

    [DisplayName("DisplayNameAttribute_Failed DisplayName")]
    [TestMethod]
    public void DisplayNameAttribute_Failed()
    {
        AssertFailure();
    }

    [Title("TitleAttribute_Success Title")]
    [TestMethod]
    public void TitleAttribute_Success()
    {
        AssertSuccess();
    }

    [Title("TitleAttribute_Failed Title")]
    [TestMethod]
    public void TitleAttribute_Failed()
    {
        AssertFailure();
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Success")]
    [TestMethod]
    public void DescriptionAttribute_Success()
    {
        AssertSuccess();
    }

    [Tms.Adapter.Attributes.Description("DescriptionAttribute_Failed")]
    [TestMethod]
    public void DescriptionAttribute_Failed()
    {
        AssertFailure();
    }

    [Labels("Label1", "Label2")]
    [TestMethod]
    public void LabelsAttribute_Success()
    {
        AssertSuccess();
    }

    [Labels("Label1", "Label2")]
    [TestMethod]
    public void LabelsAttribute_Failed()
    {
        AssertFailure();
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [TestMethod]
    public void LinksAttribute_Success()
    {
        AssertSuccess();
    }

    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [TestMethod]
    public void LinksAttribute_Failed()
    {
        AssertFailure();
    }

    [WorkItemIds("24920", "24921")]
    [TestMethod]
    public void WorkItemIdsAttribute_Success()
    {
        AssertSuccess();
    }

    [WorkItemIds("123", "321")]
    [TestMethod]
    public void WorkItemIdsAttribute_Failed()
    {
        AssertFailure();
    }

    [ExternalId("WithAllAttributes_Success")]
    [DisplayName("WithAllAttributes_Success DisplayName")]
    [Title("WithAllAttributes_Success Title")]
    [Tms.Adapter.Attributes.Description("Тест кириллицы и юникода 😄")]
    [Labels("Label1", "Label2")]
    [Links("https://test01.example", LinkType.Issue, "Example01", "Example01 description")]
    [Links("https://test02.example", LinkType.Issue, "Example02", "Example02 description")]
    [WorkItemIds("24920", "24921")]
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
    [WorkItemIds("24920", "321")]
    [TestMethod]
    public void WithAllAttributes_Failed()
    {
        AssertFailure();
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
        AssertSuccess();
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
        AssertFailure();
    }
}