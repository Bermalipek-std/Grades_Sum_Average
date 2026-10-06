Console.Write("Enter grade for exam 1: ");
double exam1= double.Parse(Console.ReadLine());
Console.Write("Enter grade for exam 2: ");
double exam2 = double.Parse(Console.ReadLine());
Console.Write("Enter grade for exam 3: ");
double exam3 = double.Parse(Console.ReadLine());

double sum = exam1 + exam2 + exam3;
double average = sum / 3;
bool passed = average >= 60;
Console.Write($"Sum: {sum}\tAverage: {average}\nTrue is passed False is not: {passed}\n");