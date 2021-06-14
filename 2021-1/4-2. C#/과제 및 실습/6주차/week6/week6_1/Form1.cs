using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6_1
{
    public partial class Form1 : Form
    {
        //인스턴스 변수
        Car[] _cars = new Car[10];
        int _currentCarCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();
            if(true == string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("차량 번호를 반드시 넣어주세요 . ");
                return; //메소드 탈출문
            }

            for(int i = 0; i < _currentCarCount; i++)
            {
                if(_cars[i].CarNumber == number)
                {
                    MessageBox.Show("현재 입고되어 있는 차량 번호입니다.");
                    return;
                }
            }

                _cars[_currentCarCount]= new Car();
                _cars[_currentCarCount].CarNumber = number;
                //test 현재 시간보다 47분전
                var now_dateTime = DateTime.Now.AddMinutes(-47);
                _cars[_currentCarCount].InTime = now_dateTime;

                _currentCarCount++;

                MessageBox.Show($"{number} 차량 입고완료");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            string number = tbxNumber.Text.Trim();
            if (true == string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("차량 번호를 반드시 넣어주세요 . ");
                return; //메소드 탈출문
            }

            for (int i = 0; i < _currentCarCount; i++)
            {
                if (_cars[i].CarNumber == number)
                {
                    _cars[i].OutTime = DateTime.Now;
                    int charge = _cars[i].CalcParkingCharge();
                    int min = _cars[i].ParkingTime();

                    if(charge == 0)
                    {
                        MessageBox.Show($"회차 차량입니다. ({min})분");
                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0}분 주차 / {1}원", min, charge));
                    }

                    for(int j = i; j < this._currentCarCount - 1; j++)
                    {
                       this. _cars[j] =this. _cars[j + 1];
                    }
                    _cars[--this._currentCarCount] = null;

                    return;
                }
              }
                MessageBox.Show("현재 입고 되어있는 차량이 없습니다.");
            }

        private void btnView_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            for(int i = 0; i < _currentCarCount; i++)
            {
                message += string.Format("[{0}] 입고시간 : {1} 주차시간 : {2}{3}"
                    ,_cars[i].CarNumber
                    ,_cars[i].InTime
                    ,_cars[i].ParkingTime()
                    ,Environment.NewLine
                    );
            }
            tbxView.Text = message;
        }
    }
}
