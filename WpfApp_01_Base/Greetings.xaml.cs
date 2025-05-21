using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (HelloButton.IsChecked == true)
            {
                MessageBox.Show("Hello.");
            }
            else if (GoodbyeButton.IsChecked == true)
            {
                MessageBox.Show("Goodbye.");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string result = "";

            if (radioMale.IsChecked == true)
            {
                result = "남성을 선택했습니다.";
            } else if(radioFemale.IsChecked == true)
            {
                result = "여성을 선택했습니다.";
            }
            MessageBox.Show(result);
        }
        private void radioMale_Checked(object sender, RoutedEventArgs e)
        {
        //   MessageBox.Show("남성을 선택", "라디오 선택 결과");
        }
        private void radioFemale_Checked(object sender, RoutedEventArgs e)
        {
        //    MessageBox.Show("여성을 선택", "라디오 선택 결과");
        }
        //Slider 이벤트 - 실시간 값 변화
        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(volumeText != null)
            {
                volumeText.Text = $"현재 값: {volumeSlider.Value}";
            }
        }
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            //체크된 항목들을 문자열로 조합
            List<string> selectedFruits = new List<string>();

            if (checkBoxApple.IsChecked == true)
            {
                selectedFruits.Add("Apple");
            }
            if (checkBoxBanana.IsChecked == true)
            {
                selectedFruits.Add("Banana");
            }
            if (checkBoxOrange.IsChecked == true)
            {
                selectedFruits.Add("Orange");
            }

            //결과 표시
            textResult.Text = $"선택한 과일: {string.Join(",", selectedFruits)}";
        }

        private void checkBoxState_Click(object sender, RoutedEventArgs e)
        {
            bool? state = checkBoxState.IsChecked;

            if(state == true)
            {
                textStatus.Text = "현재 상태: 체크됨(true)";
            }
            else if(state == false)
            {
                textStatus.Text = "현재 상태: 해제됨(false)";
            }
            else
            {
                textStatus.Text = "현재 상태: 중간상태(null)";
            }
        }
    }
}

#region 1. Tab Control

/*
 * -웹 브라우저처럼 탭 버튼을 눌러 다른 내용의 화면 전환
 * 
 * 1) TabControl
 * -전체 탭 컨테이너
 * -내부에 여러개 TabItem을 가질 수 있음
 * 
 * 2) TabItem
 * -각각의 탭을 나타내는 항목
 * -Header: 탭 제목
 * -Content: 보여줄 컨텐츠(UI) 배치
 */

#endregion

#region 2. StackPanel

/*
 * 자식 요소들을 수직(vertical) 또는 수평(horizontal) 방향으로 자동 정렬해서 배치하는 레이아웃 패널
 * -요소들을 순서대로 쌓음
 * -마우스 조작으로 요소 이동 불가
 * 
 * 속성
 * Orientation: 쌓는 방향 지정 - vertical(기본), Horizontal
 */

#endregion

#region 3. Grid

/*
 * -행과 열을 나눠 엑셀 표처럼 UI 요소를 격자(Grid) 구조로 배치 할 수 있는 레이아웃 패널
 * 
 * 속성
 * -RowDefinition: 행(가로) 만들기
 * -ColumnDefintion: 열(세로) 만들기
 * 
 * Height / Width
 * -Auto: 내부 요소 크기에 맞게 자동 설정
 * -*: 나머지 공간을 비율로 자동분배
 * -숫자(px): 고정 크기(pixel)
 * 
 * 사용시기
 * 1) 요소들이 표 형태로 정리되어야 할 때
 * 2) 요소들이 정확한 위치에 있어야 할 때
 * 3) 반응형 비율 기반 배치가 필요할 때
 */

#endregion

#region 4. TextBlock

/*
 * -텍스트를 화면에 출력해주는 WPF 가장 기본적인 텍스트 표시용 컨트롤
 * -화면 읽기 전용 텍스트를 표시할 때 사용
 * -사용자가 직접 입력x
 * ->입력은 TextBox에서 가능
 */

#endregion

#region 5. GroupBox

/*
 * -여러개의 UI 요소를 하나의 그룹으로 묶어주고 그 그룹에 제목(Label)을 붙일 수 있는 컨테이너
 * ㄴ관련 힝목들을 시각적으로 묶어 표현할 때 사용
 */

#endregion

#region 6. RadioButton

/*
 * 속성
 * GroupName
 * ㄴ여러개의 RadioButton이 서로 다른 그룹으로 동작하도록 구분짓는 속성
 * ㄴ같은 GroupName을 가진 버튼끼리는 서로 하나만 선택 가능
 * ㄴ다른 GroupName을 부여하면 동시 선택 가능
 * 
 * Checked
 * -라디오 버튼이 선택 될 때 연결되는 이벤트 핸들러
 * 
 * IsChecked
 * -현재 체크 상태를 코드로 확인할 때 사용
 */

#endregion

#region 7. Slider

/*
 * -사용자가 드래그하거나 클릭해 숫자 값을 조절할 수 있게 해주는 입력 컨트롤
 * ex) 음량, 밝기, 비율 등을 조절할 때 사용
 * 
 * 속성
 * -Minimum: 최소 값(기본 0)
 * -Maximum: 최대 값(기본 10)
 * -Value: 현재 값(기본 0)
 * -Orientation: 방향 설정
 * -TickFrequency: 눈금 간격
 * -IsSnapToTickEnabled: 눈금에 맞춰지게 할지 여부
 * -Ticks: 눈금 위치를 직접 설정(배열처럼)
 * ㄴ특별한 위치에만 눈금이 필요할 때
 */

#endregion