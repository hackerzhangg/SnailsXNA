using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TwoBrainsGames.BrainEngine
{
    /// <summary>
    /// Problems in WP8 with Path.GetDirectoryName() and GetFileName()
    /// </summary>
    public class BrainPath
    {
        public static string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(BrainPath.NormalizePath(path));
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetFileName(string path)
        {
            return Path.GetFileName(BrainPath.NormalizePath(path));
        }

        /// <summary>
        /// 
        /// </summary>
        private static string NormalizePath(string path)
        {
            path = path.Replace('/', '\\');
            if (DirectorySeparatorChar != '\\')
            {
                path = path.Replace('\\', DirectorySeparatorChar);
            }
            return path;
        }

        public static char DirectorySeparatorChar
        {
            get 
            {
#if WIN8
                return '\\';
#else
                return Path.DirectorySeparatorChar;
#endif
            }
        }
    }
}
