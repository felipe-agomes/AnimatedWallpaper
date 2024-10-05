using System;
using System.Collections.Generic;
using System.Runtime;
using AnimatedThings.src.Shapes;
using Avalonia;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.Threading;

namespace AnimatedThings;

public partial class MainWindow : Window
{
    private DispatcherTimer _timer;
    private List<Ellipse> _ellipse;
    private List<double> _velocities = [];

    public MainWindow() {
        InitializeComponent();

        _timer = new DispatcherTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(16);
        _timer.Tick += OnTimerTick;
        _timer.Start();
        
        Principal.LayoutUpdated += OnLayoutUpdated;
    }

    private void OnLayoutUpdated(object? sender, EventArgs e) {
        Principal.LayoutUpdated -= OnLayoutUpdated;

        AddShapesToCanvas();
    }

    private void AddShapesToCanvas() {
        
        ControlBuilder controlBuilder = new ();
        this._ellipse = controlBuilder.createFish();

        for (var i = 0; i < this._ellipse.Count; i++) {
            Ellipse ellipse = this._ellipse[i];

            double centerTopPosition = Principal.Bounds.Height / 2 - ellipse.Height / 2;
            double centerLeftPosition = Principal.Bounds.Width / 2 - ellipse.Width / 2;

            Canvas.SetTop(ellipse, centerTopPosition);
            Canvas.SetLeft(ellipse, centerLeftPosition + i * 40);
            
            Principal.Children.Add(ellipse);
            this._velocities.Add(0);
        }
    }

    private void OnTimerTick(object sender, EventArgs e) {
        const double gravity = 0.5;

        for (int i = 0; i < this._ellipse.Count; i++) {
            if (i == 0) {
                Ellipse ellipse = this._ellipse[i];

                double top = Canvas.GetTop(ellipse);

                this._velocities[i] += gravity;

                top += this._velocities[i];

                if (top + ellipse.Height > Principal.Bounds.Height) {
                    this._velocities[i] = -this._velocities[i] * 0.7;
                    top = Principal.Bounds.Height - ellipse.Height;
                }

                Canvas.SetTop(ellipse, top);

            }
        }
   }
}