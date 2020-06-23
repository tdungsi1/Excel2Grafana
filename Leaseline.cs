using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Leaseline
    {
        #region Attributes
        private string m_LeasedLine="";
        private string m_DeviceLayer2 = "";
        private string m_InterfaceLayer2 = "";
        private string m_DeviceLayer3 = "";
        private string m_InterfaceLayer3 = "";
        private string m_Ipaddress = "";
        private string m_Provider = "";
        private string m_Bandwidth = "";
        private string m_Location = "";
        private string m_Cost = "";
        private string m_CircuitID = "";
        private string m_ContractDueDate = "";
        private string m_PaidBy = "";
        private string m_Tag = "";


        #endregion

        #region Properties
        [DisplayNameAttribute("LeasedLine DeviceLayer2 InterfaceLayer2 DeviceLayer3 InterfaceLayer3 Ipaddress Provider Bandwidth Location Cost CircuitID ContractDueDate PaidBy Tag")]
        public string LeasedLine
        {
            get { return m_LeasedLine; }
            set { m_LeasedLine = value; }
        }
        public string DeviceLayer2
        {
            get { return m_DeviceLayer2; }
            set { m_DeviceLayer2 = value; }
        }
        public string InterfaceLayer2
        {
            get { return m_InterfaceLayer2; }
            set { m_InterfaceLayer2 = value; }
        }
        public string DeviceLayer3
        {
            get { return m_InterfaceLayer2; }
            set { m_DeviceLayer3 = value; }
        }
        public string InterfaceLayer3
        {
            get { return m_InterfaceLayer3; }
            set { m_InterfaceLayer3 = value; }
        }
        public string Ipaddress
        {
            get { return m_Ipaddress; }
            set { m_Ipaddress = value; }
        }
        public string Provider
        {
            get { return m_Provider; }
            set { m_Provider = value; }
        }
        public string Bandwidth
        {
            get { return m_Bandwidth; }
            set { m_Bandwidth = value; }
        }
        public string Location
        {
            get { return m_Location; }
            set { m_Location = value; }
        }
        public string Cost
        {
            get { return m_Cost; }
            set { m_Cost = value; }
        }
        public string CircuitID
        {
            get { return m_CircuitID; }
            set { m_CircuitID = value; }
        }
        public string ContractDueDate
        {
            get { return m_ContractDueDate; }
            set { m_ContractDueDate = value; }
        }
        public string PaidBy
        {
            get { return m_PaidBy; }
            set { m_PaidBy = value; }
        }
        public string Tag
        {
            get { return m_Tag; }
            set { m_Tag = value; }
        }

        #endregion

        #region Initialization
        public Leaseline()
        {

        }
        #endregion
    }
}
