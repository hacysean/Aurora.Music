﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace Aurora.Music.Controls
{
    public sealed class ImageGrid : Control
    {
        private Grid main;

        public ImageGrid()
        {
            this.DefaultStyleKey = typeof(ImageGrid);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            main = GetTemplateChild("Main") as Grid;
        }

        public object ImageSources
        {
            get { return (object)GetValue(ImageSourcesProperty); }
            set { SetValue(ImageSourcesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSources.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourcesProperty =
            DependencyProperty.Register("ImageSources", typeof(object), typeof(ImageGrid), new PropertyMetadata(null, ImageSourcesChanged));

        private static void ImageSourcesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ImageGrid imgGrid && e.NewValue is IList<ImageSource> source)
            {
                if (imgGrid.main == null)
                {
                    return;
                }
                var main = imgGrid.main;
                main.Children.Clear();
                main.ColumnDefinitions.Clear();
                main.RowDefinitions.Clear();
                var count = source.Count;
                if (count > 9) count = 9;

                for (int i = 0; i < count; i++)
                {
                    main.Children.Add(new Image
                    {
                        Source = source[i],
                        Stretch = Stretch.UniformToFill,
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Stretch
                    });
                }
                switch (count)
                {
                    case 0:
                        return;
                    case 1:
                        main.Children.Add(new Image
                        {
                            Source = source[0],
                            Stretch = Stretch.UniformToFill,
                            HorizontalAlignment = HorizontalAlignment.Stretch,
                            VerticalAlignment = VerticalAlignment.Stretch
                        });
                        break;
                    case 2:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        break;
                    case 3:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.ColumnProperty, 2);
                        break;
                    case 4:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.ColumnProperty, 0);
                        main.Children[3].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.RowProperty, 1);
                        main.Children[3].SetValue(Grid.RowProperty, 1);
                        break;
                    case 5:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 3);
                        main.Children[2].SetValue(Grid.ColumnProperty, 0);
                        main.Children[3].SetValue(Grid.ColumnProperty, 2);
                        main.Children[4].SetValue(Grid.ColumnProperty, 4);
                        main.Children[2].SetValue(Grid.RowProperty, 1);
                        main.Children[3].SetValue(Grid.RowProperty, 1);
                        main.Children[4].SetValue(Grid.RowProperty, 1);
                        main.Children[0].SetValue(Grid.ColumnSpanProperty, 3);
                        main.Children[1].SetValue(Grid.ColumnSpanProperty, 3);
                        main.Children[2].SetValue(Grid.ColumnSpanProperty, 2);
                        main.Children[3].SetValue(Grid.ColumnSpanProperty, 2);
                        main.Children[4].SetValue(Grid.ColumnSpanProperty, 2);
                        break;
                    case 6:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.ColumnProperty, 2);
                        main.Children[3].SetValue(Grid.ColumnProperty, 0);
                        main.Children[4].SetValue(Grid.ColumnProperty, 1);
                        main.Children[5].SetValue(Grid.ColumnProperty, 2);
                        main.Children[3].SetValue(Grid.RowProperty, 1);
                        main.Children[4].SetValue(Grid.RowProperty, 1);
                        main.Children[5].SetValue(Grid.RowProperty, 1);
                        break;
                    case 7:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 4);
                        main.Children[2].SetValue(Grid.ColumnProperty, 8);
                        main.Children[3].SetValue(Grid.ColumnProperty, 0);
                        main.Children[4].SetValue(Grid.ColumnProperty, 3);
                        main.Children[5].SetValue(Grid.ColumnProperty, 6);
                        main.Children[6].SetValue(Grid.ColumnProperty, 9);
                        main.Children[3].SetValue(Grid.RowProperty, 1);
                        main.Children[4].SetValue(Grid.RowProperty, 1);
                        main.Children[5].SetValue(Grid.RowProperty, 1);
                        main.Children[6].SetValue(Grid.RowProperty, 1);
                        main.Children[0].SetValue(Grid.ColumnSpanProperty, 4);
                        main.Children[1].SetValue(Grid.ColumnSpanProperty, 4);
                        main.Children[2].SetValue(Grid.ColumnSpanProperty, 4);
                        main.Children[3].SetValue(Grid.ColumnSpanProperty, 3);
                        main.Children[4].SetValue(Grid.ColumnSpanProperty, 3);
                        main.Children[5].SetValue(Grid.ColumnSpanProperty, 3);
                        main.Children[6].SetValue(Grid.ColumnSpanProperty, 3);
                        break;
                    case 8:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.ColumnProperty, 2);
                        main.Children[3].SetValue(Grid.ColumnProperty, 3);
                        main.Children[4].SetValue(Grid.ColumnProperty, 0);
                        main.Children[5].SetValue(Grid.ColumnProperty, 1);
                        main.Children[6].SetValue(Grid.ColumnProperty, 2);
                        main.Children[7].SetValue(Grid.ColumnProperty, 3);
                        main.Children[4].SetValue(Grid.RowProperty, 1);
                        main.Children[5].SetValue(Grid.RowProperty, 1);
                        main.Children[6].SetValue(Grid.RowProperty, 1);
                        main.Children[7].SetValue(Grid.RowProperty, 1);
                        break;
                    case 9:
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        main.Children[0].SetValue(Grid.ColumnProperty, 0);
                        main.Children[1].SetValue(Grid.ColumnProperty, 1);
                        main.Children[2].SetValue(Grid.ColumnProperty, 2);
                        main.Children[3].SetValue(Grid.ColumnProperty, 0);
                        main.Children[4].SetValue(Grid.ColumnProperty, 1);
                        main.Children[5].SetValue(Grid.ColumnProperty, 2);
                        main.Children[6].SetValue(Grid.ColumnProperty, 0);
                        main.Children[7].SetValue(Grid.ColumnProperty, 1);
                        main.Children[8].SetValue(Grid.ColumnProperty, 2);
                        main.Children[0].SetValue(Grid.RowProperty, 0);
                        main.Children[1].SetValue(Grid.RowProperty, 0);
                        main.Children[2].SetValue(Grid.RowProperty, 0);
                        main.Children[3].SetValue(Grid.RowProperty, 1);
                        main.Children[4].SetValue(Grid.RowProperty, 1);
                        main.Children[5].SetValue(Grid.RowProperty, 1);
                        main.Children[6].SetValue(Grid.RowProperty, 2);
                        main.Children[7].SetValue(Grid.RowProperty, 2);
                        main.Children[8].SetValue(Grid.RowProperty, 2);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public enum ImageGridOrientation { Horizontal, Vertical }
}
