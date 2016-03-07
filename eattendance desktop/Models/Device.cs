using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eattendance_desktop
{
    class Device
    {
        private zkemkeeper.CZKEMClass axCZKEM;
        public zkemkeeper.CZKEMClass device
        {
            get { return axCZKEM; }
            set { axCZKEM = value; }
        }

        private bool bIsConnected;
        public bool isConnected
        {
            get { return bIsConnected; }
            set { bIsConnected = value; }
        }

        private int iDeviceNumber;
        public int deviceNumber
        {
            get { return iDeviceNumber; }
            set { iDeviceNumber = value; }
        }

        // Following fields are to be displayed in the MainWindow
        private string sName;
        public string name
        {
            get { return sName; }
            set { sName = value; }
        }
        
        private string sStatus;
        public string status
        {
            get { return sStatus; }
            set { sStatus = value; }
        }
        
        private string sIP;
        public string IP
        {
            get { return sIP; }
            set { sIP = value; }
        }
        
        private string sPort;
        public string port
        {
            get { return sPort; }
            set { sPort = value; }
        }
        
        private string sRemarks;
        public string remarks
        {
            get { return sRemarks; }
            set { sRemarks = value; }
        }

        #region constructors
        public Device(string name, string ip, string port, string remarks)
        {
            this.axCZKEM = new zkemkeeper.CZKEMClass();
            this.bIsConnected = false;
            this.iDeviceNumber = -1;
            this.sName = name;
            this.sStatus = "Offline";
            this.sIP = ip;
            this.sPort = port;
            this.sRemarks = remarks;
        }
        
        public Device(string name, int deviceNumber, string ip, string port, string remarks)
        {
            this.axCZKEM = new zkemkeeper.CZKEMClass();
            this.bIsConnected = false;
            this.iDeviceNumber = deviceNumber;
            this.sName = name;
            this.sStatus = "Offline";
            this.sIP = ip;
            this.sPort = port;
            this.sRemarks = remarks;
        }

        public Device(zkemkeeper.CZKEMClass device, bool isConnected, string name, int deviceNumber, string ip, string port, string remarks)
        {
            this.axCZKEM = device;
            this.bIsConnected = isConnected;
            this.iDeviceNumber = deviceNumber;
            this.sName = name;
            this.sStatus = isConnected?"Online":"Offline";
            this.sIP = ip;
            this.sPort = port;
            this.sRemarks = remarks;
        }
        #endregion

        public void setConnected(bool isConnected)
        {
            this.bIsConnected = isConnected;
            this.sStatus = isConnected ? "Online" : "Offline";
        }
    }
}
