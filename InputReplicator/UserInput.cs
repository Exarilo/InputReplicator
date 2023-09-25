using System.Collections.Generic;
using System;
using System.Drawing;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace InputReplicator
{
    public enum MouseMessage
    {
        WH_MOUSE_LL = 0x000E,
        LeftButtonDown = 0x0201,
        LeftButtonUp = 0x0202,
        LeftDoubleClick = 0x0203,
        RightButtonDown = 0x0204,
        RightButtonUp = 0x0205,
        RightDoubleClick = 0x0206,
        MiddleButtonDown = 0x0207,
        MiddleButtonUp = 0x0208,
        MiddleDoubleClick = 0x0209,
        MouseWheel = 0x020A,
        XButtonDown = 0x020B,
        XButtonUp = 0x020C,
        MouseHWheel = 0x020E,
    }
    public class UserInput
    {
        public MouseMessage mouseMessage;
        public Point positionInScreen;
        public int msDelay;
        public UserInput(MouseMessage mouseMessage, Point positionInScreen, int msDelay = 0)
        {
            this.mouseMessage = mouseMessage;
            this.positionInScreen = positionInScreen;
            this.msDelay = msDelay;
        }

    }
    public class ObservableInput : List<UserInput>
    {
        private readonly string filePath = Path.Combine(Environment.CurrentDirectory, "configs.xml");
  
        private DateTime lastAdditionTime;

        public new void Add(UserInput item)
        {
            item.msDelay = this.Count == 0 ? 0 : (int)(DateTime.Now - lastAdditionTime).TotalMilliseconds;
            lastAdditionTime = DateTime.Now;
            base.Add(item);
        }
        public Dictionary<string, List<UserInput>> Load()
        {
            Dictionary<string, List<UserInput>> inputsForConfigs = new Dictionary<string, List<UserInput>>();

            if (File.Exists(filePath))
            {
                XDocument document = XDocument.Load(filePath);

                foreach (var configElement in document.Descendants("config"))
                {
                    string configName = configElement.Attribute("name")?.Value;
                    if (!string.IsNullOrEmpty(configName))
                    {
                        List<UserInput> inputsForConfig = new List<UserInput>();

                        foreach (var eventElement in configElement.Descendants("event"))
                        {
                            int code = Convert.ToInt32(eventElement.Attribute("code").Value.Substring(2), 16);
                            string name = eventElement.Attribute("name").Value;
                            int positionX = int.Parse(eventElement.Attribute("positionX").Value);
                            int positionY = int.Parse(eventElement.Attribute("positionY").Value);
                            int msDelay = int.Parse(eventElement.Attribute("msdelay").Value);

                            UserInput userInput = new UserInput((MouseMessage)code, new Point(positionX, positionY), msDelay);
                            inputsForConfig.Add(userInput);
                        }

                        inputsForConfigs[configName] = inputsForConfig;
                    }
                }
            }

            return inputsForConfigs;
        }

        public List<string> GetAllConfigNames()
        {
            if (File.Exists(filePath))
            {
                XDocument document = XDocument.Load(filePath);

                return document.Descendants("config")
                    .Select(configElement => configElement.Attribute("name")?.Value)
                    .Where(configName => !string.IsNullOrEmpty(configName))
                    .ToList();
            }

            return new List<string>();
        }

        public void Save(string confName)
        {
            XDocument document;

            if (File.Exists(filePath))
                document = XDocument.Load(filePath);
            else
                document = new XDocument(new XDeclaration("1.0", "utf-8", null), new XElement("configs"));

            XElement rootElement = document.Root; 

            XElement newConfig = ToXml(confName);
            rootElement.Add(newConfig);

            document.Save(filePath);
        }

        private XElement ToXml(string confName)
        {
            XElement configElement = new XElement("config", new XAttribute("name", confName));
            XElement eventsElement = new XElement("events");

            foreach (UserInput input in this)
            {
                XElement eventElement = new XElement("event",
                  new XAttribute("code", "0x" + ((int)input.mouseMessage).ToString("X4")),
                    new XAttribute("name", Enum.GetName(typeof(MouseMessage), input.mouseMessage)),
                    new XAttribute("positionX", input.positionInScreen.X),
                    new XAttribute("positionY", input.positionInScreen.Y),
                    new XAttribute("msdelay", input.msDelay));
                eventsElement.Add(eventElement);
            }
            configElement.Add(eventsElement);
            return configElement;
        }
    }
}
