using Microsoft.Win32;
using System.IO;
using WpfAppLabb4.Model;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppLabb4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person person = new Person() { UserName = "NikTe" , FirstName = "Nikola", LastName = "Tesla", EMail = "h76nikte@Tesla.mars" };
            bindingDataFN.DataContext = person;
            bindingDataLN.DataContext = person;
            bindingDataEM.DataContext = person;

        }
        private async void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = OpenFileDialogSimple();
            await SimpleReadAsync();
        }
        public async Task SimpleReadAsync()
        {
            string filePath = SelectedPerson.Text;
            var text = await File.ReadAllLinesAsync(filePath);
            
            foreach (var line in text)
            {
                if (line.Length > 3)
                {
                    var linse = line.Split(' ');

                    Person newPerson = new Person();
                    newPerson.UserName = linse[0];
                    string listFN = newPerson.FirstName = linse[1];
                    string listLN = newPerson.LastName = linse[2];
                    string listEM = newPerson.EMail = linse[3];

                    OpenFileListBox.Items.Add(string.Format("{0} {1} {2}", listFN.Trim(), listLN.Trim(), listEM.Trim()));
                }
            }
        }
        public string OpenFileDialogSimple()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (.txt)|.txt|All files (.)|.";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                SelectedPerson.Text = openFileDialog.FileName;
                return openFileDialog.FileName;
            }
            return "";
        }
        private void AddButton(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddFirstName.Text) &&
                !string.IsNullOrWhiteSpace(AddLastName.Text) &&
                !string.IsNullOrWhiteSpace(AddEmail.Text))
            {
                Person person = new Person() { FirstName = AddFirstName.Text, LastName = AddLastName.Text, EMail = AddEmail.Text };

                bindingDataFN.DataContext = person;
                bindingDataLN.DataContext = person;
                bindingDataEM.DataContext = person;

                OpenFileListBox.Items.Add(string.Format("{0} {1} {2} ", AddFirstName.Text, AddLastName.Text, AddEmail.Text));
                AddFirstName.Clear();
                AddLastName.Clear();
                AddEmail.Clear();
                MessageBox.Show("Person is added to the list!");
            }
            else
            {
                MessageBox.Show("Empty textbox!");
            }
        }
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            OpenFileListBox.Items.Clear();
        }
        private void Clear_Add_DataButton_Click(object sender, RoutedEventArgs e)
        {
            AddFirstName.Clear();
            AddLastName.Clear();
            AddEmail.Clear();
        }
        private void Clear_Selected_DataButton_Click(object sender, RoutedEventArgs e)
        {
            bindingDataFN.Content = "";
            bindingDataLN.Content = "";
            bindingDataEM.Content = "";
            SelectedPerson.Clear();
        }
        private void rightClick(object sender, MouseButtonEventArgs e)
        {
            if (sender.Equals(OpenFileListBox) && OpenFileListBox.Items.Count > 0 )
            {
                OpenFileListBox.Items.Remove(OpenFileListBox.SelectedItems[0]);
            }
        }
        private void leftClick(object sender, MouseButtonEventArgs e)
        {
            if (sender.Equals(OpenFileListBox) && OpenFileListBox.Items.Count > 0)
            {
                var curItem = OpenFileListBox.SelectedItem.ToString();
                if (curItem.Length > 2)
                {
                    var stt = curItem.Split(' ');
                    Person person = new Person() { FirstName = stt[0], LastName = stt[1], EMail = stt[2] };
                    //Binding new person with labels
                    bindingDataFN.DataContext = person;
                    bindingDataLN.DataContext = person;
                    bindingDataEM.DataContext = person;

                }
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}