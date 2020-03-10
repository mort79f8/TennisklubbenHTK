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
using TennisklubbenHTK.BIZ;

namespace TennisklubbenHTK.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biz biz;
        public MainWindow()
        {
            InitializeComponent();
            biz = new Biz();
            MemberListDataGrid.ItemsSource = biz.GetListOfMembers();
        }

        private void CreateNewMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateNewMember createNewMember = new CreateNewMember();
            createNewMember.Owner = this;
            createNewMember.Show();
        }
    }
}
