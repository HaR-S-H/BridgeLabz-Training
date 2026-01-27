[TestFixture]
public class DatabaseTests
{
    private DatabaseConnection db;

    [SetUp]
    public void Init()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void Cleanup() => db.Disconnect();

    [Test]
    public void Connection_ShouldBeOpen()
    {
        Assert.IsTrue(db.IsConnected);
    }
}
