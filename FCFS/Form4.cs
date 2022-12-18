using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form4 : Form
    {
        private readonly int[] process = new int[6];
        private readonly int[,] allocation = new int[5, 3];
        private readonly int[,] max = new int[5, 3];
        private readonly int[,] need = new int[5, 3];
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //                                                Allocation
            //alc a
            allocation[0, 0] = Convert.ToInt32(txt_p0a_alc.Text);
            allocation[1, 0] = Convert.ToInt32(txt_p1a_alc.Text);
            allocation[2, 0] = Convert.ToInt32(txt_p2a_alc.Text);
            allocation[3, 0] = Convert.ToInt32(txt_p3a_alc.Text);
            allocation[4, 0] = Convert.ToInt32(txt_p4a_alc.Text);
            //alc b
            allocation[0, 1] = Convert.ToInt32(txt_p0b_alc.Text);
            allocation[1, 1] = Convert.ToInt32(txt_p1b_alc.Text);
            allocation[2, 1] = Convert.ToInt32(txt_p2b_alc.Text);
            allocation[3, 1] = Convert.ToInt32(txt_p3b_alc.Text);
            allocation[4, 1] = Convert.ToInt32(txt_p4b_alc.Text);
            // alc c
            allocation[0, 2] = Convert.ToInt32(txt_p0c_alc.Text);
            allocation[1, 2] = Convert.ToInt32(txt_p1c_alc.Text);
            allocation[2, 2] = Convert.ToInt32(txt_p2c_alc.Text);
            allocation[3, 2] = Convert.ToInt32(txt_p3c_alc.Text);
            allocation[4, 2] = Convert.ToInt32(txt_p4c_alc.Text);
          
            //                                                       max
            
            //max a
            max[0, 0] = Convert.ToInt32(txt_p0a_m.Text);
            max[1, 0] = Convert.ToInt32(txt_p1a_m.Text);
            max[2, 0] = Convert.ToInt32(txt_p2a_m.Text);
            max[3, 0] = Convert.ToInt32(txt_p3a_m.Text);
            max[4, 0] = Convert.ToInt32(txt_p4a_m.Text);
            //max b
            max[0, 1] = Convert.ToInt32(txt_p0b_m.Text);
            max[1, 1] = Convert.ToInt32(txt_p1b_m.Text);
            max[2, 1] = Convert.ToInt32(txt_p2b_m.Text);
            max[3, 1] = Convert.ToInt32(txt_p3b_m.Text);
            max[4, 1] = Convert.ToInt32(txt_p4b_m.Text);
            //max c
            max[0, 2] = Convert.ToInt32(txt_p0c_m.Text);
            max[1, 2] = Convert.ToInt32(txt_p1c_m.Text);
            max[2, 2] = Convert.ToInt32(txt_p2c_m.Text);
            max[3, 2] = Convert.ToInt32(txt_p3c_m.Text);
            max[4, 2] = Convert.ToInt32(txt_p4c_m.Text);
            //calculate need
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    need[i, j] = max[i, j] - allocation[i, j];
                }
            }
           
            
            //need a
            txt_p0a_nd.Text = Convert.ToString(need[0, 0]);
            txt_p1a_nd.Text = Convert.ToString(need[1, 0]);
            txt_p2a_nd.Text = Convert.ToString(need[2, 0]);
            txt_p3a_nd.Text = Convert.ToString(need[3, 0]);
            txt_p4a_nd.Text = Convert.ToString(need[4, 0]);
            //need b
            txt_p0b_nd.Text = Convert.ToString(need[0, 1]);
            txt_p1b_nd.Text = Convert.ToString(need[1, 1]);
            txt_p2b_nd.Text = Convert.ToString(need[2, 1]);
            txt_p3b_nd.Text = Convert.ToString(need[3, 1]);
            txt_p4b_nd.Text = Convert.ToString(need[4, 1]);
            //need c
            txt_p0c_nd.Text = Convert.ToString(need[0, 2]);
            txt_p1c_nd.Text = Convert.ToString(need[1, 2]);
            txt_p2c_nd.Text = Convert.ToString(need[2, 2]);
            txt_p3c_nd.Text = Convert.ToString(need[3, 2]);
            txt_p4c_nd.Text = Convert.ToString(need[4, 2]);

        }

        private void btn_banker_Click(object sender, EventArgs e)
        {
            
            //Banker algorithem
            
            int count = 0, nonprocessed = 5;

            while (nonprocessed > 0)
            {

                for (int i = 0; i < 5 && count <= 5; i++)
                {
                    int x = need[i, 0];
                    int y = need[i, 1];
                    int z = need[i, 2];
                    if (x <= Convert.ToInt32(txt_Aavailable.Text) && y <= Convert.ToInt32(txt_Bavailable.Text) && z <= Convert.ToInt32(txt_Cavailable.Text))
                    {

                        process[count] = i;
                        count++;
                        txt_Aavailable.Text = Convert.ToString(allocation[i, 0] + Convert.ToInt32(txt_Aavailable.Text));
                        txt_Bavailable.Text = Convert.ToString(allocation[i, 1] + Convert.ToInt32(txt_Bavailable.Text));
                        txt_Cavailable.Text = Convert.ToString(allocation[i, 2] + Convert.ToInt32(txt_Cavailable.Text));
                        nonprocessed--;
                    }





                }
            }
         

            string result = "Order of process after scheduling  with Banker Algoristm is : " + " P" + process[0] + " ,P" + process[1] + " ,P" + process[2] + " ,P" + process[3] + " ,P" + process[5];
           
            rtxt_messages.Text = result;
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}

