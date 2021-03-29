using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
namespace ZungenmousePOC
{
   

    static class HardwareConnection
    {
        static public  SerialPort ZungenMausCOMPort = new SerialPort(Form1.comPort, 9600);
        
        public static void Init()
        {
            if (!(ZungenMausCOMPort.IsOpen))
            {
                try
                {
                    ZungenMausCOMPort = new SerialPort(Form1.comPort, 9600);
                    ZungenMausCOMPort.Open();
                    ZungenMausCOMPort.DiscardOutBuffer();
                    ZungenMausCOMPort.DiscardInBuffer();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not open " + Form1.comPort);
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Could not open COM port", "Error", MessageBoxButtons.OK);
                }

              
             
            }
            
        }

    }

   
}
