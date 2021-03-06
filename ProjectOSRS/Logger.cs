﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectOSRS
{
    static class Logger
    {
        private const string PREFIX = "ProjectOSRS";

        public static void Log(string txt)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Log.txt");
            File.AppendAllText(path, $"[{PREFIX}] {txt}\n");
        }

        public static void LogErr(string err)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Errlog.txt");
            File.AppendAllText(path, $"[{PREFIX}] {err}\n");
        }
    }
}
