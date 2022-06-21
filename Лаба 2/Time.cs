using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Лаба_2
{
    public class Time
    {
        string file;
        public int hc;
        public int mc;
        public int sc;
        public Time(string file)
        {
            this.file = file;
        }
        public void TimeChoise(out int hc, out int mc, out int sc)
        {
            if(file == null)
            {
                DateTime time = DateTime.Now;

                string format = "HH:mm:ss";

                string[] mystring = time.ToString(format).Split(':');

                var TimeList = new List<int>();

                for (int j = 0; j < mystring.Length; j++)
                {
                    TimeList.Add(Convert.ToInt32(mystring[j]));
                }

                Console.WriteLine("Изменить время - h/m/s");

                string pick = Console.ReadLine();

                int hc1 = 0;
                int mc1 = 0;
                int sc1 = 0;

                if (pick == "h")
                {
                    int h = Convert.ToInt32(Console.ReadLine());
                    if (h < 24)
                    {
                        hc1 = h - TimeList[0];
                    }
                    else
                    {
                        hc1 = (h % 24) - TimeList[0];
                    }
                }
                if (pick == "m")
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    if (m < 60)
                    {
                        mc1 = m - TimeList[1];
                    }
                    else
                    {
                        mc1 = (m % 60) - TimeList[1];
                        hc1 = m / 60;
                        if (hc1 + TimeList[0] > 24)
                        {
                            hc1 = hc1 % 24;
                        }
                        else
                        {

                        }
                    }
                }
                if (pick == "s")
                {
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s < 60)
                    {
                        sc1 = s - TimeList[2];

                    }
                    else
                    {
                        sc1 = (s % 60) - TimeList[2];
                        mc1 = s / 60;
                        if (mc1 + TimeList[0] > 60)
                        {
                            hc1 = mc1 / 60;
                            if (hc1 + TimeList[0] > 24)
                            {
                                hc1 = hc1 % 24;
                            }
                        }
                        else
                        {

                        }
                    }
                }


                hc = hc1 + TimeList[0];
                mc = mc1 + TimeList[1];
                sc = sc1 + TimeList[2];
            }
            else
            {
                string[] mystring = file.Split(':');

                var TimeList = new List<int>();

                for (int j = 0; j < mystring.Length; j++)
                {
                    TimeList.Add(Convert.ToInt32(mystring[j]));
                }

                Console.WriteLine("Изменить время - h/m/s");

                string pick = Console.ReadLine();

                int hc1 = 0;
                int mc1 = 0;
                int sc1 = 0;

                if (pick == "h")
                {
                    int h = Convert.ToInt32(Console.ReadLine());
                    if (h < 24)
                    {
                        hc1 = h - TimeList[0];
                    }
                    else
                    {
                        hc1 = (h % 24) - TimeList[0];
                    }
                }
                if (pick == "m")
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    if (m < 60)
                    {
                        mc1 = m - TimeList[1];
                    }
                    else
                    {
                        mc1 = (m % 60) - TimeList[1];
                        hc1 = m / 60;
                        if (hc1 + TimeList[0] > 24)
                        {
                            hc1 = hc1 % 24;
                        }
                        else
                        {

                        }
                    }
                }
                if (pick == "s")
                {
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s < 60)
                    {
                        sc1 = s - TimeList[2];

                    }
                    else
                    {
                        sc1 = (s % 60) - TimeList[2];
                        mc1 = s / 60;
                        if (mc1 + TimeList[0] > 60)
                        {
                            hc1 = mc1 / 60;
                            if (hc1 + TimeList[0] > 24)
                            {
                                hc1 = hc1 % 24;
                            }
                        }
                        else
                        {

                        }
                    }
                }


                hc = hc1 + TimeList[0];
                mc = mc1 + TimeList[1];
                sc = sc1 + TimeList[2];
            }

        }

    }
}
