using System.Collections.Generic;

class SortStackRecursively
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }
}
