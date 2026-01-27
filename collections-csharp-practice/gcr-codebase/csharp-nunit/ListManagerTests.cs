[TestFixture]
public class ListManagerTests
{
    private ListManager manager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void AddElement_Test()
    {
        manager.AddElement(list, 5);
        Assert.Contains(5, list);
    }

    [Test]
    public void RemoveElement_Test()
    {
        list.Add(10);
        manager.RemoveElement(list, 10);
        Assert.IsFalse(list.Contains(10));
    }

    [Test]
    public void GetSize_Test()
    {
        list.Add(1);
        list.Add(2);
        Assert.AreEqual(2, manager.GetSize(list));
    }
}
