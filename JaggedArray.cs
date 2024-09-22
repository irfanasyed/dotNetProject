int[][] weekSales = new int[4][];
Console.WriteLine(" the sales of every week");
weekSales[0] =new int[4] {450,500,1200,300};
weekSales[1] = new int[5] {560,4500,750,340,890};
weekSales[2] = new int[7] {300,150,250,400,670,500,1000};
weekSales[3] = new int[6] {680,900,470,300,800,150};
for (int i = 0; i < weekSales.Length; i++)
{
    Console.Write("WeekSales[{0}]\t",i+1+" ");
    
    for (int j = 0; j < weekSales[i].Length; j++)
    {
        
        
        Console.Write(weekSales[i][j]+" ");
        
    }
    Console.WriteLine();
    
}
Console.WriteLine("the total of each week");
int sum = 0;
int totalSum = 0;
int k = 0;
for ( k= 0; k < weekSales.Length; k++)
{
    for (int j = 0; j < weekSales[k].Length; j++)
    {
        sum +=weekSales[k][j];

    }
   
    Console.WriteLine("weekSales[{0}]: {1}", k + 1, sum);
    totalSum = totalSum + sum;


    sum = 0;

}
Console.WriteLine("The total sales"+totalSum);



