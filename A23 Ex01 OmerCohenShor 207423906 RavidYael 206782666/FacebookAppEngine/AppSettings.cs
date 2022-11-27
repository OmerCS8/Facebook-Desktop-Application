using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacebookAppEngine
{
    public class AppSettings
    {
        public bool DoesUserWantToRememberHim { set; get; }
        public string UserAccessToken{ set; get; }

        private AppSettings()
        {
            DoesUserWantToRememberHim = false;
            UserAccessToken = null;
        }

        public void SaveAppSettingsToFile()
        {
            using(Stream stream = new FileStream("appSetting.xml",FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadAppSettingsFromFileOrCreateIfDoesNotExist()
        {
            AppSettings appSettings;

            if(File.Exists("appSetting.xml"))
            {
                using(Stream stream = new FileStream("appSetting.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }
    }
}
