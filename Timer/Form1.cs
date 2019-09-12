using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormTimer : Form
    {
        int endtime;    //終了時間
        int nowtime;    //経過時間

        public FormTimer()
        {
            InitializeComponent();
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        //ボタンクリック時の処理
        private void Start_Click(object sender, EventArgs e)
        {
            //時間設定のTextBoxの内容を、終了時間の変数に取得
            if (!int.TryParse(SetTime.Text, out endtime))
            {
                endtime = 1;
            }

            //残り時間を計算するため、経過時間の変数を0で初期化
            nowtime = 0;

            //タイマースタート
            timerControl.Start();

        }

        private void TimerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime;  //残り時間

            nowtime++;  //経過時間に1秒を加える

            //残り時間を計算して表示
            remainingTime = endtime - nowtime;
            RemainingTime.Text = remainingTime.ToString();

            //設定時間になったかどうかの判定
            if (endtime == nowtime)
            {
                timerControl.Stop();    //タイマーを止める
                MessageBox.Show("時間になりました！");
            }
            else
            {

            }



        }
    }
}
