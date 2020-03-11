using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TennisklubbenHTK.Entities;

namespace TennisklubbenHTK.GUI
{
    /// <summary>
    /// Interaction logic for MemberGui.xaml
    /// </summary>
    public partial class MemberGui : Window, INotifyPropertyChanged
    {
        private Member selectedMember;
        public List<Member> ListOfMembers { get; set; }
        public Member SelectedMember 
        {
            get => selectedMember;
            set
            {
                selectedMember = value;
                OnPropertyChanged(nameof(SelectedMember));
            }
        }

        Biz biz;
        public MemberGui()
        {
            InitializeComponent();
            DataContext = this;
            biz = new Biz();
            ListOfMembers = biz.GetListOfMembers();
        }

        private void ListOfMembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedMember = ListOfMembersDataGrid.SelectedItem as Member;            
        }



        private void UpdateMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            biz.UpdateMember(SelectedMember);
            MessageBox.Show("Medlem er blevet updateret");

        }

        private void CreateNewMember_Click(object sender, RoutedEventArgs e)
        {
            biz.CreateNewMember(firstNametxtBox.Text, lastNametxtBox.Text, addresstxtBox.Text, mobilNumbertxtBox.Text, emailtxtBox.Text, birthdayDatePicker.SelectedDate.Value);
            MessageBox.Show("Medlem er blevet tilmeldt til klubben");
            ListOfMembers = biz.GetListOfMembers();
            ListOfMembersDataGrid.ItemsSource = ListOfMembers;
        }
        private void ActiveFilterCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ActiveFilterCheckBox.IsChecked == true)
            {
                ListOfMembersDataGrid.ItemsSource = ListOfMembers.Where(m => m.Active == true);
            }
            else
            {
                ListOfMembersDataGrid.ItemsSource = ListOfMembers;
            }
        }

        #region OnPropertyChanged Handling
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

    }
}
