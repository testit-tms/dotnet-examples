using Tms.Adapter;
using Tms.Adapter.Models;

namespace NUnitTests.Tests;

public class MethodTests
{
    private static readonly string AttachmentsPath = Path.Combine(AppContext.BaseDirectory, "Attachments");

    [Test]
    public void AddLinks_Success()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Assert.That(true);
    }

    [Test]
    public void AddLinks_Failed()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example", "Example02", "Example02 description", LinkType.Repository);

        Assert.That(false);
    }

    [Test]
    public void AddAttachments_Success()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(Path.Combine(AttachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        Assert.That(true);
    }

    [Test]
    public void AddAttachments_Failed()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        Adapter.AddAttachments(Path.Combine(AttachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(AttachmentsPath, "file03.txt"),
            Path.Combine(AttachmentsPath, "file04.txt")
        });

        Assert.That(false);
    }

    [Test]
    public void AddMessage_Success()
    {
        Adapter.AddMessage("Message");

        Assert.That(true);
    }

    [Test]
    public void AddMessage_Failed()
    {
        Adapter.AddMessage("Message");

        Assert.That(false);
    }

    [Test]
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

        Assert.That(true);
    }

    [Test]
    public void AddAllMethods_Failed()
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

        Assert.That(false);
    }
}