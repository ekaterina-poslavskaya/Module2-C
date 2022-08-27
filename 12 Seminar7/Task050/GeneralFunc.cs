//разные общие методы
namespace GeneralFunc
{
    public class clsGeneralFunc
    {
        //считывание данных из консоли
        public static int ReadIntData(string comm = "")
        {
            Console.Write(comm);
            return Convert.ToInt32(Console.ReadLine());
        }
        //считывание данных из консоли
        public static double ReadDoubleData(string comm = "")
        {
            Console.Write(comm);
            return Convert.ToDouble(Console.ReadLine());
        }        
    }
}