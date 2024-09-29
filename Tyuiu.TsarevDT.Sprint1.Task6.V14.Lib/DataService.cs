using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TsarevDT.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            return Regex.IsMatch(value, @"^[а-яё]+$");
        }
    }
}
