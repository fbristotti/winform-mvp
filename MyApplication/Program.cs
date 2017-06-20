using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using winform_mvp;

namespace MyApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            XmlSerializer serializer = new XmlSerializer(typeof(MyTest));
            DataContractSerializer dcs = new DataContractSerializer(typeof(MyTest));

            var t = new MyTest
            {
                Financeiro = 1234M,
                Id = Guid.NewGuid().ToString(),
                //NameOld = "NameOldOld",
                Model = new MyModel
                {
                    CanRefresh = true
                }
            };

            StringBuilder s = new StringBuilder();
            using (StringWriter writer = new StringWriter(s))
            {
                serializer.Serialize(writer, t);
            }

            using (Stream stream = File.Open("data.xml", FileMode.Create))
            {
                dcs.WriteObject(stream, t);
            }

            using (Stream stream = File.Open("data.xml", FileMode.Open))
            {
                var obs = dcs.ReadObject(stream);
            }

            Presenters.Show<Main.Presenter>("asdf", 1234);

            Presenters.StartApplication<Main.Presenter>();
        }
    }

    [DataContract(Namespace = "Bristotti.Model")]
    public class MyTest : IExtensibleDataObject
    {
        private decimal _financeiro;
        
        [DataMember]
        public decimal Financeiro
        {
            get { return _financeiro; }
            set { _financeiro = value; }
        }

        [DataMember]
        public string Id { get; set; }

        //[DataMember]
        //public string NameOld { get; set; }

        [DataMember]
        public MyModel Model { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }

    [DataContract(Namespace = "Bristotti.Model")]
    public class MyModel : IExtensibleDataObject
    {
        [DataMember]
        public bool CanRefresh { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
