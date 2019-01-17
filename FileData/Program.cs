using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string strResult = string.Empty;
            FileDetails fileDetails = new FileDetails();
            FileInfoDetails _fileInfoDetails = new FileInfoDetails(fileDetails);
            if (args != null && args.Length > 0)
            {
                strResult = _fileInfoDetails.GetFileDetailsUsingCommandLine(args);
            }
            else
            {
                _fileInfoDetails.GetFileDetailsUsingConsole();
            }
        }
    }
}
