Console.WriteLine("колличество столбцов?");
int Wide =  int.Parse(Console.ReadLine());

Console.WriteLine("колличество строк?");
int Up =  int.Parse(Console.ReadLine());

Double[,] FillArray(int Up,int Wide)
            {
            Double[,] mas = new Double[Up,Wide];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        mas[i,j]= Math.Round((new Random().NextDouble())*(new Random().Next(-100,100)),4);
                    }
        
                }
            return mas;
            }
void PrintArray(Double[,] mas)
            {

            for (int i=0;i<Up;i++) 
                {
                    int j = 0;
                    while ( j!=(Wide-1)) 
                    {
                        if (mas[i,j]<0 || (mas[i,j])/10==0) Console.Write(" "+ mas[i,j]+" , ");
                         else if (mas[i,j] ==0) Console.Write("     ");
                        else if (mas[i,j]<0 && (mas[i,j])/10==0) Console.Write( mas[i,j]+" , ");
                        else Console.Write("  "+ mas[i,j]+" , ");
                        j++;
                    }
                    Console.WriteLine(mas[i,j]);
                }
            Console.WriteLine();
            }

Double [,] rezult = new Double[Up,Wide];
rezult = FillArray(Up,Wide);
PrintArray(rezult);

