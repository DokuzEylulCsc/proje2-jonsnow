using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Log
    {
        public void addLog(Exception e)
        {
            string stream_read = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "log.txt"); // mevcut logları okur
            stream_read += Environment.NewLine + e.GetType() + " " + e.StackTrace + Environment.NewLine + "Tarih: " + DateTime.Now; //logların üstüne yeni satıra geçerek
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "log.txt", stream_read);//tüm logları dosyaya yazar          //hatanın tipini, nerden kaynaklandığını yazar
        }                                                                                                                          //ve zamanını yazar.

    }
}
