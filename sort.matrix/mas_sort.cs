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

int[,] sort (int [,] mas)
{
    int bufer = 0;


        for(int k=0;k<mas.GetLength(0);k++)
        {
            for (int t=0;t<mas.GetLength(1);t++)
            {
                for (int i=0;i<mas.GetLength(0);i++) 
                {
                    for (int j=0;j<mas.GetLength(1);j++)
                    {
                        if (mas[k,t]<mas[i,j]) 
                        {
                            bufer = mas[k,t];
                            mas [k,t] = mas[i,j];
                            mas[i,j]= bufer;
                        }
                    }
                }
            }
        }



return mas;
}
try
{
    int [,] rezult = new int[Up,Wide];
    rezult = FillArray(Up,Wide);
    Console.WriteLine("случайно сгенерированный массив: ");
    PrintArray(rezult);
    Console.WriteLine("наводим небольшой порядочек.... готово!");
    rezult  = sort (rezult);
    PrintArray(rezult);
}
catch
{
    Console.WriteLine("oh...somethin wrong");
}
