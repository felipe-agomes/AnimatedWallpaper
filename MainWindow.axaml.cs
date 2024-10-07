using System;
using System.Collections.Generic;
using AnimatedThings.src.Canvaz;
using AnimatedThings.src.Things;
using Avalonia.Controls;
using Avalonia.Threading;

namespace AnimatedThings;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var timer = new DispatcherTimer();
        timer.Tick += TimerTick;
        timer.Interval = TimeSpan.FromMilliseconds(16);
        timer.Start();

        Principal.LayoutUpdated += OnLayoutUpdated;
    }

    private void OnLayoutUpdated(object sender, EventArgs e)
    {
        Principal.LayoutUpdated -= OnLayoutUpdated;

        InitialLoad();
    }

    private void InitialLoad()
    {
        FishFactory fishFactory = new ();
        Fish fish = fishFactory.Create();

        CanvasService canvasService = new(Principal);

        List<Body> controls = fish.GetBodies();

        foreach (Body body in controls)
        {
            canvasService.InsertBody(body);
        }
    }


    private void TimerTick(Object sender, EventArgs e)
    {

    }
}
