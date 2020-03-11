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
    /// Interaction logic for CourtGui.xaml
    /// </summary>
    public partial class CourtGui : Window, INotifyPropertyChanged
    {
        private Court selectedCourt;
        public List<string> UnderlayList { get; set; }
        public List<Court> ListOfCourts { get; set; }
        public Court SelectedCourt 
        {
            get => selectedCourt;
            set
            {
                selectedCourt = value;
                OnPropertyChanged(nameof(SelectedCourt));
            } 
        }


        Biz biz;

        public CourtGui()
        {
            InitializeComponent();
            DataContext = this;
            biz = new Biz();
            ListOfCourts = biz.GetListOfCourts();
            
            UnderlayList = new List<string>();
            UnderlayList.Add("Grus");
            UnderlayList.Add("Hardcourt");
            UnderlayList.Add("Plexicushon");
            UnderlayList.Add("Græs");
        }

        private void ListOfCourtsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCourt = ListOfCourtsDataGrid.SelectedItem as Court;
        }
        private void CreateNewCourtBtn_Click(object sender, RoutedEventArgs e)
        {
            biz.CreateNewCourt(CourtNameTxtBox.Text, UnderlayComboBox.SelectedItem.ToString());
            ListOfCourts = biz.GetListOfCourts();
            ListOfCourtsDataGrid.ItemsSource = ListOfCourts;
        }

        #region OnPropertyChanged Handling
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            biz.UpdateCourt(SelectedCourt);
            MessageBox.Show("Banen er blevet updateret");
        }

        private void DeleteCourtBtn_Click(object sender, RoutedEventArgs e)
        {
            biz.DeleteCourt(SelectedCourt.CourtId);
            ListOfCourts = biz.GetListOfCourts();
            ListOfCourtsDataGrid.ItemsSource = ListOfCourts;
        }
    }
}
