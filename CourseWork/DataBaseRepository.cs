using System;
using System.Text;
using System.Text.Json;
using System.IO;
using System.ComponentModel;

namespace CourseWork
{
    public static class DataBaseRepository
    {
        private static string jsonString;
        //путь к файлу
        private static string path = @"database.json";
        //коллекция предприятий
        private static BindingList<Company> _data;

        /// <summary>
        /// Данный метод сохраняет данные в файл
        /// </summary>
        /// <param name="companies"></param>
        public static void Save(BindingList<Company> companies)
        {
            jsonString = JsonSerializer.Serialize(companies, typeof(BindingList<Company>), 
                new JsonSerializerOptions() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create
                (System.Text.Unicode.UnicodeRanges.All) });
            File.WriteAllText(path, jsonString, Encoding.UTF8);
        }
        /// <summary>
        /// Данный метод сохраняет данные в файл
        /// </summary>
        /// <param name="companies"></param>
        public static void Save(BindingList<Company> companies, string filePath)
        {
            jsonString = JsonSerializer.Serialize(companies, typeof(BindingList<Company>),
                new JsonSerializerOptions()
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create
                (System.Text.Unicode.UnicodeRanges.All)
                });
            File.WriteAllText(filePath, jsonString, Encoding.UTF8);
        }
        /// <summary>
        /// Данный метод считывает данные с файла
        /// </summary>
        /// <returns></returns>
        public static BindingList<Company> Get()
        {
            jsonString = File.ReadAllText(path);
            _data = JsonSerializer.Deserialize<BindingList<Company>>(jsonString);
            return _data;
        }

    }
}
