# How-to-customize-the-axis-grid-line-for-.NET-MAUI-Chart-SfCartesianChart
This article in the Syncfusion Knowledge Base explains how to customize the axis grid line in .NET MAUI platform.
```
##[Xaml]
    <chart:SfCartesianChart >

        <chart:SfCartesianChart.Resources>
            <DoubleCollection x:Key="dashArray">
                <x:Double>3</x:Double>
                <x:Double>3</x:Double>
            </DoubleCollection>
        </chart:SfCartesianChart.Resources>

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis PlotOffsetEnd="25">
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Months" FontSize="25"/>
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis MinorTicksPerInterval="2" Interval="5" PlotOffsetEnd="25" ShowMajorGridLines="True" ShowMinorGridLines="True">
                <chart:NumericalAxis.MinorGridLineStyle>
                    <chart:ChartLineStyle Stroke="Green"
                                          StrokeWidth="1"
                                          StrokeDashArray="{StaticResource dashArray}"/>
                </chart:NumericalAxis.MinorGridLineStyle>
                
                <chart:NumericalAxis.MajorGridLineStyle>
                    <chart:ChartLineStyle Stroke="Blue"
									      StrokeWidth="2"/>
                </chart:NumericalAxis.MajorGridLineStyle>
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Temperature (In Fahrenheit)" FontSize="25"/>
                </chart:NumericalAxis.Title>
                <chart:NumericalAxis.LabelStyle>
                    <chart:ChartAxisLabelStyle LabelFormat="##°F"></chart:ChartAxisLabelStyle>
                </chart:NumericalAxis.LabelStyle>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>

        <chart:SplineSeries ItemsSource="{Binding Data}" 
                            ShowMarkers="True"
                            XBindingPath="Month" 
                            YBindingPath="Temperature"
                            StrokeWidth="2"/>
    </chart:SfCartesianChart>
```
```
##[C#]
SfCartesianChart chart = new SfCartesianChart();
        this.BindingContext = new ViewModel();
        NumericalAxis primaryAxis = new NumericalAxis();
        chart.XAxes.Add(primaryAxis);
        DoubleCollection doubleCollection = new DoubleCollection();
        doubleCollection.Add(3);
        doubleCollection.Add(3);
        NumericalAxis secondaryAxis = new NumericalAxis();
        secondaryAxis.ShowMajorGridLines = true;
        ChartLineStyle axisLineStyle = new ChartLineStyle();
        axisLineStyle.Stroke = Colors.Blue;
        axisLineStyle.StrokeWidth = 2;
        secondaryAxis.MajorGridLineStyle = axisLineStyle;
        secondaryAxis.ShowMinorGridLines = true;
        secondaryAxis.MinorTicksPerInterval = 2;
        ChartLineStyle axisLineStyle = new ChartLineStyle();
        axisLineStyle.Stroke = Colors.Green;
        axisLineStyle.StrokeWidth = 1;
        axisLineStyle.StrokeDashArray = doubleCollection;
        secondaryAxis.MinorGridLineStyle = axisLineStyle;
        chart.YAxes.Add(secondaryAxis);
        SplineSeries series = new SplineSeries()
        {
            ItemsSource = (new ViewModel()).Data,
            ShowMarkers = True,
            XBindingPath = "Month",
            YBindingPath = "Temperature"
            StrokeWidth = 2
        };
    
        chart.Series.Add(series);
        this.Content = chart;
```

##Output

<img width="952" alt="Screenshot 2023-06-20 145004" src="https://github.com/SyncfusionExamples/How-to-rotate-axis-labels-in-.NET-MAUI-Chart-SfCartesianChart/assets/126754274/9f4997a1-fca7-4e2f-b9ab-7bb516103c90">