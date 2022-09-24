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
            Console.WriteLine("случайным образом был сгенерирован следующий массив:");
            for (int i=0;i<Up;i++) 
                {
                    int j = 0;
                    while ( j!=(Wide-1)) 
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

void Choice (int [,] array )
{
    Console.WriteLine("номер строки интересующего элемента?");
    int check_up =  int.Parse(Console.ReadLine()); 
    Console.WriteLine("номер столбца интересующего элемента?");
    int check_wide =  int.Parse(Console.ReadLine());
    bool maybe = false;

    for (int i=0;i<Up;i++) 
        {
            if (i == (check_up-1))
                {
                for (int j=0;j<Wide;j++)
                    {
                        if (j == (check_wide-1)) 
                        {
                        Console.WriteLine($"{check_wide}-й элемент {check_up}-й строки равен = {array[i,j]}");
                        maybe = true;
                        break;
                        }
                    
                    } 
                }
        }
    if (maybe == false) Console.WriteLine("нет элемента  с таким номером ");
}

int [,] rezult = new int[Up,Wide];
rezult = FillArray(Up,Wide);
PrintArray(rezult);
Choice(rezult);