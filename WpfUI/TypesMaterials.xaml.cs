﻿using BLL;
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

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for TypesMaterials.xaml
    /// </summary>
    public partial class TypesMaterials : Window
    {
        DBWorker dbWorker;

        public TypesMaterials()
        {
            InitializeComponent();
        }

        public TypesMaterials(DBWorker dbWorker)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

    }
}