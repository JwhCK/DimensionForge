﻿using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Point = System.Windows.Point;

namespace DimensionForge._2D.interfaces
{
    public interface IShape2D
    {

        string ID { get; set; }
        Point Position { get; set; }
        Point OldPosition { get; set; }
        System.Windows.Media.Color FillColor { get; set; }
        System.Windows.Media.Color StrokeColor { get; set; }
        float StrokeThickness { get; set; }
        public void Select();
        public void Deselect();
    

    }
}
