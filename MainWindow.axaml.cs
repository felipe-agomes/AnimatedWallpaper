using System;
using System.Collections.Generic;
using AnimatedThings.src.Canvaz;
using AnimatedThings.src.Things;
using Avalonia.Controls;
using Avalonia.Threading;

namespace AnimatedThings;

public partial class MainWindow : Window
{
    private Fish _fish;
    private CanvasService _canvasService;
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

        double leftCenter = Principal.Bounds.Width / 2;
        double topCenter = Principal.Bounds.Height / 2;
        fishFactory.SetInitialPosition(topCenter, leftCenter);
        _fish = fishFactory.Create();

        _canvasService = new (Principal);
        List<Body> bodies = _fish.GetBodies();
        foreach (Body body in bodies)
        {
            _canvasService.InsertBody(body);
        }
    }


    private void TimerTick(Object sender, EventArgs e)
    {
        _fish.ApplyGravity();
        // _fish.FollowCursor();
        List<Body> bodies = _fish.GetBodies();
        foreach (Body body in bodies)
        {
            _canvasService.UpdateBody(body);
        }
    }
}
