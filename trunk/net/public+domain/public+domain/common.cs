using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace public_domain
{
    /// <summary>
    /// Application common. It keeps special data and methods.
    /// </summary>
    abstract class common
    {
        /// <summary>
        /// Get a Bitmap image with the color and size specified.
        /// </summary>
        /// <param name="color">The color of the bitmap</param>
        /// <param name="height">The height of the bitmap</param>
        /// <param name="width">The width of the bitmap</param>
        /// <returns>The bitmap with the color and size specified</returns>
        public static System.Drawing.Bitmap getBitMap(System.Drawing.Color color, int height, int width)
        {
            System.Drawing.Bitmap bitMap = new System.Drawing.Bitmap(width, height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitMap);
            g.Clear(color);

            return bitMap;
        }

        /// <summary>
        /// Get a 16x16 Bitmap image with the color specified.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The 16x16 bitmap with the color specified</returns>
        public static System.Drawing.Bitmap getBitMap(System.Drawing.Color color)
        {
            return getBitMap(color, 16,16);
        }

        /// <summary>
        /// String parser to use in sql filters.
        /// </summary>
        /// <param name="stringfilter">The string filter to parse</param>
        /// <returns>The string parsed</returns>
        public static string parseString(string stringfilter)
        {
            string res;

            res = stringfilter.Replace("'", "").Replace("%", "").Replace("?", "").Replace("*", "");

            return res;
        }
    }
}
