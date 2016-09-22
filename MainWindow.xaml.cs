using System;
using System.Collections.Generic;
using System.Linq;
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
using WPF.MDI;
using com.crefima.clinique509.ui;


namespace com.crefima.clinique509
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BT_save_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Ajouter Patient",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenSavePatient()
            });

            this.BT_save.IsEnabled = false;
        }

        private void BT_ModifierPatient_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Modifier Patient",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenModifierPatient()
            });
        }


        private void BT_SearchPatient_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Rechercher Patient",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenSearchPatient()
            });
        }

        private void BT_ListPatient_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Liste Patient",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenListePatient()
            });
        }

        private void BT_SaveVisite_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Enregistrer Visite",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenSaveVisite()
            });
        }

        private void BT_ModifierVisite_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Modifier Visite",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenModifierVisite()
            });
        }

        private void BT_RechercherVisite_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Rechecher Visite",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenRechercherVisite()
            });
        }

        private void BT_ListerVisite_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Liste Visite",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenListeVisite()
            });
        }

        private void BT_MakeLabOrder_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Laboratoire Ordonnance",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenLabOrder()
            });
        }

        private void BT_SaveDrugOrder_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {

                Title = "Medilcale Ordonnance",
                MinWidth = 780,
                MinHeight = 590,
                Content = new FenDrugOrder()
            });
        }

    }
}
