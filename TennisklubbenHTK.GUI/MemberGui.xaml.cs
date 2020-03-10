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


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
