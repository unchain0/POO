// Specify the data source
IEnumerable<int> numbers = Array.Empty<int>();
for (int i = 0; i <= 10; i++)
{
    numbers = numbers.Append(i + 1);
}

// Define the query expression
IEnumerable<int>? result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10);

// Execute the query
foreach (int x in result)
{
    Console.WriteLine(x);
}