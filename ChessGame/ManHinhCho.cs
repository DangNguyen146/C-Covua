using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class ManHinhCho : Form
    {
        public ManHinhCho()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            NhapTen nhapTen = new NhapTen();
            nhapTen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            JoinRoom joinRoom = new JoinRoom();
            joinRoom.Show();
        }
    }
}
