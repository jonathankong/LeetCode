using System;

namespace LeetCodeSolutions
{
    public static class FloodFill
    {
        public static int[][] Solution(int[][] image, int sr, int sc, int newColor)
        {
            //If starting color is the same as the new color, don't do anything 
            if (image[sr][sc] == newColor) return image;
            
            //Else, recurse through array to find other adjacent starting colors
            Recursion(ref image, sr, sc, newColor, image[sr][sc]);
            return image;
            
        }
        
        private static void Recursion(ref int[][] image, int sr, int sc, int newColor, int startPixelVal)
        {
            if (sr >= 0 && sr < image.Length && sc >= 0 && sc < image[0].Length) 
            {
                if (image[sr][sc] == startPixelVal) 
                {
                    image[sr][sc] = newColor;
                    
                    //Look up
                    Recursion(ref image, sr - 1, sc, newColor, startPixelVal);
                    //Look down
                    Recursion(ref image, sr + 1, sc, newColor, startPixelVal);
                    //Look left
                    Recursion(ref image, sr, sc - 1, newColor, startPixelVal);
                    //Look right
                    Recursion(ref image, sr, sc + 1, newColor, startPixelVal);
                }
            }
        }
    }
}