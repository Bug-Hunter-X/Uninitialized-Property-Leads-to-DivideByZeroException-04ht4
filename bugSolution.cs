public class ExampleClass
{
    public int MyProperty { get; set; } = 1; // Initialize the property with a default value

    public void MyMethod()
    {
        // Check if MyProperty is zero before performing division
        if (MyProperty != 0)
        {
            Console.WriteLine(1 / MyProperty);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}