Console.WriteLine("Enter number of students:");
int noOfStudent = Convert.ToInt32(Console.ReadLine());
string[,] student = new string[noOfStudent, 2];
int[,] mark = new int[noOfStudent, 6];
string[,] result = new string[noOfStudent, 1];
for (int i = 0; i < noOfStudent; i++)
{
    Console.WriteLine("Enter the details of students:");
    Console.WriteLine("Enter Student name: ");
    student[i, 0] = Console.ReadLine();
    Console.WriteLine("Enter the student ID:");
    student[i, 1] = Console.ReadLine();
    Console.WriteLine("Enter english mark:");
    mark[i, 0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter tamil mark:");
    mark[i, 1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter maths mark:");
    mark[i, 2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter science mark:");
    mark[i, 3] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter social mark:");
    mark[i, 4] = Convert.ToInt32(Console.ReadLine());
    mark[i, 5] = mark[i, 0] + mark[i, 1] + mark[i, 2] + mark[i, 3] + mark[i, 4];
    result[i, 0] = mark[i, 5] > 250 ? "Pass" : "Fail";
}

for (int i = 0; i < noOfStudent; i++)
{
    Console.WriteLine("Details of students: {0}", i + 1);
    Console.WriteLine("");
    Console.WriteLine($"Student name: {student[i, 0]}");
    Console.WriteLine($"Student ID: {student[i, 1]}");
    Console.WriteLine($"English mark: {mark[i, 0]}");
    Console.WriteLine($"Tamil mark: {mark[i, 1]}");
    Console.WriteLine($"Maths mark: {mark[i, 2]}");
    Console.WriteLine($"Science mark: {mark[i, 3]}");
    Console.WriteLine($"Social mark: {mark[i, 4]}");
    Console.WriteLine($"Total : {mark[i, 5]}");
    Console.WriteLine($"Result: {result[i, 0]}");


}