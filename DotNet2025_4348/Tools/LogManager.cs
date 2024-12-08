using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static String path = "Log";

        public static String GetPathCurrentDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), $"{path}\\{DateTime.Now:yyyyMM}");
        }
        public static String GetPathCurrentFile()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), $"{path}\\{DateTime.Now:yyyyMM}\\log_{DateTime.Now:yyyyMMdd}.txt");
        }
        public static void WriteLog(string nameProj,string nameFunc,string text)
        {
            if (!Directory.Exists(GetPathCurrentDirectory()))
            {
                Directory.CreateDirectory(GetPathCurrentDirectory());
            }
            Console.WriteLine(GetPathCurrentFile());
            File.AppendAllText(GetPathCurrentFile(),$"{DateTime.Now}   {nameProj}.{nameFunc}:   {text}\n");
        }
        public static void CleanLog()
        {
            string[] directoris = Directory.GetDirectories(Path.Combine(Directory.GetCurrentDirectory(),$"{path}"));
            //קבלת הזמן הנוכחי בפורמט שנכתב לתיקיה והמרה לאינט
            int nowTime = Int32.Parse($"{DateTime.Now:yyyyMM}");
            foreach (string dir in directoris)
            {
                //חיתוך מחרוזת הניתוב לקבלת שם התיקיה והמרה לאינט
                int pastTime = Int32.Parse(dir.Substring(dir.Length - 6));
                //בדיקה האם עברו חודשיים
                if(nowTime - pastTime > 2)
                {
                    Directory.Delete(dir,true);
                }
            }
        }
    }
}
