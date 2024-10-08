using Tms.Adapter;
using Tms.Adapter.Models;
using Tms.Adapter.Attributes;
namespace MsTest.Tests;

[TestClass]
public class MethodTests
{
    
    private static readonly string AttachmentsPath = Path.Combine(AppContext.BaseDirectory, "Attachments");
    [Step]
    public void AssertSuccess() {
        Assert.IsTrue(true);
    }

    
    [Step]
    public void AssertFailure() {
        Assert.IsTrue(false);
    }



    [TestMethod]
    public void AddLinks_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        AssertSuccess();
    }

    [TestMethod]
    public void AddLinks_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        AssertFailure();
    }

    [TestMethod]
    public void AddAttachments_Success()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(Path.Combine(AttachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        AssertSuccess();
    }

    [TestMethod]
    public void AddAttachments_Failed()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(Path.Combine(AttachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        AssertFailure();
    }

    [TestMethod]
    public void AddMessage_Success()
    {
        Adapter.AddMessage("Message");

        AssertSuccess();
    }

    [TestMethod]
    public void AddMessage_Failed()
    {
        Adapter.AddMessage("Message");

        AssertFailure();
    }

    [TestMethod]
    public void AddAllMethods_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(Path.Combine(AttachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        Adapter.AddMessage("Message");

        AssertSuccess();
    }

    [TestMethod]
    public void AddAllMethods_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(AttachmentsPath, "file02.txt");
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        Adapter.AddMessage("Message");

        AssertFailure();
    }
}