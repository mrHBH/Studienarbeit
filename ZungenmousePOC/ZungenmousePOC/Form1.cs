using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace ZungenmousePOC
{
    public partial class Form1 : Form
    {

        ///Values read from the sensor , automatically refreshed.
        int left, right, up, down, X, Y;
        int Vx, Vy;
        int tmp1, tmp2 = 0;
        static public string comPort = "COM3";
        Queue<int> RightQueue = new Queue<int>();
        Queue<int> LeftQueue = new Queue<int>();
        Queue<int> UpQueue = new Queue<int>();
        Queue<int> DownQueue = new Queue<int>();
        Queue<int> XQueue = new Queue<int>();

        private void ComPortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comPort = this.ComPortCombo.Text;
            Console.WriteLine(comPort);
        }

        Queue<int> YQueue = new Queue<int>();





        public Form1()
        {
            InitializeComponent();
        }

        // Initialises the com port , setup eventHandler SerialDataReceived 
        private  void  ConnectSerial_Click(object sender, EventArgs e)
        {//while (!HardwareConnection.ZungenMausCOMPort.IsOpen)
            {
                try
                {

                    HardwareConnection.Init();
                    HardwareConnection.ZungenMausCOMPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
                    processValues();
                }
                catch {
                    MessageBox.Show("Could not open COM port", "Error", MessageBoxButtons.OK);
                } }
        }

        //Parses incoming Data Line string , calls processValues()
        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var rawinput=HardwareConnection.ZungenMausCOMPort.ReadLine();
            var list=rawinput.Split(',');
            try
            {
                down = Int32.Parse(list[6]);
                up = Int32.Parse(list[1]);
                left = Int32.Parse(list[8]);
                right = Int32.Parse(list[5]);
                X = Int32.Parse(list[9].Split(':')[1]);
                Y = Int32.Parse(list[10].Split(':')[1]);
                processValues();
                //AppendTextBox(" up: " + up + " left: " + left + " right:" + right + " down:" + down + " X: " + X + "Y :"+ Y +  Environment.NewLine);
            }
            catch { }
            }


        private void processValues()
        {
            RightQueue.Enqueue(right);
            LeftQueue.Enqueue(left);
            UpQueue.Enqueue(up);
            DownQueue.Enqueue(down);
            XQueue.Enqueue(X);
            YQueue.Enqueue(Y);

            if (XQueue.Count  > 1)
            {
                tmp1 = (/*XQueue.ElementAt(4) + XQueue.ElementAt(3) + XQueue.ElementAt(2) + XQueue.ElementAt(1) + */XQueue.ElementAt(0) ) / 2;
                tmp2 = (/*YQueue.ElementAt(4) + YQueue.ElementAt(3) + YQueue.ElementAt(2) +YQueue.ElementAt(1) +*/ YQueue.ElementAt(0)) / 2;


                AppendTextBox( "Vx: " + Pointer.Location.X + Vx + " Vy: " + Pointer.Location.Y + Vy);

                PlaceCursor(Pointer.Location.X - Vx  , Pointer.Location.Y + Vy );
                Vx = tmp1/100;
                Vy = tmp2/100;
                XQueue.Clear();
                YQueue.Clear();
            }
            
           // if (down> 350 | up>350 | left> 350 | right> 350)
           // {
           //     PlaceCursor(X , Y);
           //   // var pos = Pointer.Location;
           //   // pos.X += X;
           //   // pos.Y += Y;
           //   //
           //   // Pointer.Location=new Point(  20,   20);
           // }


        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            LogTextBox.ScrollToCaret();
            LogTextBox.Text = value;
           
        }


        public void PlaceCursor(int x, int y)
        {
            if (x > 0 & x < Frame.Width & y > 0 & y < Frame.Height)
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<int, int>(PlaceCursor), new object[] { x, y }); ;
                    return;
                }
                Pointer.Location = new Point(x, y);
            }
        }











    }
}
