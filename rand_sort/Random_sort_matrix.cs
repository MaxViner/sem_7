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


int[,] Rand_position (int [,] mas)
{
    int bufer = 0;
    bool checker = true;
    //создание масивов для хранеия рандомных индексов
    int[,] Rand_position_up = new int [Up,Wide];
    int[,] Rand_position_wide = new int [Up,Wide];
    //присвоение заведомо невозможных неповторяющихся значений
    // для дальнейших проверок
    for (int negative_up = 0;negative_up<Up;negative_up++)
      {
        for (int negative_wide = 0;negative_wide<Wide;negative_wide++)
            {
                Rand_position_up  [negative_up,negative_wide]=-1-negative_up-negative_wide;
                Rand_position_wide[negative_up,negative_wide]=-1-negative_up-negative_wide;
                
            }
      }


    for(int i=0; i<Up /2; i++)
        {
            for (int j=0; j<Wide; j++)
            {
                Rand_position_up  [i,j]  = new Random().Next(0,Up);
               // Console.Write(Rand_position_up[i,j]);

                 Rand_position_wide[i,j]  = new Random().Next(0,Wide);
                // Console.WriteLine(Rand_position_wide[i,j]);

                 Rand_position_up  [Up-i-1,Wide-1-j]  = new Random().Next(0,Up);
                //  Console.Write(Rand_position_up[Up-i-1,Wide-1-j]);
                  
                 Rand_position_wide[Up-i-1,Wide-1-j]  = new Random().Next(0,Wide);
                // Console.WriteLine(Rand_position_wide[Up-i-1,Wide-1-j]);

                 checker = true;
                // проверка на то, чтобы индексы не повторялись между собой
                // заполнение массивов случайными неповтрряющимися значениями
                for (int k=0; k<=i; k++)
                {
                    for(int t=0; t < j ;t++)
                    {
                        if 
                        (
                            (
                                    (Rand_position_up  [i,j] == Rand_position_up  [Up-i-1,Wide-1-j])
                              &&    (Rand_position_wide[i,j] == Rand_position_wide[Up-i-1,Wide-1-j]) 
                            )
                            ||
                            (   
                               Rand_position_up  [i,j] == Rand_position_up[k,t]
                            && Rand_position_wide[i,j] == Rand_position_wide[k,t]
                            )
                            ||
                            (
                                Rand_position_up[Up-i-1,Wide-1-j]   == Rand_position_up[Up-k-1,Wide-1-t]  
                             && Rand_position_wide[Up-i-1,Wide-1-j]   == Rand_position_wide[Up-k-1,Wide-1-t]  
                            )
                            ||
                            (
                                   Rand_position_up  [i,j]   == Rand_position_up[Up-k-1,Wide-1-t]
                                && Rand_position_wide[i,j]   == Rand_position_wide[Up-k-1,Wide-1-t]
                            )
                            ||
                            (
                                Rand_position_up  [Up-i-1,Wide-1-j]   == Rand_position_up  [k,t]
                             && Rand_position_wide[Up-i-1,Wide-1-j]   == Rand_position_wide[k,t]
                            )
                            ||
                            (
                                   Rand_position_up  [k,t] == Rand_position_up [Up-k-1,Wide-1-j]
                                && Rand_position_wide[k,t]== Rand_position_wide[Up-i-1,Wide-1-j] 
                            )
                        )
                        {
                        checker = false;
                        }
                    }
                }
                // если фолс- переприсвоить значения и проверить снова
                if (checker==false) 
                {
                  //  Console.WriteLine("false");
                    j = j - 1; 
                }
                // перемещение значений исодного массива по новым индексам
                else 
                {
                    Console.Write(mas[ Rand_position_up[i,j] ,
                    Rand_position_wide[i,j] ]+ " - ");  

                    Console.WriteLine( mas [ Rand_position_up  [Up-i-1,   Wide-j-1], 
                                           Rand_position_wide [Up-i-1, Wide-j-1] ] ); 
                    // Console.WriteLine();     
            
                    bufer =  mas [ Rand_position_up[Up-i-1,Wide-j-1], 
                                Rand_position_wide [Up-i-1,Wide-j-1] ]; 

                    mas [ Rand_position_up[Up-i-1,Wide-j-1],Rand_position_wide [Up-i-1,Wide-j-1] ] =
                                    mas[ Rand_position_up[i,j] ,Rand_position_wide[i,j]] ;  


                    mas[ Rand_position_up[i,j] ,Rand_position_wide[i,j] ]=   bufer;
                }

            }
        }

   

return mas;

}
try
{
 int [,] rezult = new int[Up,Wide];
    rezult = FillArray(Up,Wide);
    PrintArray(rezult);
    int [,] haos = new int[Up,Wide];
    haos = Rand_position(rezult);
    PrintArray(haos);
}
catch
{
    Console.WriteLine("sorry... yuo hawe a mistake");
}