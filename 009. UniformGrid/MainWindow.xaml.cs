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

namespace _009.UniformGrid
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChessBoard.Rows = 8;
            ChessBoard.Columns = 8;

            for(int i=0; i<64; i++)
            {
                if ((i/8) % 2 == 1) //짝수줄
                {
                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Black;
                    ChessBoard.Children.Add(r1);

                    Rectangle r2 = new Rectangle();
                    r2.Fill = Brushes.Red;
                    ChessBoard.Children.Add(r2);
                }
                else
                {                    
                    Rectangle r2 = new Rectangle();
                    r2.Fill = Brushes.Red;
                    ChessBoard.Children.Add(r2);

                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Black;
                    ChessBoard.Children.Add(r1);
                }
            }
        }
    }
}


//체스판 만들기 다시해보기? 이거 좋은 프로그램은 아니라고 함