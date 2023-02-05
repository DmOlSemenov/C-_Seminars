Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
{
    Console.WriteLine("Понедельник");
}
else
{
    if (number1 == 2) 
    {
        Console.WriteLine("вторник");
    }
    else
    {
        if (number1 == 3) 
        {
            Console.WriteLine("среда");
        }
        else
        {
            if (number1 == 4) 
            {
                Console.WriteLine("четверг");
            }
            else
            {
                if (number1 == 5) 
                {
                    Console.WriteLine("пятница");
                }
                else
                {
                    if (number1 == 6) 
                    {
                        Console.WriteLine("суббота");
                    }
                    else
                    {
                        if (number1 == 7) 
                        {
                            Console.WriteLine("воскресенье");
                        }
                        else
                        {
                            if (number1 > 7) 
                            {
                            Console.WriteLine("Не является днем недели");
                            }        
                        }          
                    }         
                }           
            }               
        }        
    }
}