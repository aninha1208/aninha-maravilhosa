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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex03
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Retangulo x = new Retangulo();
            x.SetAltura(double.Parse(txtAltura.Text));
            x.SetBase(double.Parse(txtBase.Text));
            txtArea.Text = x.CalcArea().ToString("0.00");
            txtDiagonal.Text = x.CalcDiagonal().ToString("0.00");
        }
    }
}
