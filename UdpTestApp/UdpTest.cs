using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace UdpTestApp
{
    public partial class UdpTest : Form
    {
        const int MAXBUFFER_SIZE = 1500;
        byte[] packetTxBuffer = new byte[MAXBUFFER_SIZE];

        public UdpTest()
        {
            InitializeComponent();
        
            for (int i=0; i<MAXBUFFER_SIZE; i++)
            {
                packetTxBuffer[i] = (byte)i;
            }
        }

        public void SendPacket(byte[] buffer, int size, IPAddress address, int port)
        {
            IPEndPoint ipep = new IPEndPoint(address, port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            server.EnableBroadcast = true;
            server.SendTo(buffer, size, SocketFlags.None, ipep);
        }

        private void ButSendPacket_Click(object sender, EventArgs e)
        {
            if ( OptMulticast.Checked )
            {
                SendPacket(packetTxBuffer, (int)numPacketSize.Value, IPAddress.Parse("224.0.0.251"), (int)numPort.Value);
            }
            else if ( OptBroadcast.Checked)
            {
                SendPacket(packetTxBuffer, (int)numPacketSize.Value, IPAddress.Broadcast, (int)numPort.Value);
            }
            else
            {
                SendPacket(packetTxBuffer, (int)numPacketSize.Value, IPAddress.Parse(textBox1.Text), (int)numPort.Value);
            }
        }



    }
}
