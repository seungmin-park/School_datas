using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6_3
{
    public partial class Form1 : Form
    {
        //인스턴스 변수
        List<Car> _cars = new List<Car>();//Car[] _cars = new Car[10]; int _currentCarCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();
            if (true == string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("차량 번호를 반드시 넣어주세요 . ");
                return; //메소드 탈출문
            }

            foreach (Car car in _cars)
            {
                if (car.CarNumber == number)
                {
                    MessageBox.Show("현재 입고되어 있는 차량 번호입니다.");
                    return;
                }
            }
            //for (int i = 0; i < _cars.Count; i++)
            //{
            //    if (_cars[i].CarNumber == number)
            //    {
            //        MessageBox.Show("현재 입고되어 있는 차량 번호입니다.");
            //        return;
            //    }
            // }
            Car newCar = new Car();
            newCar.CarNumber = number;
            newCar.InTime = DateTime.Now.AddMinutes(-47);

            _cars.Add(newCar);

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

            foreach (var car in _cars)
            {
                if (car.CarNumber == number)
                {
                    car.OutTime = DateTime.Now;
                    int charge = car.CalcParkingCharge();
                    int min = car.ParkingTime();

                    if (charge == 0)
                    {
                        MessageBox.Show($"회차 차량입니다. ({min})분");
                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0}분 주차 / {1}원", min, charge));
                    }

                    this._cars.Remove(car);

                    return;
                }
            }

            //for (int i = 0; i < _cars.Count; i++)
            //{
            //    if (_cars[i].CarNumber == number)
            //    {
            //        _cars[i].OutTime = DateTime.Now;
            //        int charge = _cars[i].CalcParkingCharge();
            //        int min = _cars[i].ParkingTime();

            //        //for (int j = i; j < this._cars.Count - 1; j++)
            //        //{
            //        //    this._cars[j] = this._cars[j + 1];
            //        //}
            //        // _cars[--this._currentCarCount] = null;
            //        _cars.Remove(i); == _cars.Remove(_cars[i]);

            //        return;
            //    }
            //}
            MessageBox.Show("현재 입고 되어있는 차량이 없습니다.");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            for (int i = 0; i < _cars.Count; i++)
            {
                message += string.Format("[{0}] 입고시간 : {1} 주차시간 : {2}{3}"
                    , _cars[i].CarNumber
                    , _cars[i].InTime
                    , _cars[i].ParkingTime()
                    , Environment.NewLine
                    );
            }
            tbxView.Text = message;
        }
    }
}
