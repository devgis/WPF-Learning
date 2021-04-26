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

namespace RoutedEventTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 事件处理程序
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //sender是指由谁激发了这个事件处理程序，它可以获取到触发对象
            //通过(sender as FrameworkElement).Name转换，将触发控件的名称拿出来，
            string message = "触发者：" + (sender as FrameworkElement).Name.ToString();
            this.Print_List.Items.Add(message);

            //e包含了与事件相关的一些参数，e.Handled如果设置为True，则表示冒泡不再继续
            e.Handled = true;
        }
    }
}
