using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;//추가
using LiveCharts.Wpf;//추가

namespace _015_LiveChart
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        //필드 : 멤버 변수 :소문자로 시작하는 게 관례
        private int xCount = 0;
        //속성(property)는 대문자로 시작하는 게 관례
        public SeriesCollection SeriesCollection { get; set; }//prop 입력 후 탭 누름 / 변수형을 Int->SeriesCollection /객체 이름 MyProperty->SeriesCollection
        public String[] XMarks { get; set; }
        public Func<double, string> Values { get; set; }//double로 받아서 string으로 리턴

        public MainWindow()
        {
            InitializeComponent();

            //LiveChart에 Binding해서 표시할 데이터는 MainWindow 클래스의 속성으로 정의한다.
            SeriesCollection = new SeriesCollection
            {
                new LineSeries//LineSeries ==> ColumnSereis로 바꾸면 막대그래프로 바뀜
                {
                    Title ="2020",
                    Values = new ChartValues<double>{3,5,7,6,4,8}//아무 숫자 입력
                },
                new LineSeries
                {
                    Title ="2021",
                    Values = new ChartValues<double>{4,2,6,7,2,3}
                },
                new LineSeries
                {
                    Title ="2022",
                    Values = new ChartValues<double>{7,9,1,3,4,6}
                }
            };

            //새로운 데이터 추가 방법
            LineSeries ls = new LineSeries();
            ls.Title = "2023";
            ls.Values = new ChartValues<double> { 5, 5, 7, 8, 9, 15 };
            SeriesCollection.Add(ls);

            XMarks = new string[] { "Susan", "Cho", "Kim", "Choi", "Park", "Song" };
            Values = value => value.ToString("N"); // Values를 value를 매게변수로 해서 =>Tostirng("N")자연수로 바꿔서 출력


            DataContext = this;//데이터 바인딩
           
        }
    }
}
