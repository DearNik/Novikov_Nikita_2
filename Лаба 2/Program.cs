using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_2
{

    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string file;

                Console.WriteLine("Загрузка времени из файла или из устройства - f/d");
                string f = Console.ReadLine();
                if (f == "f")
                {
                    file = Convert.ToString(Deserialize());

                    bool timer = true;

                    while (timer == true)
                    {
                        try
                        {
                            Console.WriteLine(file);

                            int hc = 0;
                            int mc = 0;
                            int sc = 0;

                            Time Time1 = new Time(file);

                            Time1.TimeChoise(out hc, out mc, out sc);

                            if (mc < 10 && sc < 10) { Console.WriteLine($"{hc}:0{mc}:0{sc}"); }
                            else if (sc < 10) { Console.WriteLine($"{hc}:{mc}:0{sc}"); }
                            else if (mc < 10) { Console.WriteLine($"{hc}:0{mc}:{sc}"); }
                            else { Console.WriteLine($"{hc}:{mc}:{sc}"); }

                            Console.ReadKey();
                            Console.Clear();
                            timer = false;

                            Serialize($"{hc}:{mc}:{sc}");
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка ввода");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }


                }
                else if (f == "d")
                {
                    file = null;
                    bool timer = true;

                    while (timer == true)
                    {
                        try
                        {
                            DateTime time = DateTime.Now;

                            string format = "HH:mm:ss";



                            Console.WriteLine(time.ToString(format));

                            int hc = 0;
                            int mc = 0;
                            int sc = 0;

                            Time Time1 = new Time(file);

                            Time1.TimeChoise(out hc, out mc, out sc);

                            string resulttime
                                ;
                            if (mc < 10 && sc < 10)
                            {
                                resulttime = $"{hc}:0{mc}:0{sc}";
                                Console.WriteLine($"{hc}:0{mc}:0{sc}");
                            }
                            else if (sc < 10)
                            {
                                resulttime = $"{hc}:{mc}:0{sc}";
                                Console.WriteLine($"{hc}:{mc}:0{sc}");
                            }
                            else if (mc < 10)
                            {
                                resulttime = $"{hc}:0{mc}:{sc}";
                                Console.WriteLine($"{hc}:0{mc}:{sc}");
                            }
                            else
                            {
                                resulttime = $"{hc}:{mc}:{sc}";
                                Console.WriteLine($"{hc}:{mc}:{sc}");
                            }

                            Serialize(resulttime);
                            Console.ReadKey();
                            Console.Clear();
                            timer = false;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка ввода");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                static object Deserialize()
                {
                    var serializer = new JsonSerializer();

                    using (var sw = new StreamReader("D:\\Институт\\Прога\\Лаба 2\\time read.json"))
                    using (var reader = new JsonTextReader(sw))
                    {
                        return serializer.Deserialize(reader);
                    }
                }
                static void Serialize(object obj)
                {
                    using (StreamWriter file = File.CreateText("D:\\Институт\\Прога\\Лаба 2\\time wright.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, obj);
                    }
                }
            }
        }
    }
}
