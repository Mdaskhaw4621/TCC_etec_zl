using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    class Info_BIOS
    {

       
        public static string getFornecedorBIOS()
        {
            ManagementObjectSearcher objBIOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            String BIOS_forn = String.Empty;

            foreach (ManagementObject mo in objBIOS.Get())
            {
                try
                {
                    BIOS_forn = mo.GetPropertyValue("Manufacturer").ToString();
                }
                catch(Exception ex) { } 
            }
            return BIOS_forn;
        }
            
        public static string getNomeBIOS()
        {
            ManagementObjectSearcher objBIOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            String BIOS_nome = String.Empty;

            foreach (ManagementObject mo in objBIOS.Get()) 
            {
                try
                {
                    BIOS_nome = mo.GetPropertyValue("Name").ToString();
                }
                catch (Exception ex) { }
            }
            return BIOS_nome;
        }

        public static string getVersaoBIOS()
        {
            ManagementObjectSearcher objBIOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            String BIOS_versao = String.Empty;

            foreach (ManagementObject mo in objBIOS.Get()) 
            {
                try
                {
                    BIOS_versao = mo.GetPropertyValue("SMBIOSBIOSVersion").ToString();
                }
                catch (Exception ex) { }
            }
            return BIOS_versao;
        }

        public static string getDataBIOS()
        {
            ManagementObjectSearcher objBIOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            String BIOS_versao = String.Empty;

            foreach (ManagementObject mo in objBIOS.Get()) 
            {
                try
                {
                    BIOS_versao = mo.GetPropertyValue("SMBIOSBIOSVersion").ToString();
                }
                catch (Exception ex) { }
            }
            return BIOS_versao;
        }

    }
}
