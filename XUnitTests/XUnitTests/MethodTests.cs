using Tms.Adapter.Core.Models;
using Tms.Adapter.Core.Service;
using Tms.Adapter.XUnit.Attributes;

namespace XUnitTests;

public class MethodTests
{
    [TmsFact]
    public void AddLinks_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example");

        Assert.True(true);
    }

    [TmsFact]
    public void AddLinks_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example");

        Assert.True(false);
    }

    [TmsFact]
    public void AddAttachments_Success()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        var attachmentsPath = Path.Combine(AppContext.BaseDirectory, "attachments");
        Adapter.AddAttachments(Path.Combine(attachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(attachmentsPath, "file03.txt"), 
            Path.Combine(attachmentsPath, "file04.txt")
        });

        Assert.True(true);
    }

    [TmsFact]
    public void AddAttachments_Failed()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        var attachmentsPath = Path.Combine(AppContext.BaseDirectory, "attachments");
        Adapter.AddAttachments(Path.Combine(attachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(attachmentsPath, "file03.txt"),
            Path.Combine(attachmentsPath, "file04.txt")
        });

        Assert.True(false);
    }

    [TmsFact]
    public void AddMessage_Success()
    {
        Adapter.AddMessage("Message");

        Assert.True(true);
    }

    [TmsFact]
    public void AddMessage_Failed()
    {
        Adapter.AddMessage("Message");

        Assert.True(false);
    }

    [TmsFact]
    public void AddAllMethods_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example");

        Adapter.AddAttachments("Content", "file01.txt");
        var attachmentsPath = Path.Combine(AppContext.BaseDirectory, "attachments");
        Adapter.AddAttachments(Path.Combine(attachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(attachmentsPath, "file03.txt"),
            Path.Combine(attachmentsPath, "file04.txt")
        });

        Adapter.AddMessage("Message");

        Assert.True(true);
    }

    [TmsFact]
    public void AddAllMethods_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example");

        Adapter.AddAttachments("Content", "file01.txt");
        var attachmentsPath = Path.Combine(AppContext.BaseDirectory, "attachments");
        Adapter.AddAttachments(Path.Combine(attachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(attachmentsPath, "file03.txt"),
            Path.Combine(attachmentsPath, "file04.txt")
        });

        Adapter.AddMessage("Message");

        Assert.True(false);
    }
}