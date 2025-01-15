## MAUI Galeria

```csharp

public partial class MainPage : ContentPage
    {
        int middleIndex = 1;
        int leftIndex = 0;
        int rightIndex = 2;
        List<string> imagesUri = new List<string> { "obraz1.png", "obraz2.png", "obraz3.png", "obraz4.png" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void left_Button_Clicked(object sender, EventArgs e)
        {
            middleIndex--;
            if (middleIndex < 0)
                middleIndex = imagesUri.Count - 1;
            leftIndex--;
            if (leftIndex < 0)
                leftIndex = imagesUri.Count - 1;
            rightIndex--;
            if (rightIndex < 0)
                rightIndex = imagesUri.Count - 1;

            leftImage.Source = imagesUri[leftIndex];
            middleImage.Source = imagesUri[middleIndex];
            RigthImage.Source = imagesUri[rightIndex];
        }

        private void rigth_Button_Clicked(object sender, EventArgs e)
        {
            middleIndex++;
            if (middleIndex > imagesUri.Count - 1)
                middleIndex = 0;
            leftIndex++;
            if (leftIndex > imagesUri.Count - 1)
                leftIndex = 0;
            rightIndex++;
            if (rightIndex > imagesUri.Count - 1)
                rightIndex = 0;

            leftImage.Source = imagesUri[leftIndex];
            middleImage.Source = imagesUri[middleIndex];
            RigthImage.Source = imagesUri[rightIndex];
        }

        private void BackgroundSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            var _sender = (Switch)sender;
            if (_sender.IsToggled)
                appGrid.BackgroundColor = Colors.Aqua;
            else
                appGrid.BackgroundColor = Colors.ForestGreen;
        }
    }

    //Code By YOURIxYOURI

```

## Grid

```xml

<Grid BackgroundColor="ForestGreen" x:Name="appGrid" ColumnSpacing="20" RowSpacing="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="100*"></RowDefinition>
            <RowDefinition Height="100*"></RowDefinition>
            <RowDefinition Height="100*"></RowDefinition>
            <RowDefinition Height="100*"></RowDefinition>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"></ColumnDefinition>
            <ColumnDefinition Width="*"></ColumnDefinition>
            <ColumnDefinition Width="*"></ColumnDefinition>
        </Grid.ColumnDefinitions>


        <StackLayout Grid.ColumnSpan="2" Grid.Row="0">
            <Label Text="Galeria" FontSize="Header"></Label>
        </StackLayout>
        <HorizontalStackLayout Grid.Row="1" Grid.ColumnSpan="3" >
                <Image x:Name="leftImage" Grid.Column="0" Source="obraz1.png" HeightRequest="300"></Image>
                <Image x:Name="middleImage" Grid.Column="1" Source="obraz2.png" HeightRequest="300"></Image>
                <Image x:Name="RigthImage" Grid.Column="2" Source="obraz3.png" HeightRequest="300"></Image>
            </HorizontalStackLayout>
        <HorizontalStackLayout Grid.Row="2" Grid.ColumnSpan="2">
            <Button Text="&lt;&lt;--" Clicked="left_Button_Clicked" Grid.ColumnSpan="2"></Button>
            <Button Text="-->>" Clicked="rigth_Button_Clicked" Grid.ColumnSpan="2"></Button>
        </HorizontalStackLayout >
        <StackLayout Grid.ColumnSpan="2" Grid.Row="3">
            <HorizontalStackLayout>
                <Label Text="Przełącz żeby zmienic tło"></Label>
                <Switch x:Name="BackgroundSwitch" OnColor="Aquamarine" ThumbColor="Aqua" Toggled="BackgroundSwitch_Toggled"></Switch>
            </HorizontalStackLayout>
        </StackLayout>
    </Grid>


//Code By YOURIxYOURI
```