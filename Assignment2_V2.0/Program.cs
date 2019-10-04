using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_Fall_Assignment2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int target = 5;
			int[] nums = { 1, 3, 5, 6 };
			Console.WriteLine("Position to insert {0} is = {1}\n", target, SearchInsert(nums, target));

			int[] nums1 = { 1, 2, 2, 1 };
			int[] nums2 = { 2, 2 };
			int[] intersect = Intersect(nums1, nums2);
			Console.WriteLine("Intersection of two arrays is: ");
			DisplayArray(intersect);
			Console.WriteLine("\n");

			int[] A = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
			Console.WriteLine("Largest integer occuring once = {0}\n", LargestUniqueNumber(A));

			string keyboard = "abcdefghijklmnopqrstuvwxyz";
			string word = "cba";
			Console.WriteLine("Time taken to type with one finger = {0}\n", CalculateTime(keyboard, word));

			int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };
			int[,] flipAndInvertedImage = FlipAndInvertImage(image);
			Console.WriteLine("The resulting flipped and inverted image is:\n");
			Display2DArray(flipAndInvertedImage);
			Console.Write("\n");

			int[,] intervals = { { 0, 30 }, { 5, 10 }, { 15, 20 } };
			int minMeetingRooms = MinMeetingRooms(intervals);
			Console.WriteLine("Minimum meeting rooms needed = {0}\n", minMeetingRooms);

			int[] arr = { -4, -1, 0, 3, 10 };
			int[] sortedSquares = SortedSquares(arr);
			Console.WriteLine("Squares of the array in sorted order is:");
			DisplayArray(sortedSquares);
			Console.Write("\n");

			string s = "abca";
			if (ValidPalindrome(s))
			{
				Console.WriteLine("The given string \"{0}\" can be made PALINDROME", s);
			}
			else
			{
				Console.WriteLine("The given string \"{0}\" CANNOT be made PALINDROME", s);
			}
		}

		public static void DisplayArray(int[] a)
		{
			foreach (int n in a)
			{
				Console.Write(n + " ");
			}
		}

		public static void Display2DArray(int[,] a)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(a[i, j] + "\t");
				}
				Console.Write("\n");
			}
		}

		public static int SearchInsert(int[] nums, int target)
		{
			try
			{
				// Write your code here
			}
			catch
			{
				Console.WriteLine("Exception occured while computing SearchInsert()");
			}

			return 0;
		}

		public static int[] Intersect(int[] nums1, int[] nums2)
		{
			var firstnumbers = new Dictionary<int, int>();

			foreach (var num in nums1)
			{
				if (firstnumbers.ContainsKey(num))
				{
					firstnumbers[num]++;
				}
				else
				{
					firstnumbers.Add(num, 1);
				}
			}

			var answer = new List<int>();
			foreach (var num in nums2)
			{
				if (firstnumbers.ContainsKey(num))
				{
					answer.Add(num);
					if (firstnumbers[num] > 1)
					{
						firstnumbers[num]--;
					}
					else
					{
						firstnumbers.Remove(num);
					}

				}
			}

			return answer.ToArray();
		}

		public static int LargestUniqueNumber(int[] A)
		{
			try
			{
				// Write your code here
			}
			catch
			{
				Console.WriteLine("Exception occured while computing LargestUniqueNumber()");
			}

			return 0;
		}

		public static int CalculateTime(string keyboard, string word)
		{
			try
			{
				// Write your code here
			}
			catch
			{
				Console.WriteLine("Exception occured while computing CalculateTime()");
			}

			return 0;
		}

		public static int[,] FlipAndInvertImage(int[,] A)
		{
			try
			{
				// Write your code here
			}
			catch
			{
				Console.WriteLine("Exception occured while computing FlipAndInvertImage()");
			}

			return new int[,] { };
		}

		public static int MinMeetingRooms(int[,] intervals)
		{
			try
			{
				// Write your code here
			}
			catch
			{
				Console.WriteLine("Exception occured while computing MinMeetingRooms()");
			}

			return 0;
		}

		public static int[] SortedSquares(int[] A)
		{
			int[] result = new int[A.Length];

			int start = 0, end = A.Length - 1;
			int index = A.Length - 1;

			while (start <= end)
			{
				int frontSquare = A[start] * A[start];
				int rearSquare = A[end] * A[end];

				if (frontSquare < rearSquare)
				{
					result[index--] = rearSquare;
					end--;
				}
				else
				{
					result[index--] = frontSquare;
					start++;
				}

			}
			return result;
		}

        public static bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            int numSkip = 0;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (numSkip == 0)
                    {
                        left += 1;
                        numSkip += 1;
                        continue;
                    }
                    else if (numSkip == 1)
                    {
                        left -= 1;     //trace back
                        right -= 1;
                        numSkip += 1;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                left += 1;
                right -= 1;
            }
            return true;
        }
    }
}