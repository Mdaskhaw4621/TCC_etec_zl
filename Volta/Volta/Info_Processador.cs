using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    class Info_Processador
    {

        public static string getNome_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_nome = String.Empty;

            foreach(ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_nome = mo.GetPropertyValue("Name").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_nome;
        }

        public static string getNumberC_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_NumC = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_NumC = mo.GetPropertyValue("NumberOfCores").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_NumC;
        }

        public static string getNumberLP_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_NumLP = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_NumLP = mo.GetPropertyValue("NumberOfLogicalProcessors").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_NumLP;
        }

        public static string getFabri_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_fabric = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_fabric = mo.GetPropertyValue("Manufacturer").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_fabric;
        }

        public static string getNumSerial_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_ser_num = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_ser_num = mo.GetPropertyValue("ProcessorID").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_ser_num;
        }

        public static string getMaxSpeedClock_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_mcs_CPU = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_mcs_CPU = (Convert.ToDouble(mo.GetPropertyValue("MaxClockSpeed"))/1000).ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_mcs_CPU;
        }

        public static string getAtualSpeedClock_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_ccs = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_ccs = (Convert.ToDouble(mo.GetPropertyValue("CurrentClockSpeed")) / 1000).ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_ccs;

        }
       
        /*public static  getVolt_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            UInt32 CPU_volt;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_volt = (mo.GetPropertyValue("VoltegeCaps");
                }
                catch (Exception ex) { }
            }
            return CPU_volt;
        }*/

        /*public static string getArqui_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_arqui = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_arqui = mo.GetPropertyValue("Version").ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_arqui;
        }*/

        public static string getCacheSizeL2_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_l2cs = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_l2cs = (Convert.ToDouble(mo.GetPropertyValue("L2CacheSize")) / 1024).ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_l2cs;

        }

        public static string getCacheSizeL3_CPU()
        {
            ManagementObjectSearcher objCPU = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_Processor");

            String CPU_l3cs = String.Empty;

            foreach (ManagementObject mo in objCPU.Get())
            {
                try
                {
                    CPU_l3cs = (Convert.ToDouble(mo.GetPropertyValue("L3CacheSize")) / 1024).ToString();
                }
                catch (Exception ex) { }
            }
            return CPU_l3cs;

        }

    }
}
