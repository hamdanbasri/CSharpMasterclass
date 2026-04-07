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

namespace ListBoxIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Hamdan", Age = 34},
            new Person{Name = "Hada", Age = 31},
            new Person{Name = "Idrees", Age = 6},
            new Person{Name = "Ireena", Age = 2}
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems) 
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}