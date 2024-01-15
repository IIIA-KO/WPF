using System.Windows;
using System.Windows.Controls;

namespace HW1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid mainGrid = CreateGrid(1, 2);
            Grid grid1 = CreateGrid(8, 3, 0, 0);
            Grid grid2 = CreateGrid(8, 3, 0, 1);

            grid1.Children.Add(CreateButton("1", 0, 1, 0, 3));
            grid1.Children.Add(CreateButton("4", 1, 1, 0, 2));
            grid1.Children.Add(CreateButton("5", 1, 1, 2, 1));
            grid1.Children.Add(CreateButton("8", 2, 1, 0, 3));
            grid1.Children.Add(CreateButton("11", 3, 1, 0, 1));
            grid1.Children.Add(CreateButton("12", 3, 1, 1, 1));
            grid1.Children.Add(CreateButton("13", 3, 1, 2, 1));
            grid1.Children.Add(CreateButton("15", 4, 2, 0, 3));
            grid1.Children.Add(CreateButton("16", 6, 2, 0, 1));
            grid1.Children.Add(CreateButton("17", 6, 1, 1, 1));
            grid1.Children.Add(CreateButton("18", 6, 2, 2, 1));
            grid1.Children.Add(CreateButton("19", 7, 1, 1, 1));

            grid2.Children.Add(CreateButton("2", 0, 1, 0, 1));
            grid2.Children.Add(CreateButton("3", 0, 1, 1, 2));
            grid2.Children.Add(CreateButton("6", 1, 1, 0, 2));
            grid2.Children.Add(CreateButton("7", 1, 2, 2, 1));
            grid2.Children.Add(CreateButton("9", 2, 1, 0, 1));
            grid2.Children.Add(CreateButton("10", 2, 1, 1, 1));
            grid2.Children.Add(CreateButton("14", 3, 4, 0, 3));
            grid2.Children.Add(CreateButton("20", 7, 1, 0, 1));
            grid2.Children.Add(CreateButton("21", 7, 1, 1, 1));
            grid2.Children.Add(CreateButton("22", 7, 1, 2, 1));

            mainGrid.Children.Add(grid1);
            mainGrid.Children.Add(grid2);
            this.Content = mainGrid;
        }

        private Button CreateButton(string content, int row, int rowSpan, int column, int columnSpan)
        {
            Button button = new Button
            {
                Content = content,
                FontSize = 20
            };

            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
            Grid.SetRowSpan(button, rowSpan);
            Grid.SetColumnSpan(button, columnSpan);

            return button;
        }

        private Grid CreateGrid(int rowCount, int columnCount, int gridRow = 0, int gridColumn = 0)
        {
            Grid grid = new Grid();

            for (int i = 0; i < rowCount; i++)
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Star) });

            for (int i = 0; i < columnCount; i++)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });


            Grid.SetRow(grid, gridRow);
            Grid.SetColumn(grid, gridColumn);

            return grid;
        }
    }
}
