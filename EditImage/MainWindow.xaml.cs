using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace EditImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Image> Images { get; set; } = new ObservableCollection<Image>
        {
            new Image
            {
                Id=1,
                ImageName="Mona Lisa",
                ImagePath="images/monalisa.jpg"
            },
            new Image
            {
                Id=2,
                ImageName="The Starry Night",
                ImagePath="images/thestarrynight.jpg"
            },
            new Image
            {
                Id=3,
                ImageName="The Harvesters",
                ImagePath="images/theharvesters.jpg"
            },
            new Image
            {
                Id=4,
                ImageName="Las Meninas",
                ImagePath="images/lasmeninas.jpg"
            },

            new Image
            {
                Id=5,
                ImageName="Girl with Pearl Earring",
                ImagePath="images/girlwithapearlearring.jpg"
            },
            new Image
            {
                Id=6,
                ImageName="The Last Supper",
                ImagePath="images/thelastsupper.jpg"
            },

            new Image
            {
                Id=7,
                ImageName="A Sunday Afternoon on the Island of La Grande Jatte",
                ImagePath="images/asundayafternoon.jpg"
            },
            new Image
            {
                Id=8,
                ImageName="The Scream",
                ImagePath="images/thescream.jpg"
            },
        };
        private int width;

        public int ImageWidth
        {
            get { return width; }
            set { width = value; OnPropertyChanged(); }
        }
        private int height;

        public int ImageHeight
        {
            get { return height; }
            set { height = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
        public MainWindow()
        {
            InitializeComponent();
            ImageHeight = 200;
            ImageWidth = 300;
            this.DataContext = this;
        }
        public bool TilesClicked { get; set; } = false;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (!TilesClicked)
            {
                ImageWidth = 100;
                ImageHeight = 200;
            }
            TilesClicked = !TilesClicked;
        }

        private void imageLbl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow();
            var item = photoslistBox.SelectedItem as Image;
            imageWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            imageWindow.Path = item.ImagePath;
            imageWindow.ShowDialog();
        }

        public bool SmallIconsClicked { get; set; } = false;
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (!SmallIconsClicked)
            {
                ImageWidth = 50;
                ImageHeight = 100;
            }
            SmallIconsClicked = !SmallIconsClicked;
        }

        public bool DetailsClicked { get; set; } = false;
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (!DetailsClicked)
            {
                ImageWidth = 30;
                ImageHeight = 50;
            }
            DetailsClicked = !DetailsClicked;
        }
    }
}
