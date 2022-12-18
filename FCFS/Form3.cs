using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FCFS
{
    public partial class Form3 : Form
    {
        static int n = 4;
        static float awt, atat;

        int[] process = { 1, 2, 3, 4 };
        int[] burst_time = new int[4];

        ArrayList arrList = new ArrayList();
        

        public Form3()
        {
            InitializeComponent();
        }

        private void button_FCFS_Click(object sender, EventArgs e)
        {
            arrList.Add(Convert.ToInt32(process1.Text));
            arrList.Add(Convert.ToInt32(process2.Text));
            arrList.Add(Convert.ToInt32(process3.Text));
            arrList.Add(Convert.ToInt32(process4.Text));
            arrList.Sort();

            foreach (var item in arrList)
            {
                checkedListBox1.Items.Add(item);
            }

            for (int count = 0; count < 4; count++){
                burst_time[count] = Convert.ToInt32(arrList[count]);
            }

            /*burst_time[0] = Convert.ToInt32(process1.Text);
            burst_time[1] = Convert.ToInt32(process2.Text);
            burst_time[2] = Convert.ToInt32(process3.Text);
            burst_time[3] = Convert.ToInt32(process4.Text);*/


            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1.Items[0].ToString() == process1.Text)
            {
                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                cpu.Text = "P1";
            }
            else if (checkedListBox1.Items[0].ToString() == process2.Text)
            {
                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                cpu.Text = "P2";
            }
            else if (checkedListBox1.Items[0].ToString() == process3.Text)
            {
                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                cpu.Text = "P3";
            }
            else if (checkedListBox1.Items[0].ToString() == process4.Text)
            {
                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                cpu.Text = "P4";
            }

            checkedListBox1.Items.RemoveAt(0);
            if (checkedListBox1.Items.Count <= 0)
            {
                timer1.Stop();
                findaver(process, n, burst_time);
                MessageBox.Show("Average waiting time = " + awt + "\n Average turn around time = " + atat);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;

            listView1.Columns.Add("Processes", 175);
            listView1.Columns.Add("Burst_Time", 175);
            listView1.Columns.Add("Waiting_Time", 175);
            listView1.Columns.Add("Turn_around_Time", 175);
        }
        void findaver(int[] processess, int n, int[] burst)
        {
            int[] wt = new int[n];
            int[] tat = new int[n];


            findwaitingtime(processess, n, burst, wt);
            findturnaroundtime(processess, n, burst, wt, tat);


            int total_wt = 0;
            int total_tat = 0;


            for (int i = 0; i < n; i++)
            {
                total_wt += wt[i];
                total_tat += tat[i];



                string[] row = { (i + 1).ToString(), burst[i].ToString(), wt[i].ToString(), tat[i].ToString() };
                var ListViewItem = new ListViewItem(row);

                listView1.Items.Add(ListViewItem);



            }
            float m = n;
            awt = total_wt / m;
            atat = total_tat / m;
        }

        void findwaitingtime(int[] processess, int n, int[] burst, int[] wt)
        {
            wt[0] = 0;
            for (int i = 1; i < n; i++)
            {
                wt[i] = burst[i - 1] + wt[i - 1];
            }

        }
        private void buttonhome_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        void findturnaroundtime(int[] processess, int n, int[] burst, int[] wt, int[] tat)
        {

            for (int i = 0; i < n; i++)
            {
                tat[i] = burst[i] + wt[i];
            }

        }
    }
}
