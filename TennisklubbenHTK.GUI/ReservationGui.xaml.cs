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
using TennisklubbenHTK.Entities;

namespace TennisklubbenHTK.GUI
{
    /// <summary>
    /// Interaction logic for ReservationGui.xaml
    /// </summary>
    public partial class ReservationGui : Window
    {
        public List<Reservation> ListOfReservations { get; set; }
        Biz biz;

        public ReservationGui()
        {
            InitializeComponent();
            DataContext = this;
            biz = new Biz();
            ListOfReservations = biz.GetListOfReservations();
        }
    }
}
