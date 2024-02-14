Task task = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(500);
        Console.WriteLine($"task {i}");
    }
});

task.Start();

for (int i = 0; i < 5; i++)
{
    Thread.Sleep(500);
    Console.WriteLine($"main {i}");
}
task.Wait();