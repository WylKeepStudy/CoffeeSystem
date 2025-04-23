using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _316
{
    public partial class Splash : Form
    {
        //构造函数
        public Splash()
        {
            InitializeComponent(); //自动生成的方法，用于初始化窗体上的控件（如按钮、标签、进度条等）
        }

        //加载窗体时启动定时器
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //进度条初始值
        int startpos = 0; 

        // 定时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 5;
            MyProgress.Value = startpos;
            PercentageLbl.Text = startpos + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

    }
}
