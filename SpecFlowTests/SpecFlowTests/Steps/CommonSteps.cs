using NUnit.Framework;
using TechTalk.SpecFlow;
using Tms.Adapter.Core.Attributes;
using Tms.Adapter.Core.Models;
using Tms.Adapter.Core.Service;

namespace SpecFlowTests.Steps;

[Binding]
public class CommonSteps
{
    [Then(@"return true")]
    public void ThenReturnTrue()
    {
        Assert.That(true);
    }

    [Then(@"return false")]
    public void ThenReturnFalse()
    {
        Assert.That(false);
    }

    [When(@"get parameters (.*) string(.*)")]
    public void WhenGetParametersString(int p0, int p1)
    {
    }

    [When(@"step(.*)")]
    [Title("step title")]
    public void WhenStep(int p0)
    {
    }

    [When(@"add links")]
    public void WhenAddLinks()
    {
        Adapter.AddLinks("https://test01.example", "Example01", "Example01 description", LinkType.Issue);
        Adapter.AddLinks("https://test02.example");
    }

    [When(@"add attachments")]
    public void WhenAddAttachments()
    {
        Adapter.AddAttachments("Content", "file01.txt");
        var attachmentsPath = Path.Combine(AppContext.BaseDirectory, "Attachments");
        Adapter.AddAttachments(Path.Combine(attachmentsPath, "file02.txt"));
        Adapter.AddAttachments(new List<string>
        {
            Path.Combine(attachmentsPath, "file03.txt"),
            Path.Combine(attachmentsPath, "file04.txt")
        });
    }

    [When(@"add message")]
    public void WhenAddMessage()
    {
        Adapter.AddMessage("Test Message");
    }

    [When(@"add all methods")]
    public void WhenAddAllMethods()
    {
        WhenAddMessage();
        WhenAddLinks();
        WhenAddAttachments();
    }
}