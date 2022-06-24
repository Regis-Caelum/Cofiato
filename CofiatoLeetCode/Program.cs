using System.Text;

namespace CofiatoLeetCode
{

    public class Count
    {
        public static string CountAndSay(int n)
        {
            StringBuilder res = new("1");
            if (n == 1)
            {
                return res.ToString();
            }

            string str = res.ToString();
            for (int i = 2; i <= n; ++i)
            {
                res = new();
                int cnt = 0;

                int winStart = 0;
                // Console.Write(i + " " + str + " ");

                for (int winEnd = 0; winEnd < str.Length; ++winEnd)
                {
                    if (str[winStart] == str[winEnd])
                    {
                        cnt++;
                        // Console.Write(str[winStart] + " " + str[winEnd] + " " );
                        if (winEnd == str.Length - 1)
                        {
                            res.Append(cnt.ToString());
                            res.Append(str[winStart]);
                            cnt = 0;
                        }
                    }
                    else
                    {
                        // Console.Write(cnt + " " + str[winStart] + " ");
                        res.Append(cnt.ToString());
                        res.Append(str[winStart]);
                        winStart = winEnd;
                        winEnd--;
                        // Console.Write(winStart + " " + str[winStart] + " ");
                        cnt = 0;
                    }
                }
                str = res.ToString();
                // Console.WriteLine();
            }
            return str;
        }

    }

    public class Median
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new();
            int i = 0, j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    list.Add(nums2[j++]);
                }
                else
                {
                    list.Add(nums1[i++]);
                }
            }

            for (; i < nums1.Length; ++i)
            {
                list.Add(nums1[i]);
            }

            for (; j < nums2.Length; ++j)
            {
                list.Add(nums2[j]);
            }
            // list.ForEach(Console.Write);

            // Console.Write(list[(nums1.Length + nums2.Length)/2] + " " + list[(nums1.Length + nums2.Length)/2 - 1]);

            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                return (list[(nums1.Length + nums2.Length) / 2] + list[(nums1.Length + nums2.Length) / 2 - 1]) / 2.0;
            }

            return list[(nums1.Length + nums2.Length) / 2];
        }
    }

    public class Substring
    {
        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }

    public class CofiatoLeetCode
    {
        public static void Main()
        {
            Console.WriteLine(Count.CountAndSay(5));
            Console.WriteLine(Median.FindMedianSortedArrays(new[] { 1, 2 },new[] { 3, 4 } ));
            Console.WriteLine(Substring.StrStr("hello","ll"));
        }
    }

}