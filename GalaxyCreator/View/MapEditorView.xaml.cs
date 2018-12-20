﻿using GalaxyCreator.Model;
using GalaxyCreator.ViewModel;
using System.Windows.Controls;

namespace GalaxyCreator.View
{
    /// <summary>
    /// Interaction logic for MapEditorView.xaml
    /// </summary>
    public partial class MapEditorView : UserControl
    {
        public MapEditorView()
        {

            InitializeComponent();

            /* TODO: NEED TO CREATE THIS WHEN DATA IS LOADED OR A NEW MAPO IS CREATED */
            MainData.SetCanvas(sectorCanvas);//, 20, 20, 75);

            this.Loaded += MapEditorView_Loaded;
           
        }

        private void MapEditorView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ((MapEditorViewModel)DataContext).DrawGalaxyMap();
        }



        /* UNABLE TO MVVM THIS FOR REASONS */
        private void sectorCanvas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((MapEditorViewModel)DataContext).CanvasClicked(e);
        }
    }
}
