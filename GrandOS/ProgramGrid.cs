using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS
{
    class ProgramGrid
    {
        int horizontalMargin, verticalMargin;
        List<Program> programs;

        public ProgramGrid(Grid grid, int size, int horizontalMargin, int verticalMargin)
        {
            programs = new List<Program>();


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    var rect = new Rectangle()
                    {
                        //Margin = new Thickness(i * (size + horizontalMargin), i * (size + verticalMargin), 0, 0),
                        //HorizontalAlignment = HorizontalAlignment.Left,
                        //VerticalAlignment = VerticalAlignment.Top,
                        //Width = size,
                        //Height = size,
                        Fill = Brushes.AliceBlue
                    };
                    Grid.SetColumn(rect, j);
                    Grid.SetRow(rect, i);
                    grid.Children.Add(rect);
                }
                grid.RowDefinitions.Add(new RowDefinition());
            }

            /*for (int i = 0; i < 10; i++)
            {
                var rect = new Rectangle()
                {
                    Margin = new Thickness(i * (size + horizontalMargin), i * (size + verticalMargin), 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = size,
                    Height = size,
                    Fill = Brushes.AliceBlue
                };

                gird.Children.Add(rect);
            }*/
        }
    }
}
