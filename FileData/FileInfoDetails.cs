using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;
using System.Configuration;

namespace FileData
{
    public class FileInfoDetails
    {
        private readonly FileDetails _fileDetails;
        public FileInfoDetails(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

        public string GetFileDetailsUsingCommandLine(string[] arguments)
        {
            string strVersionOrSize = string.Empty;
            try
            {
                if (arguments != null)
                {
                    string[] version = new string[] { "–v", "--v", "/v", "--version" };
                    string[] size = new string[] { "–s", "--s", "/s", "--size" };

                    if (version.Contains(arguments[0]))
                    {
                        Console.WriteLine("Version of the file is :" + _fileDetails.Version(arguments[1]));
                        strVersionOrSize = _fileDetails.Version(arguments[1]);
                    }
                    if (size.Contains(arguments[0]))
                    {
                        Console.WriteLine("Size of the file is: " + _fileDetails.Size(arguments[1]));
                        strVersionOrSize = _fileDetails.Size(arguments[1]).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return strVersionOrSize;
        }

        public void GetFileDetailsUsingConsole()
        {
            try
            {
                Console.Write("Enter input: ");
                string strUserInput = Console.ReadLine();
                Console.Write("Enter File path: ");
                string strfilePath = Console.ReadLine();

                string[] version = ConfigurationManager.AppSettings["Version"].Split(',');
                    string[] size = ConfigurationManager.AppSettings["Size"].Split(',');

                    if (version.Contains(strUserInput))
                        Console.WriteLine("Version of the file is :" + _fileDetails.Version(strfilePath));
                    if (size.Contains(strUserInput))
                        Console.WriteLine("Size of the file is: " + _fileDetails.Size(strfilePath));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
