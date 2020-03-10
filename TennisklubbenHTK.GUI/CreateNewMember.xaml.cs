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
using System.Windows.Shapes;
using TennisklubbenHTK.BIZ;

namespace TennisklubbenHTK.GUI
{
    /// <summary>
    /// Interaction logic for CreateNewMember.xaml
    /// </summary>
    public partial class CreateNewMember : Window
    {
        Biz biz;
        public CreateNewMember()
        {
            InitializeComponent();
            biz = new Biz();
        }

        private void CancelCreateNewMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CreateNewMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
