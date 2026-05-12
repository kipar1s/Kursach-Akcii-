using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

//Задайте здесь имя вашего проекта
namespace WindowsFormsApp1
{
    public class MyUtilities
    {
        //Создание копии объекта
        public static T Clone<T>(T source)
        {
            var json = JsonSerializer.Serialize(source);
            return JsonSerializer.Deserialize<T>(json);
        }

    }
}
