using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace WindowsFormsApplication1
{
    class Info_PlacaMae
    {
        public static string getModelo_MB()
        {
            ManagementObjectSearcher objMB = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_BaseBoard");

            String MB_modelo = String.Empty;

            foreach (ManagementObject mo in objMB.Get())
            {
                try
                {
                    MB_modelo = mo.GetPropertyValue("Product").ToString();
                }
                catch (Exception ex) { }
            }
            return MB_modelo; 
        }


        public static string getFabricante_MB()
        {
            ManagementObjectSearcher objMB = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_BaseBoard");

            String MB_fab = String.Empty;

            foreach (ManagementObject mo in objMB.Get())
            {
                try
                {
                    MB_fab = mo.GetPropertyValue("Manufacturer").ToString();
                }
                catch (Exception ex) { }
            }
            return MB_fab;
        }

        public static string getSerialNum_MB()
        {
            ManagementObjectSearcher objMB = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_BaseBoard");

            String MB_serNum = String.Empty;

            foreach (ManagementObject mo in objMB.Get())
            {
                try
                {
                    MB_serNum = mo.GetPropertyValue("SerialNumber").ToString();
                }
                catch (Exception ex) { }
            }
            return MB_serNum;
        }
    }
}
