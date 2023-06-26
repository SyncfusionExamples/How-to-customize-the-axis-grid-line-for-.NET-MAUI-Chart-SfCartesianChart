# How-to-customize-the-axis-grid-line-for-.NET-MAUI-Chart-SfCartesianChart
This article in the Syncfusion Knowledge Base explains how to customize the axis grid line in .NET MAUI platform.
```
##[Xaml]
<ContentPage.BindingContext>
        <model:ViewModel x:Name="ViewModelName"></model:ViewModel>
    </ContentPage.BindingContext>

    <chart:SfCartesianChart >

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis PlotOffsetEnd="25">
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Months"/>
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>

        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis MinorTicksPerInterval="2" Interval="5" PlotOffsetEnd="25" >
                <chart:NumericalAxis.MajorTickStyle>
                    <chart:ChartAxisTickStyle></chart:ChartAxisTickStyle>
                </chart:NumericalAxis.MajorTickStyle>
                <chart:NumericalAxis.MinorGridLineStyle>

                    <chart:ChartLineStyle Stroke="Green"
                                          StrokeWidth="1"
                                          StrokeDashArray="3,3"></chart:ChartLineStyle>
                </chart:NumericalAxis.MinorGridLineStyle>
                <chart:NumericalAxis.MajorGridLineStyle>
                    <chart:ChartLineStyle Stroke="Blue"
									      StrokeWidth="2"                                        
                                          />
                </chart:NumericalAxis.MajorGridLineStyle>
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Temperature (In fahrenheit)"/>
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
        ChartLineStyle axisLineStyle = new ChartLineStyle();
        axisLineStyle.Stroke = Colors.Blue;
        axisLineStyle.StrokeWidth = 2;
        axisLineStyle.StrokeDashArray = doubleCollection;
        primaryAxis.MajorGridLineStyle = axisLineStyle;
        chart.XAxes.Add(primaryAxis);

        NumericalAxis secondaryAxis = new NumericalAxis() { MinorTicksPerInterval = 2 };
        ChartLineStyle axisLineStyle = new ChartLineStyle();
        axisLineStyle.Stroke = Colors.Green;
        axisLineStyle.StrokeWidth = 1;
        axisLineStyle.StrokeDashArray = 3,3;
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
