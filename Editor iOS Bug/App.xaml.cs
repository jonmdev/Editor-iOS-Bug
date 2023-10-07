namespace Editor_iOS_Bug {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new ContentPage();

            VerticalStackLayout vert = new();
            (MainPage as ContentPage).Content = vert;
            
            Border border = new();
            border.StrokeThickness = 4;
            border.BackgroundColor = Colors.DarkBlue;
            border.Stroke = Colors.Red;
            border.Padding = 10;
            vert.Children.Add(border);

            Editor editor = new();
            editor.BackgroundColor = Colors.White;
            editor.AutoSize = EditorAutoSizeOption.TextChanges;
            editor.MaximumHeightRequest = 200;
            border.Content = editor;

            Label testLabel = new Label();
            testLabel.Text = "Editor iOS Bug Demonstration:\n- Editor does not autoscroll downward as you fill the Editor with text (new lines past max height go down off screen)\n- Editor does not scroll with click and drag once past maxHeight in size.\n- There is a frame lag after resizing Editor and before resizing the parent so the Editor goes 'out of bounds' of its parent momentarily each time it grows vertically.";
            vert.Children.Add(testLabel);

        }
    }

}