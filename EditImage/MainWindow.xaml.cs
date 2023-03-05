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

namespace EditImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Image> Images { get; set; } = new List<Image>
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
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
