using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace _010_MatchingGame
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };
        int[] rnd = new int[16];

        Button first = null;
        Button second = null;
        int matched = 0;

        DispatcherTimer myTimer = new DispatcherTimer();//사용하려면 17번 째 줄에 using을 입력해야함
        public MainWindow()
        {
            InitializeComponent();

            Boardset();
            myTimer.Interval = new TimeSpan(0, 0, 0, 0, 750);//일, 시, 분, 초, 밀리초 ==> 0.75초
            myTimer.Tick += MyTimer_Tick;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = MakeImage("../../Images/check.png");
            second.Content = MakeImage("../../Images/check.png");
            first = null;
            second = null;
        }

        private void Boardset() // 중요
        {
            for(int i = 0; i <16; i++)
            {
                Button c = new Button();
                c.Background = Brushes.White;
                c.Margin = new Thickness(10);
                c.Content = MakeImage("../../Images/check.png");
                c.Tag = TagSet();
                Board.Children.Add(c);
                c.Click += C_Click;
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = sender as Button; =
            Button btn = (Button)sender;

            string fruitName = icon[(int)btn.Tag];

            if(first == null) //첫 번째 버튼 : 무조건 그림이 나와야함
            {
                first = btn;
                btn.Content = MakeImage("../../Images/" + fruitName + ".png");
                return;
            }
            else if (second == null)// 두 번째 버튼
            {
                second = btn;
                btn.Content = MakeImage("../../Images/" + fruitName + ".png");
            }
            else
            {
                return;
            }

            //first와 second가 매칭되는지 체크
            if((int)first.Tag == (int)second.Tag)//Tag는 object이기 때문에 정수형으로 바꿔야함
            {
                first = null;
                second = null;
                matched += 2;
                if(matched >= 16)
                {
                    MessageBoxResult res = MessageBox.Show("성공했습니다. 다시 시작할까요?", "성공", MessageBoxButton.YesNo);
                    if(res == MessageBoxResult.Yes)
                    {
                        resetRnd();
                        Board.Children.Clear();
                        Boardset();
                        matched = 0;
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else //매칭이 안되있을 때
            {
                myTimer.Start();
            }
        }


        private void resetRnd()
        {
            for(int i =0; i<16; i++)
            {
                rnd[i] = 0;
            }
        }

        private Image MakeImage(string v)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Relative);
            bi.EndInit();

            //비트맵 이미지로 변환 
            Image img = new Image();
            img.Margin = new Thickness(10);
            img.Stretch = Stretch.Fill;
            img.Source = bi;

            return img;
        }

        private int TagSet() // 중요
        {
            int i;
            Random r = new Random();

            while(true)
            {
                i = r.Next(16);
                if (rnd[i] == 0)
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i % 8;
        }
    }
}
