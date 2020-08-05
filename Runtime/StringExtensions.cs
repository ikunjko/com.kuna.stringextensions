using UnityEngine;

namespace Kuna.Util
{
    public class StringExtensions : MonoBehaviour
    {
        private static string Version = "x.y.z";

        /// <summary>
        /// UpperCase helper
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string UpperCase(string s)
        {
            return s.ToUpper();
        }
    }
}