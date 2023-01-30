using GrandOS.Programs.Base;
using GrandOS.UI.Elements.Buttons;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrandOS.UI
{
    public class ProgramGrid
    {
        int rows, cols, horizontalMargin, verticalMargin;
        List<Program> programs;
        public Grid grid;
        internal ProgramGrid(Grid grid, int cols, int rows, int horizontalMargin, int verticalMargin, List<Program> programs)
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

        public void AddProgam(Program program, int cellX, int cellY)
        {
            int index = cellY * rows + cellX;
            //programs.Insert(index, program);
            new ProgramButton(program, GetThickness(cellX, cellY)).ReplaceInGird(grid, cellX, cellY);
        }

        private void RenderPrograms()
        {
            if (programs.Count > rows * cols)
                throw new ArgumentOutOfRangeException($"Too many programs, this gird can only take {cols * rows} programs, and you are trying to allocate {programs.Count}");

            // Fill gird with elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Thickness margin = GetThickness(j, i);

                    // If cell has a program assigned fullfill it
                    if (i * rows + j < programs.Count)
                    {
                        Program program = programs[i * rows + j];
                        
                        new ProgramButton(program, margin).AddToGrid(grid, j, i);
                    }
                    else
                    {
                        // If it's an empty cell then create an empty button
                        new EmptyCellButton(this, j, i, margin).AddToGrid(grid, j, i);
                    }
                }
            }
        }

        private Thickness GetThickness(int x, int y)
        {
            int verticalMarginTemp = verticalMargin;
            int horizontalMarginTemp = horizontalMargin;
            if (y == 0) verticalMarginTemp = 0;
            if (x == 0) horizontalMarginTemp = 0;
            return new Thickness(horizontalMarginTemp, verticalMarginTemp, 0, 0);
        }
    }
}
