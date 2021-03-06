﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace Navicat_Keygen_Patch_By_DFoX
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FNavicat());
        }
        private const string BouncyCastleCryptoName = "BouncyCastle.Crypto";
        private const string NewtonsoftJsonName = "Newtonsoft.Json";
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith(BouncyCastleCryptoName, StringComparison.InvariantCultureIgnoreCase))
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Navicat_Keygen_Patch_By_DFoX.BouncyCastle.Crypto.dll"))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }
            else
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Navicat_Keygen_Patch_By_DFoX.Newtonsoft.Json.dll"))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }
        }
    }
}
