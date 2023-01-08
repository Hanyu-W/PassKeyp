using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
                //Check if the file exists
                if (File.Exists(file))
                {
                    //Create a Stream Reader
                    using (StreamReader rdr = new StreamReader(file))
                    {
                        //Read the data in the file
                        while ((line = rdr.ReadLine()) != null)
                        {
                            string[] arr = new string[3];
                            arr = line.Split(' ');

                            //Add data to the Customers Model
                            login.Add(new Login()
                            {
                                Website = arr[0],
                                Username = arr[1],
                                Password = arr[2]
                            });;
                        }
                    }
                }
                else
                {
                    throw new Exception("File Not Found!");
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
                //We want to 
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        writer.WriteLine(d.ToString());
                        Console.WriteLine(d.ToString());
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
