using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    public class LogAnalyzer
    {
        public LogAnalyzer(IFileExtensionManager fileManager)
        {
            var fileExtensionManager = fileManager;
        }

        public bool IsValidFileName(string fileName)
        {
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                return false;
            }
            return true;
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

    public interface IFileExtensionManager
    {
        bool ValidateFileExtensions();
    }

    public class FileExtensionManager : IFileExtensionManager
    {
        public bool ValidateFileExtensions()
        {
            return true;
        }
    }

    public class FakeFileExtensionManager : IFileExtensionManager
    {
        public bool ValidateFileExtensions()
        {
            return true;
        }
    }
}
