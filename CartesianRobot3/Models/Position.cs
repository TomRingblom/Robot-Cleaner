﻿namespace CartesianRobot3.Models;

public class Position
{
    public double X { get; set; }
    public double Y { get; set; }

    public Position(double x, double y)
    {
        X = x;
        Y = y;
    }
}