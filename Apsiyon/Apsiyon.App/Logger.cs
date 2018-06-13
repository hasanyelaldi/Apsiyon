using System;
using System.IO;
using Apsiyon.App.Models;
using Newtonsoft.Json;

namespace Apsiyon.App
{
    public class Logger : ILogger
    {
        public void Add(string message, object obj)
        {
            try
            {
                var errorLog = new ErrorLog()
                {
                    Description = message,
                    ObjString = JsonConvert.SerializeObject(obj)
                };
                using(var context = new ApsiyonContext())
                {
                    context.Logs.Add(errorLog);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("/Output/log.txt", ex.Message);
            }
        }
    }
}
