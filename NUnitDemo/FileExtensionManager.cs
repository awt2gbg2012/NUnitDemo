using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    public interface IFileExtensionManager
    {
        bool ValidateFileExtensions(string fileName);
    }

    public class FileExtensionManager : IFileExtensionManager
    {
        public bool ValidateFileExtensions(string fileName)
        {
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                return false;
            }
            return true;
        }
    }
}
