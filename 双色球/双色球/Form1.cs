using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 双色球
{
    public partial class Form1 : Form
    {
        Boolean start = true;
        public Form1()
        {
            InitializeComponent();
            labRed1.Text = "00";
            labRed2.Text = "00";
            labRed3.Text = "00";
            labRed4.Text = "00";
            labRed5.Text = "00";
            labRed6.Text = "00";
            labBlue.Text = "00";
            End.Enabled = false;
        }

        private static Object redNum_lock = new Object();

        private void Begin_Click(object sender, EventArgs e)
        {
            Begin.Text = "开始...";
            Begin.Enabled = false;
            start = true;
            List<Task> listTask = new List<Task>();
            TaskFactory tskf = new TaskFactory();
            var controls = groupBox.Controls;
            foreach (var control in controls)
            {
                if (control.GetType() != typeof(Label))
                {
                    continue;
                }
                var label = control as Label;
                listTask.Add(tskf.StartNew(new Action(() =>
                {
                    while (start)
                    {
                        Thread.Sleep(200);
                        var text = GeNum(label);
                        UpdateLabl(label, text);
                        //Console.WriteLine("label:[{0}],value:[{1}]", label.Name, text);
                    }
                })));
            }
            tskf.ContinueWhenAll(listTask.ToArray(), (rest) => { ShowMessage(); });
            //MessageBox.Show("主线程结束了。。。", "结果");
            Thread.Sleep(1000);
            End.Enabled = true;
        }

        private void End_Click(object sender, EventArgs e)
        {
            start = false;
            Begin.Text = "开始";
            Begin.Enabled = true;
            End.Enabled = false;
        }

        private void ShowMessage()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{6},{5},{4},{3},{2},{1},{0}", GetPanleNums().ToArray());
            MessageBox.Show(sb.ToString(), "结果");
        }

        private List<String> GetPanleNums()
        {
            List<String> list = new List<string>();
            var controls = groupBox.Controls;
            for (int i = 0; i < controls.Count;i++ )
            {
                var control = controls[i];
                if (control.GetType() != typeof(Label))
                {
                    continue;
                }
                var label = control as Label;
                list.Add(label.Text);
            }
            return list;
        }

        private String[] RedNums = 
        { 
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10"
            , "11", "12", "13", "14", "15", "16", "17", "18", "19","20" 
            , "21", "22", "23", "24", "25", "26", "27", "28", "29","30" 
            , "31", "32", "33"
        };

        private String[] BlueNums = 
        { 
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10"
            , "11", "12", "13", "14", "15", "16"
        };

        private void UpdateLabl(Label lbl, String text)
        {
            if (lbl.InvokeRequired)
            {
                this.Invoke(new Action(() => lbl.Text = text));
            }else
            {
                lbl.Text = text;
            }
        }

        private String GeNum(Label lbl)
        {
            if (lbl.Name == "labBlue")
            {
                return BlueNums[new Random().Next(0, BlueNums.Length - 1)];//0-15
            }
            else
            {
                var text = RedNums[new Random().Next(0, RedNums.Length - 1)];//0-32
                lock (redNum_lock)
                {
                    while (GetPanleNums().ToArray().Contains(text))
                    {
                        text = RedNums[new Random().Next(0, RedNums.Length - 1)];//0-32
                    }
                }
                return text;
            }
        }
    }
}
