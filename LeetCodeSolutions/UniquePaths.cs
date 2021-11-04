using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCodeSolutions
{
    struct Tuple<X, Y> : IEquatable<Tuple<X, Y>>
    {
        readonly X first;
        readonly Y second;

        public Tuple(X first, Y second)
        {
            this.first = first;
            this.second = second;
        }

        public X First { get { return first; } }
        public Y Second { get { return second; } }

        public override int GetHashCode()
        {
            return 17 + first.GetHashCode() * 23 + second.GetHashCode() * 23;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Tuple<X, Y>)obj);
        }

        public bool Equals([AllowNull] Tuple<X, Y> other)
        {
            return other.first.Equals(first) && other.second.Equals(second);
        }
    }
    static class UniquePaths
    {
        static public int Solution(int m, int n)
        {
            var memo = new Dictionary<Tuple<int, int>, int>(); 
            return Recursion(n, m, 0, 0, memo);
        }

        static private int Recursion(int x, int y, int startX, int startY, Dictionary<Tuple<int, int>, int> memo)
        {
            if (memo.ContainsKey(new Tuple<int, int>(startX, startY)))
            {
                return memo[new Tuple<int, int>(startX, startY)];
            }
            else if (startX == x - 1 && startY == y - 1)
            {
                return 1;
            }
            else if (startX >= x || startY >= y)
            {
                return 0;
            }

            //Go Right + Go Down
            int answer = Recursion(x, y, startX + 1, startY, memo) + Recursion(x, y, startX, startY + 1, memo);

            if (answer > 0)
            {
                memo.Add(new Tuple<int, int>(startX, startY), answer);
            }

            return answer;
        }
    }
}
