using System.Reflection;
using Tms.Adapter;
using Tms.Adapter.Models;

namespace MsTest;

[TestClass]
public class MethodTests
{
    [TestMethod]
    public void AddLinks_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddLinks_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Assert.IsTrue(false);
    }

    [TestMethod]
    public void AddAttachments_Success()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        var basePath = AppContext.BaseDirectory;
        Adapter.AddAttachments(Path.Combine(basePath, "attachments/file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(basePath, "attachments/file03.txt"), 
            Path.Combine(basePath, "attachments/file04.txt")
        });

        Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddAttachments_Failed()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        var basePath = AppContext.BaseDirectory;
        Adapter.AddAttachments(Path.Combine(basePath, "attachments/file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(basePath, "attachments/file03.txt"), 
            Path.Combine(basePath, "attachments/file04.txt")
        });
        
        Assert.IsTrue(false);
    }

    [TestMethod]
    public void AddMessage_Success()
    {
        Adapter.AddMessage("Message");

        Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddMessage_Failed()
    {
        Adapter.AddMessage("Message");

        Assert.IsTrue(false);
    }

    [TestMethod]
    public void AddAllMethods_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Adapter.AddAttachments("Content", "file01.txt");
        var basePath = AppContext.BaseDirectory;
        Adapter.AddAttachments(Path.Combine(basePath, "attachments/file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(basePath, "attachments/file03.txt"), 
            Path.Combine(basePath, "attachments/file04.txt")
        });
        
        Adapter.AddMessage("Message");

        Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddAllMethods_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Adapter.AddAttachments("Content", "file01.txt");
        var basePath = AppContext.BaseDirectory;
        Adapter.AddAttachments(Path.Combine(basePath, "attachments/file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(basePath, "attachments/file03.txt"), 
            Path.Combine(basePath, "attachments/file04.txt")
        });
        
        Adapter.AddMessage("Message");

        Assert.IsTrue(false);
    }
}