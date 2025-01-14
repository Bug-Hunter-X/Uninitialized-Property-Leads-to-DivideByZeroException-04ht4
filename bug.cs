public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This will cause an exception if MyProperty is not initialized
        Console.WriteLine(1 / MyProperty);
    }
}