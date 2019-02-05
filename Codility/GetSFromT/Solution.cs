using System;

namespace Codility.GetSFromT
{
    public class Solution
    {
        public string solution(string S, string T)
        {
            var result = string.Empty;
            var length = S.Length;

            if (string.Equals(S, T))
            {
                return "EQUAL";
            }

            if(length + 1 < T.Length || Math.Abs(length - S.Length) > 1)
            {
                return "IMPOSSIBLE";
            }

            for (int i = 0; i < length; i++)
            {
                if (i >= T.Length || !Char.Equals(S[i], T[i]))
                {
                    if(length < T.Length)
                    {
                        S = S.Insert(i, T[i].ToString());
                        result = "INSERT " + S[i];
                        break;
                    }
                    else
                    {
                        if(i < length && T[i] == S[i+1] && S[i] == T[i + 1])
                        {
                            var replace = S[i];
                            S = S.Substring(0, i) + T[i+1] + T[i] + S.Substring(i + 2, length - i - 2);
                            result = "SWAP " + replace + " " + T[i];
                            break;
                        }
                        else
                        {
                            var replace = S[i];
                            S = S.Substring(0, i) + T[i] + S.Substring(i + 1, length - i - 1);
                            result = "REPLACE " + replace + " " + T[i];
                            break;
                        }
                    }
                }
            }

            if (Math.Abs(S.Length - T.Length) > 0)
            {
                return "IMPOSSIBLE";
            }

            return result;
        }
    }
}