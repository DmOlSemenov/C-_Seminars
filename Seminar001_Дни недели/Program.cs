//Console.WriteLine("Введите число ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//if (number1 == 1)
//{
//    Console.WriteLine("Понедельник");
//}
//else
//{
//    if (number1 == 2) 
//    {
//        Console.WriteLine("вторник");
//    }
//    else
//    {
//        if (number1 == 3) 
//        {
//            Console.WriteLine("среда");
//        }
//        else
//        {
//            if (number1 == 4) 
//            {
//                Console.WriteLine("четверг");
//            }
//            else
//            {
//                if (number1 == 5) 
//                {
//                    Console.WriteLine("пятница");
//                }
//                else
//                {
//                    if (number1 == 6) 
//                    {
//                        Console.WriteLine("суббота");
//                    }
//                    else
//                    {
//                        if (number1 == 7) 
//                        {
//                            Console.WriteLine("воскресенье");
//                        }
//                        else
//                        {
//                            if (number1 > 7) 
//                            {
//                            Console.WriteLine("Не является днем недели");
//                            }        
//                        }          
//                    }         
//                }           
//            }               
//        }        
//    }
//}

//Console.WriteLine("Введите число № 1 ");
//if (int.TryParse(Console.ReadLine(), out int a));
//{
//    switch(a)
//    {
//        case 1:
//            Console.WriteLine("понедельник"); 
//            break; 
//        case 2:
//            Console.WriteLine("вторник"); 
//            break;
//        case 3:
//            Console.WriteLine("среда"); 
//            break; 
//        case 4:
//            Console.WriteLine("четверг"); 
//            break; 
//        case 5:
//            Console.WriteLine("пятница"); 
//            break;
//        case 6:
//            Console.WriteLine("субботаа"); 
//            break; 
//        case 7:
//            Console.WriteLine("воскресение"); 
//            break;   
//        default:
//            Console.WriteLine("Такого дня недели нет"); 
//            break;   
//    }
//}

string[] days = new String[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
Console.WriteLine("Номер дня недели ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine(days[day - 1]);
