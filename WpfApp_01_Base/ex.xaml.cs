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

namespace WpfApp_01_Base
{
    /// <summary>
    /// Interaction logic for ex.xaml
    /// </summary>
    public partial class ex : Window
    {
        public ex()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ID = ID_I.Text;
            string PW = PW_I.Text;

            if (ID != "" && PW != "")
            {
                MessageBox.Show($"로그인 시도: {ID}/{PW}");
            }else
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
            }
        }
    }
}
