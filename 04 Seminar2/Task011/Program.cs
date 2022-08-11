/*
11. Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
*/
int num = new Random().Next(100,1000);
Console.WriteLine(num);
/*int digit1 = num/100;
int digit2 = num % 10;
Console.WriteLine(" "+digit1.ToString()+digit2.ToString());
*/
string str_num = num.ToString();
char digit1 = str_num[0];
char digit3 = str_num[2];
string new_str_num = digit1.ToString() + digit3.ToString();
int new_num = Convert.ToInt32(new_str_num);
Console.WriteLine(new_num);
