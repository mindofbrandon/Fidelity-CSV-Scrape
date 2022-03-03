using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium; // Framework to parse data online
using OpenQA.Selenium.Chrome; // parse data using chromium browser
using Microsoft.VisualBasic.FileIO; // for csv
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TestingCode
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver("/Webdriver/bin");

            // go to login page
            driver.Navigate().GoToUrl(@"https://fidelity.com/yourprofile");
            driver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie("key", "value"));
            var cookie = driver.Manage().Cookies.GetCookieNamed("key");
            //Console.WriteLine(cookie);
            StonkData data;
            try
            {
                IWebElement element;
                //Console.WriteLine(element);
                
                driver.FindElement(By.Id("userId-input")).SendKeys("username"); // scrapes site for username and input
                driver.FindElement(By.Name("PIN")).SendKeys("password"); // password
                driver.FindElement(By.Id("fs-login-button")).Click(); // clicks to login
                
                // go to portfolio
                driver.Navigate().GoToUrl(@"https://oltx.fidelity.com/ftgw/fbc/oftop/portfolio#positions");
                driver.FindElement(By.Id("posweb-grid_top-share-button")).Click(); // clicks to get download open
                driver.FindElement(By.ClassName("posweb-grid_top-share-download-button")).Click(); // clicks to download csv
                
                
                // TODO: search through downloads folder and have code auto update string to be correct data
                // determine date/time to auto download stock movement every friday EOD


                
                StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\zunig\Downloads\Portfolio_Positions_Jun-27-2021.csv"));

                //Dictionary<string, Array> stonkInfo = new Dictionary<string, Array>(); // declare dictionary of types string

                List<StonkData> listA = new List<StonkData>();
                int j = 0;
                while (!reader.EndOfStream)
                {
                    
                    if (j == 0)
                    {
                        string line = reader.ReadLine();
                        j++;
                    }
                    else
                    {
                        string line = reader.ReadLine();
                        // split the labels separately from the data
                        //stonkInfo.Add(reader);
                        char[] delimiterChars = { ',', '\"' };

                        for (int i = 0; i < line.Length; i++)
                        {
                            //if (line[i])

                        }

                        int found = 0;
                        string[] names = line.Split(delimiterChars, 1);

                        string pattern = ",(?=(?:[^']*[\"]*'[^']*')*[\"]*[^']*$)";

                        foreach (string name in names)
                        {
                            Console.WriteLine(Regex.Replace(name, pattern, "_"));
                        }

                        // will probably have to implement regex
                        



                        //values[3].Split(delimiterChars, 3);

                        //for (int i = 0; i < values.Length; i++)
                        //{
                            //listA.Add(data);
                        //}
                        
                    }


                    
                    



                }

                    

                /*
                List<string> listA = new List<String>();
                List<string> listB = new List<String>();
                List<string> listC = new List<String>();
                List<string> listD = new List<String>();
                List<string> listE = new List<String>();
                List<string> listF = new List<String>();
                List<string> listG = new List<String>();
                List<string> listH = new List<String>();
                List<string> listI = new List<String>();
                List<string> listJ = new List<String>();
                List<string> listK = new List<String>();
                List<string> listL = new List<String>();
                List<string> listM = new List<String>();
                List<string> listN = new List<String>();
                List<string> listO = new List<String>();

                //string vara1, vara2, vara3, vara4;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        if (values.Length >= 4)
                        {
                            listA.Add(values[0]);
                            listB.Add(values[1]);
                            listC.Add(values[2]);
                            listD.Add(values[3]);
                            listE.Add(values[4]);
                            listF.Add(values[5]);
                            listG.Add(values[6]);
                            listH.Add(values[7]);
                            listI.Add(values[8]);
                            listJ.Add(values[9]);
                            listK.Add(values[10]);
                            listL.Add(values[11]);
                            listM.Add(values[12]);
                            listN.Add(values[13]);
                            listO.Add(values[14]);
                        }
                    }
                }
                string[] firstlistA = listA.ToArray();
                string[] firstlistB = listB.ToArray();
                string[] firstlistC = listC.ToArray();
                string[] firstlistD = listD.ToArray();
                string[] firstlistE = listD.ToArray();
                string[] firstlistF = listD.ToArray();
                string[] firstlistG = listD.ToArray();
                string[] firstlistH = listD.ToArray();
                string[] firstlistI = listD.ToArray();
                string[] firstlistJ = listD.ToArray();
                string[] firstlistK = listD.ToArray();
                string[] firstlistL = listD.ToArray();
                string[] firstlistM = listD.ToArray();
                string[] firstlistN = listD.ToArray();
                string[] firstlistO = listD.ToArray();

                */
            }
            catch
            {
                //driver.Quit();
            }
            //driver.Quit();
        }
    }
}
