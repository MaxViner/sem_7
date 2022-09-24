Console.WriteLine("колличество столбцов?");
int Wide =  int.Parse(Console.ReadLine());

Console.WriteLine("колличество строк?");
int Up =  int.Parse(Console.ReadLine());

int[,] FillArray(int Up,int Wide)
            {
            int[,] mas = new int[Up,Wide];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        mas[i,j]= new Random().Next(-100,100);
                    }
        
                }
            return mas;
            }
void PrintArray(int[,] mas)
            {

           // Console.WriteLine("случайным образом был сгенерирован следующий массив:");
            for (int i=0;i<mas.GetLength(0);i++) 
                {
                    int j = 0;
                    while ( j!=(mas.GetLength(1)-1)) 
                    {
                        if (mas[i,j]<0 && (mas[i,j])/10==0) Console.Write( mas[i,j]+"  , ");
                        else if (mas[i,j]/10==0) Console.Write(" "+ mas[i,j]+"  , ");
                        else if (mas[i,j]<0 ) Console.Write( mas[i,j]+" , ");
                        else Console.Write(" "+mas[i,j]+" , ");
                        j++;
                    }
                    Console.WriteLine(mas[i,j]);
                }
            Console.WriteLine();
            }

int[,] Mid_Aw_Row (int [,] mas)
{
    int Row_sum = 0;
    int[,]  Mid_awer = new int[Up,2];
            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        Row_sum=Row_sum+mas[i,j];
                    }
                    Mid_awer[i,1]=(Row_sum/Wide);
                    Mid_awer[i,0]=(i+1) ;
                }
    return Mid_awer;
}
try
{
    int [,] rezult = new int[Up,Wide];
    rezult = FillArray(Up,Wide);
    PrintArray(rezult);
    int [,] Mid_awer_rows = new int[Up,2];
    Mid_awer_rows = Mid_Aw_Row(rezult);
    Console.WriteLine("среднее арифметическое по строкам массива:");
    PrintArray(Mid_awer_rows);
}
catch
{
    Console.WriteLine("oh...somethin wrong");
}
