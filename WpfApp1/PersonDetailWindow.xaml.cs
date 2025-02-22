﻿using PrvniKonzolovaApp.Model;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetailWindow.xaml
    /// </summary>
    public partial class PersonDetailWindow : Window
    {
        public PersonDetailWindow(Person person)
        {
            InitializeComponent();

            txtFirstName.Text = person.FirstName; 
            txtLastName.Text = person.LastName;
            txtDateOfBirth.Text = person.DateOfBirth.ToString();
            txtAddress.Text = person.Address.ToString();
            
        }
    }
}
