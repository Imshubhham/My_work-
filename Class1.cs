using System;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

[ComVisible(true)]
public class MyExports
{
    [DllExport("Add", CallingConvention = CallingConvention.Cdecl)]
    public static void Add(double a, double b, out double c)
    {
        c = a + b;
    }
}