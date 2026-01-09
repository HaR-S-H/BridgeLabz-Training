using System;
using System.Collections.Generic;

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                stack.Pop();

            span[i] = (stack.Count == 0) ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        return span;
    }
}
