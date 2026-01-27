[Test]
[Timeout(2000)]
public void LongRunningTask_ShouldTimeout()
{
    var runner = new TaskRunner();
    runner.LongRunningTask();
}
