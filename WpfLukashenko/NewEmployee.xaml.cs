﻿using System;
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

namespace WpfLukashenko
{
    /// <summary>
    /// Логика взаимодействия для NewEmployee.xaml
    /// </summary>
    public partial class NewEmployee : Window
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            tbName.Text = "";
            tbPatr.Text = "";
            tbPost.Text = "";
            tbSalary.Text = "";
            tbSurname.Text = "";

            lbDepartment.SelectedIndex = -1;

            dptbBirthDate.Text = "";
        }
    }
}
