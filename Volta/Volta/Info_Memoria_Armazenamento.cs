using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace WindowsFormsApplication1
{
    
    class Info_Memoria_Armazenamento
    {
        //Memoria RAM
        
            
            public static string getTotal_RAM()
            {   
                Computer computer = new Computer();
                String RAM_total = String.Empty;

                double total_RAM = computer.Info.TotalPhysicalMemory / 1024/1024/1024 ;

                RAM_total = total_RAM.ToString("n2");

                return RAM_total;
            }

            public static string getLivre_RAM()
            {
                Computer computer = new Computer();
                String RAM_livre = String.Empty;

                double livre_RAM = computer.Info.AvailablePhysicalMemory / 1024 / 1024 / 1024;

                RAM_livre = livre_RAM.ToString("n2");

                return RAM_livre;
            }

        //Disco Rigido

            public static string getLivreEsp_HD()
            {
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"") ;

                String HD_livre = String.Empty;


                double livre_HD = Convert.ToInt64(disk["FreeSpace"])/1024/1024/1024;
                HD_livre = livre_HD.ToString("n2");
                   
                
                 return HD_livre;
            }

            public static string getTotalEsp_HD()
                {
                    ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");

                    String HD_total = String.Empty;
                      
                          double total_HD  = Convert.ToInt64(disk["Size"])/1024/1024/1024;
                          HD_total = total_HD.ToString("n2");
                        
                     return HD_total;
                }
    }
}
