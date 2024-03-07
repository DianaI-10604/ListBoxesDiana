using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BundingPageDiana
{
    public partial class MainWindow : Window
    {
        NamesOutput n = new NamesOutput();
        Person person = new Person();
        //List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            person.info = firstname.Text + " " + lastname.Text;
            if (!EnteredNames.Items.Contains(person.info) && !string.IsNullOrWhiteSpace(firstname.Text) && !string.IsNullOrWhiteSpace(lastname.Text))
            {
                person.info = firstname.Text + " " + lastname.Text;

                EnteredNames.Items.Add(person.info);
                EnteredNames.UpdateLayout();

                firstname.Clear();
                lastname.Clear();
            }
            else
            {
                firstname.Clear();
                lastname.Clear();
            }
        }

        private void ClearTextBoxes(object sender, RoutedEventArgs e)
        {
            firstname.Clear();
            lastname.Clear();
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            int j = 0;
            if (j < 1)
            {
                n.Show();
                j++;
            }

            int i = 0;
            i = EnteredNames.SelectedIndex;

            if (!n.SelectedNames.Items.Contains(EnteredNames.SelectedIndex))
            {      
                n.SelectedNames.Items.Add(EnteredNames.SelectedItem);
            }    
        }
    }
}