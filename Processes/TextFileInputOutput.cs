using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace HowTo.Processes
{
    public static class TextFileInputOutput
    {
        private static List<Login> login;

        public static List<Login> GetData(string file)
        {
            login = new List<Login>();
            string line = string.Empty;

            try
            {
                using (FileStream zipToOpen = new FileStream(file, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        Console.WriteLine(file);
                        Console.WriteLine(file.Substring(file.LastIndexOf("\\") + 1));
                        string tmp = file.Substring(file.LastIndexOf("\\") + 1);
                        string txtFilename = tmp.Substring(0, tmp.IndexOf(".")) + ".txt";
                        Console.WriteLine(txtFilename);
                        ZipArchiveEntry readmeEntry = archive.GetEntry(txtFilename);

                        using (StreamReader rdr = new StreamReader(readmeEntry.Open()))
                        {
                            while ((line = rdr.ReadLine()) != null)
                            {
                                string[] arr = new string[3];
                                arr = line.Split(',');
                                Console.WriteLine(arr[0] + "," + arr[1] + "," + arr[2]);

                                //Add data to the Customers Model
                                login.Add(new Login()
                                {
                                    Website = arr[0],
                                    Username = arr[1],
                                    Password = arr[2]
                                }); ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return login;
        }

        public static bool ExportDataToTextFile(List<Login> data, string file)
        {
            try
            {
                using (FileStream zipToOpen = new FileStream(Keyp.Pathname, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry(Keyp.Filename);
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                        {
                            foreach (var d in data)
                            {
                                writer.WriteLine(d.SaveLogins());
                                Console.WriteLine(d.SaveLogins());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
