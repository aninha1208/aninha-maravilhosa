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
        ISorteio s;
        private void SortearIniciar(object sender, RoutedEventArgs e)
        {
            txtSorteados.Clear();
            Bingo b = new Bingo(int.Parse(txtNumeroDeBolas.Text));
            s = b as ISorteio;

        }
    }
}
