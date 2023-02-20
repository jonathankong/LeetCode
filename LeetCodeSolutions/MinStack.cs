using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    class MinStack
    {
        //Using tuples to help keep track of minimum value at each item
        //This makes it easy to return the current minimum of the stack as it is always with the values the user entered into the stack.
        private Stack<Tuple<int, int>> stack;
        
        public MinStack() {
            stack = new Stack<Tuple<int, int>>();
        }
        
        //Need to compare previous minimum value with current value
        public void Push(int val) {
            if (stack.Count > 0)
            {
                var tuple = stack.Peek();
                if (tuple.Second > val) 
                    stack.Push(new Tuple<int, int>(val, val));
                else
                    stack.Push(new Tuple<int, int>(val, tuple.Second));
            }
            else 
                stack.Push(new Tuple<int, int>(val, val));   
        }
        
        public void Pop() {
            stack.Pop();
        }
        
        public int Top() {
            return stack.Peek().First;
        }
        
        public int GetMin() {
            return stack.Peek().Second;
        }
    }
}
