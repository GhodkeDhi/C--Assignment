

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var filterd = numbers.Where(i => i % 2 == 0);
//var filterd = numbers.Where(i => i % 2 == 0);

foreach (var number in filterd)
{
    Console.Write($"{number}\t");
}
Console.WriteLine();

//Create a Book class with properties such as Title, Author, ISBN, and Price. Write methods to display the book details and calculate the discount price.
//2. Implement a class hierarchy with a base class Vehicle and derived classes Car and Bike. Include polymorphic methods to display details and calculate fuel efficiency.
//3. Write a program that initializes an array of integers. Implement methods to calculate the sum, average, max, and min values. Convert this array to a List and add/remove elements.
//4. Create a dictionary to store student names and their grades. Implement functionality to lookup a student's grade, update a grade, and list all students and their grades.
//5. Create a custom exception InvalidOperation and use it in a program that attempts invalid operations (e.g., division by zero), catching and handling this exception gracefully.
//6. Given a list of employees, use LINQ to filter employees based on a salary threshold, project only employee names, and order them by name.
//7. Write a program to read a text file containing student names and scores, calculate the average score, and write the results to a new file with additional statistical information.
//8.Write a C# program that checks whether a given number is a prime number.