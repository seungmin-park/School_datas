using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6_4
{
    public partial class Form1 : Form
    {
        //인스턴스 변수
        List<Car> _cars = new List<Car>();//Car[] _cars = new Car[10]; int _currentCarCount = 0;

        //생성자 : Class 이름과 동일, 반환타입이 없다.
        //특수 메소드
        public Form1()
        {
            InitializeComponent();
        }

        //인스턴스 메소드
        //메소드 Overloading
        //메소드 이름은 동일
        //메소드 매개변수의 갯수나 타입이 다르면 됩니다.
        private void btnIn_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();

            if (!CheckCarNumber(number))
            {
                MessageBox.Show("차량번호의 형식이 어긋났습니다.");
                return;
            }
            if (SearhCar(number) != null)
            {
                MessageBox.Show("현재 입고되어 있는 차량 번호입니다.");
                return;
            }

            //Car newCar = new Car();//기본 생성자 호출
            //newCar.CarNumber = number;
            //newCar.InTime = DateTime.Now.AddMinutes(MakeTestTime());

            Car newCar = new Car(number);
            _cars.Add(newCar);

            MessageBox.Show($"{number} 차량 입고완료");
            ViewStatus();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            string number = tbxNumber.Text.Trim();
            if (!CheckCarNumber(number))
            {
                MessageBox.Show("차량번호의 형식이 어긋났습니다.");
                return;
            }

            var car = SearhCar(number);

            if (car != null)
            {
                car.OutTime = DateTime.Now;// == car.GoOut();  == car._outTime = DateTime.Now;
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
            }
            else
            {
                MessageBox.Show("현재 입고 되어있는 차량이 없습니다.");
            }
            ViewStatus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStatus();
        }

        //메소드 정의
        private bool CheckCarNumber(string number)
        {
            Regex regx = new Regex(@"^[0-9]{2,3}[가-힣]{1}[0-9]{4}$");
            Match m = regx.Match(number);
            return m.Success;
        }

        private Car SearhCar(string number)
        {
            foreach (var car in _cars)
            {
                if (car.CarNumber == number)
                {
                    return car;
                }
            }
            return null;
        }
        private void ViewStatus()
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
    }//class
}//namespace
