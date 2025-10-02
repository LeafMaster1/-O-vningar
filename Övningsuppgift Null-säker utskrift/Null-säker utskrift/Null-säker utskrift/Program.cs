
void PrintSomething(string? value)
{
    string input = value ?? "Det fanns inget värde att skriva ut";
    Console.WriteLine(input);

}

PrintSomething(null);
PrintSomething("");
PrintSomething("   ");
PrintSomething("Hello World");
PrintSomething(null);
PrintSomething("Test test 123");
