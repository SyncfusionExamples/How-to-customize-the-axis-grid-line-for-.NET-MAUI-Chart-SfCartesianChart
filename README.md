# How-to-customize-the-axis-grid-line-for-.NET-MAUI-Chart-SfCartesianChart
This article explains how to customize the axis grid line in .NET MAUI platform.

The .NET MAUI Chart provides support to customize the axis grid lines with the help of the MajorGridLineStyle, MinorGridLineStyle, MajorTickStyle and MinorTickStyle properties of the chart axis. These properties provide options to change the width, style (such as dashes), and color of grid lines. 
The visibility of the major gridlines can be controlled using the ShowMajorGridLines property. The default value of ShowMajorGridLines is true.

**Step 1:** Customize the appearance of major gridlines using MajorGridLineStyle property in the ChartAxis.
<br>
**[XAML]**
```
<chart:SfCartesianChart >
    . . .
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis ShowMajorGridLines="True">
                <chart:NumericalAxis.MajorGridLineStyle>
                    <chart:ChartLineStyle Stroke="Blue"									          
                                          StrokeWidth="2"/>     
                </chart:NumericalAxis.MajorGridLineStyle>
                       </chart:NumericalAxis>
       </chart:SfCartesianChart.YAxes>
<chart:SfCartesianChart >
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
 . . .
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.ShowMajorGridLines = true;
ChartLineStyle axisLineStyle = new ChartLineStyle();
axisLineStyle.Stroke = Colors.Blue;
axisLineStyle.StrokeWidth = 2;
secondaryAxis.MajorGridLineStyle = axisLineStyle;
chart.YAxes.Add(secondaryAxis);
```
**Step 2:** Set the minor gridlines style to a dashed pattern using the StrokeDashArray property.
<br>
**[XAML]**
```
<chart:SfCartesianChart >
    <chart:SfCartesianChart.Resources>
            <DoubleCollection x:Key="dashArray">
                <x:Double>3</x:Double>
                <x:Double>3</x:Double>
            </DoubleCollection>
    </chart:SfCartesianChart.Resources>
    . . .
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis ShowMinorGridLines="True"  
                                 MinorTicksPerInterval="2">
                <chart:NumericalAxis.MinorGridLineStyle>
                    <chart:ChartLineStyle Stroke="Green"
                                          StrokeWidth="1"
                                          StrokeDashArray="{StaticResource dashArray}"/>
                </chart:NumericalAxis.MinorGridLineStyle>
                       </chart:NumericalAxis>
       </chart:SfCartesianChart.YAxes>
<chart:SfCartesianChart >
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
    . . .
DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(3);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.ShowMinorGridLines = true;
secondaryAxis.MinorTicksPerInterval = 2;
ChartLineStyle axisLineStyle = new ChartLineStyle();
axisLineStyle.Stroke = Colors.Green;
axisLineStyle.StrokeWidth = 1;
axisLineStyle.StrokeDashArray = doubleCollection;
secondaryAxis.MinorGridLineStyle = axisLineStyle;
chart.YAxes.Add(secondaryAxis);
```
Output

<img width="952" alt="Screenshot 2023-06-20 145004" src="https://github.com/SyncfusionExamples/How-to-rotate-axis-labels-in-.NET-MAUI-Chart-SfCartesianChart/assets/126754274/9f4997a1-fca7-4e2f-b9ab-7bb516103c90"> 