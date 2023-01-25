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
        int rows, cols, horizontalMargin, verticalMargin;
        List<Program> programs;
        Grid grid;
        public ProgramGrid(Grid grid, int cols, int rows, int horizontalMargin, int verticalMargin, List<Program> programs)
        {
            this.grid = grid;
            this.programs = programs;
            this.rows = rows;
            this.cols = cols;
            this.horizontalMargin = horizontalMargin;
            this.verticalMargin = verticalMargin;

            // Set gird size
            for (int i = 0; i < rows; i++) grid.RowDefinitions.Add(new RowDefinition());
            for (int j = 0; j < cols; j++) grid.ColumnDefinitions.Add(new ColumnDefinition());


            RenderPrograms();
        }

        public void AddProgam()
        {

        }

        private void RenderPrograms()
        {
            if (programs.Count > rows * cols) 
                throw new ArgumentOutOfRangeException($"Too many programs, this gird can only take {cols * rows} programs, and you are trying to allocate {programs.Count}");
            
            // Fill gird with elements
            for (int i = 0; i < rows; i++)
            {
                // Check if we should apply vertical margin, if we're on the first cell, don't
                int trueVerticalMargin = verticalMargin;
                if (i == 0) trueVerticalMargin = 0;
                for (int j = 0; j < cols; j++)
                {
                    // Check if we should apply horizontal margin, if we're on the first cell, don't
                    int trueHorizontalMargin = horizontalMargin;
                    if (j == 0) trueHorizontalMargin = 0;

                    Button button;

                    // If cell has a program assigned fullfill it
                    if ((i * rows) + j < programs.Count)
                    {
                        Program program = programs[(i * rows) + j];

                        button = new Button()
                        {
                            Margin = new Thickness(trueHorizontalMargin, trueVerticalMargin, 0, 0),
                            Background = program.color,
                            Foreground = Brushes.White,
                            Content = program.name,
                            FontFamily = (FontFamily)Application.Current.Resources["settingFontFamilyContent"],
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                        };

                       
                    } else
                    {
                        // If it's an empty cell then create an empty button
                        button = new Button()
                        {
                            Margin = new Thickness(trueHorizontalMargin, trueVerticalMargin, 0, 0),
                            Background = Brushes.DimGray,
                            BorderBrush = Brushes.DarkGray,
                            IsHitTestVisible = false
                           
                        };
                    }


                    // Add element to gird
                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);
                    grid.Children.Add(button);
                }
            }
        }
    }
}
