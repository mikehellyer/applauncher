using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using Keypad;
using TAFactory.IconPack;
using System.IO;


namespace AppLauncher
{
    public partial class frmMain : Form
    {

        List<LauncherMenuButton> buttons = new List<LauncherMenuButton>();
        string profilePath = System.Environment.GetEnvironmentVariable("USERPROFILE");
        string configFile;

        public frmMain()
        {
            InitializeComponent();
            //prevent maximizee 
            this.MaximizeBox = false;
            //get OS version 
            lblVersion.Text = getOSInfo();
            //create the location for the config file and then open it and read in data
            Directory.CreateDirectory(profilePath+@"\AppLauncher");
            configFile = profilePath + @"\Applauncher\buttons.xml";
            ReadInData();

        }


        void ReadInData()
        {
            
            addButtons();
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(configFile);
   
            }
            catch 
            {
                WriteBlankData();
                MessageBox.Show("New Data File Created");
      
            }

            XmlNodeList userNodes = xmlDoc.SelectNodes("//buttons/button");

            int buttonNo =0;
            
            foreach (XmlNode userNode in userNodes)
            {
                buttonNo += 1;
                
                if (userNode.InnerText == "button"+buttonNo) 
                { 
                    
                  
                    //buttons[buttonNo-1].SetButtonText(userNode.Attributes["text"].Value);
                    buttons[buttonNo-1].SetButtonDescription(userNode.Attributes["description"].Value);
                    buttons[buttonNo-1].SetButtonPath(userNode.Attributes["path"].Value);
                    //Icon openFolderIcon = IconHelper.ExtractIcon(@"%SystemRoot%\system32\shell32.dll", 4);
                    //get the icon and put it on a button
                    Icon buttonIcon = IconHelper.GetAssociatedLargeIcon(userNode.Attributes["path"].Value);
                    buttons[buttonNo - 1].SetButtonImage(buttonIcon.ToBitmap());

                }
            }
}

        void WriteOutData()
        {


            //addButtons();
            int buttonNo = 0;
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("buttons");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute textAttribute;
            XmlAttribute pathAttribute;
            XmlAttribute descriptionAttribute;


            for (int i=0; i < 24; i++)
            {
                //iterate over buttons and save their contents
                
                
                userNode = xmlDoc.CreateElement("button");
                textAttribute = xmlDoc.CreateAttribute("text");
                textAttribute.Value = buttons[i].GetButtonText();
                userNode.Attributes.Append(textAttribute);
                
                descriptionAttribute = xmlDoc.CreateAttribute("description");
                descriptionAttribute.Value = buttons[i].GetButtonDescription();
                userNode.Attributes.Append(descriptionAttribute);
                
                pathAttribute = xmlDoc.CreateAttribute("path");
                pathAttribute.Value = buttons[i].GetButtonPath();
                userNode.Attributes.Append(pathAttribute);
                
                buttonNo = i+1;
                userNode.InnerText = "button" + buttonNo.ToString();
                rootNode.AppendChild(userNode);    
            
            }
            string sStartupPath = Application.StartupPath;

            xmlDoc.Save(configFile);

        }


        void WriteBlankData()
        {


            //addButtons();
            int buttonNo = 0;
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("buttons");
            xmlDoc.AppendChild(rootNode);
            XmlNode userNode;
            XmlAttribute textAttribute;
            XmlAttribute pathAttribute;
            XmlAttribute descriptionAttribute;


            for (int i = 0; i < 24; i++)
            {
                //iterate over buttons and save there contents


                userNode = xmlDoc.CreateElement("button");
                textAttribute = xmlDoc.CreateAttribute("text");
                textAttribute.Value = "";
                userNode.Attributes.Append(textAttribute);

                descriptionAttribute = xmlDoc.CreateAttribute("description");
                descriptionAttribute.Value = "";
                userNode.Attributes.Append(descriptionAttribute);

                pathAttribute = xmlDoc.CreateAttribute("path");
                pathAttribute.Value = "";
                userNode.Attributes.Append(pathAttribute);

                buttonNo = i + 1;
                userNode.InnerText = "button" + buttonNo.ToString();
                rootNode.AppendChild(userNode);

            }

            xmlDoc.Save(configFile);

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFullDate.Text = DateTime.Now.ToString("dd MMM yyyy, H:mm:ss");
            

        }

        private void lblFullDate_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            quitApplication();
            
        }

        private void quitApplication()
        {
            WriteOutData();
            Application.Exit();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void addButtons()
        {
            //Add all the buttons to a list.
            buttons.Add(launcherMenuButton1);
            buttons.Add(launcherMenuButton2);
            buttons.Add(launcherMenuButton3);
            buttons.Add(launcherMenuButton4);
            buttons.Add(launcherMenuButton5);
            buttons.Add(launcherMenuButton6);
            buttons.Add(launcherMenuButton7);
            buttons.Add(launcherMenuButton8);
            buttons.Add(launcherMenuButton9);
            buttons.Add(launcherMenuButton10);
            buttons.Add(launcherMenuButton11);
            buttons.Add(launcherMenuButton12);
            buttons.Add(launcherMenuButton13);
            buttons.Add(launcherMenuButton14);
            buttons.Add(launcherMenuButton15);
            buttons.Add(launcherMenuButton16);
            buttons.Add(launcherMenuButton17);
            buttons.Add(launcherMenuButton18);
            buttons.Add(launcherMenuButton19);
            buttons.Add(launcherMenuButton20);
            buttons.Add(launcherMenuButton21);
            buttons.Add(launcherMenuButton22);
            buttons.Add(launcherMenuButton23);
            buttons.Add(launcherMenuButton24);
        
        }

        string getOSInfo()
        {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            //Variable to hold our return value
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                //This is a pre-NT version of Windows
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 6:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else
                            operatingSystem = "7";
                        break;
                    default:
                        break;
                }
            }
            //Make sure we actually got something in our OS check
            //We don't want to just return " Service Pack 2" or " 32-bit"
            //That information is useless without the OS version.
            if (operatingSystem != "")
            {
                //Got something.  Let's prepend "Windows" and get more info.
                operatingSystem = "Windows " + operatingSystem;
                //See if there's a service pack installed.
                if (os.ServicePack != "")
                {
                    //Append it to the OS name.  i.e. "Windows XP Service Pack 3"
                    operatingSystem += " " + os.ServicePack;
                }
                //Append the OS architecture.  i.e. "Windows XP Service Pack 3 32-bit"
                operatingSystem += " " + getOSArchitecture().ToString() + "-bit";
            }
            //Return the information we've gathered.
            return operatingSystem;
        }

        int getOSArchitecture()
        {
            string pa = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            return ((String.IsNullOrEmpty(pa) || String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? 32 : 64);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            quitApplication();
        }
        
    }
}
