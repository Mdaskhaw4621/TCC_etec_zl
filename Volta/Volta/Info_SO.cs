using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace WindowsFormsApplication1
{
    class Info_SO
    {
        public static string getNome_PC()
        {
            Computer comp = new Computer();

            string PC_nome = comp.Name;


            return PC_nome;

        }

        public static string getNome_SO()
        {
            Computer comp = new Computer();

            string nome_SO = comp.Info.OSFullName;

            return nome_SO;
        }

        public static string getVersao_SO()
        {
            Computer comp = new Computer();

            string versao_SO = comp.Info.OSVersion;

            return versao_SO;
        }
    }
}
