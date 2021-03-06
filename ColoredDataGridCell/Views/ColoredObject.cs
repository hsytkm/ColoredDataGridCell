﻿using System;
using System.Windows.Media;

namespace ColoredDataGridCell.Views
{
    class ColoredObject
    {
        public object Object { get; }
        public Brush Foreground { get; }
        public Brush Background { get; }

        public ColoredObject(int value, int max)
        {
            Object = value;

            var b = (byte)Math.Min(value * 255 / max, 0xff);
            var f = (byte)~b;
            Background = new SolidColorBrush(Color.FromRgb(b, b, 0x00));
            Foreground = new SolidColorBrush(Color.FromRgb(f, f, f));
        }
    }
}
