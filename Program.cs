using EnsoulSharp.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using xd.Irelia.Properties;

namespace LeviathanLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }
        private static void OnGameLoad()
        {
            LoadAssembly();
        }

        private static void LoadAssembly()
        {
            Assembly assembly = Assembly.Load(Resources.LeviathanAIO);
            if (assembly != null ) 
            {
                if (assembly.EntryPoint != null)
                {
                    assembly.EntryPoint.Invoke(null, new object[]
                    {
                        new string[1]
                    });
                }
            }
        }
    }
}
