﻿
using System;

namespace P3Lab7

{
    public class OutOfInkEventArgs : EventArgs
    {
        public string Colour {get; set;}
        public int PageNumber {get; set;}
        public OutOfInkEventArgs(string colour, int pageNumber)
        {
            Colour = colour;
            PageNumber = pageNumber;
        }
    }
}