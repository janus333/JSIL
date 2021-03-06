﻿using System;

public static class Program {
    public static unsafe void Main (string[] args) {
        var ints = new int[] { 0, 1, 2, 3, 4, 5 };

        fixed (int* p0 = &ints[0], p1 = &ints[1]) {
            var p2 = p0 + 1;

            PrintOrdering(p0, p0);
            PrintOrdering(p0, p1);
            PrintOrdering(p0, p2);
            PrintOrdering(p1, p2);
        }
    }

    public static unsafe void PrintOrdering (int* lhs, int* rhs) {
        Console.WriteLine(
            "< {0} > {1} <= {2} >= {3}",
            (lhs < rhs) ? "true" : "false",
            (lhs > rhs) ? "true" : "false",
            (lhs <= rhs) ? "true" : "false",
            (lhs >= rhs) ? "true" : "false"
        );
    }
}