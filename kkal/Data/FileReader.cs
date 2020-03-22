using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace kkal
{
    //var currentConfig = ConfigurationManager.AppSettings.Get("DestFolder")
    class FileReader
    {
        static void Main(string[] args)
        {
            string text = "class info";
            byte[] output, input;
            using (FileStream fstream = new FileStream(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, FileMode.OpenOrCreate))
            {
                input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, input.Length);
                fstream.Seek(0, SeekOrigin.Begin);

                output = new byte[fstream.Length];
                fstream.Read(output, 0, output.Length);
                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("qwerty", textFromFile);
                Product product = new Product();
                string[] words = fstream.Split(new char[] { '$' });
                product.name = words[0];
                product.type = words[1];
                product.kkal = words[2];
                product.mass = words[3];
                product.protein = words[4];
                product.fat = words[5];
                product.carbohydrate = words[6];
                product.vitamin = words[7];
                product.mineral = words[8];
                Product.products.Add(product);


            }
            Console.Read();

        }
                
        
    }
        //class TxtSerializer //: ISerializer
        //{
           
            //private class FileExeption : Exception
            //{
                //public FileExeption(string message)
              //      : base(message) { }
            //}

            //private static List<string> strings = new List<string>();
           // const string path = @"C:\Users\Admin\source\repos\AppOOP\AppOOP\Meetings.txt";

          //  public static void ReadFile()
            //{
              //  try
                //{
                  //  using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                    //{
                      //  while (!sr.EndOfStream) strings.Add(sr.ReadLine());
                    //}
                //}
                //catch (Exception ex)
               // {
                 //   throw new FileExeption(ex.Message);
                //}
            //}

           // public object Deserialize(string path)
            //{
                //Company company = new Company();
                //List<Meeting> meetings = new List<Meeting>();
                //List<Worker> workersList = new List<Worker>();
              //  ReadFile();
                //string[] field = null;
                //foreach (string line in strings)
                //{
                  //  field = line.Split(new char[] { ' ' });
                    //DateTime start = Convert.ToDateTime(field[0] + ' ' + field[1]);
                    //DateTime end = Convert.ToDateTime(field[0] + ' ' + field[2]);
                    //string name = field[4];
                  //  Meeting newMeeting = new Meeting(start, end, name);

                    //string[] workers = field[3].Split(new char[] { ',' });
                   // foreach (string people in workers)
                    //{
                      //  string[] forEmail = people.Split(new char[] { '-' });

                       // if (!workersList.Exists(x => x.name == forEmail[0]))
                       // {
                         //   Worker worker = new Worker(forEmail[0]);

                            //worker.meetings.Add(newMeeting);
                            //worker.mail = forEmail[1];
                            //newMeeting.workers.Add(worker);
                            //workersList.Add(worker);
                      //  }
                        //else
                        //{
                         //   Worker worker = workersList.Find(x => x.name == forEmail[0]);
                            //worker.meetings.Add(newMeeting);
                          //  newMeeting.workers.Add(worker);
                        //}
                 //   }
                  //  meetings.Add(newMeeting);
             //   }
               // company.meetings = meetings;
               // company.workers = workersList;
               // return company;
           // }

           // public void Serialize(object obj, string path)
          //  {
             //   Company company = obj as Company;
            //    using (StreamWriter sr = new StreamWriter(path))
              //  {
                 //   foreach (Meeting meet in company.meetings)
                //    {
                  //      string line = "";

                      //  line += meet.startTime.Date + " " + meet.startTime.TimeOfDay + " " + meet.endTime.TimeOfDay + " ";
                      //  foreach (Worker worker in meet.workers)
                     //   {
                       //     line += worker.name + "-" + worker.mail + ",";
                       // }
                        //line = line.TrimEnd(',');
                        //sr.WriteLine(line);
             //       }
           //     }
           // }
        //}

   //}
}
