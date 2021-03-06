﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    public class LogAnalyzer
    {
        IFileExtensionManager fileExtensionManager;
        public LogAnalyzer(IFileExtensionManager fileManager)
        {
            fileExtensionManager = fileManager;
        }

        public bool IsValidFileName(string fileName)
        {
            return fileExtensionManager.ValidateFileExtensions(fileName);          
        }

        public string CurrentVersion { get { return "v1.0"; } }

        public void CheckConfigFile()
        {
            if (!ConfigFileExists)
            {
                throw new ArgumentException();
            }
        }

        public void CheckConfigFile(string configFile, string version = "v1.0")
        {
            if (string.IsNullOrEmpty(configFile))
            {
                throw new ArgumentException();
            }
        }

        public DemoLogObject GenerateLogObject() 
        { 
            return new DemoLogObject(); 
        }

        private bool ConfigFileExists { get { return false; } }
    }

    public class DemoLogObject { }
}
