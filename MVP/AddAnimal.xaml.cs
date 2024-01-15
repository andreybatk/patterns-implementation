using System.Windows;

namespace MVP
{
    /// <summary>
    /// Interaction logic for AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Window
    {

        public AddAnimal()
        {
            InitializeComponent();

            btnOK.Click += (s, e) => ButtonOk();
        }

        public int Age
        {
            get => int.Parse(txtAge.Text);
            set => txtAge.Text = value.ToString();
        }
        public string Type
        {
            get => txtType.Text;
            set => txtType.Text = value;
        }
        public string KindOfAnimal
        {
            get => txtKindOfAnimal.Text;
            set => txtKindOfAnimal.Text = value;
        }

        private void ButtonOk()
        {
            DialogResult = true;
        }
    }
}
