using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Express.UI
{
    public class CaptchaHelper
    {
        private static string captchaText = "";

        public static Bitmap GenerateCaptcha(int width = 100, int height = 40)
        {
            Random rand = new Random();
            string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            captchaText = "";
            for (int i = 0; i < 4; i++) captchaText += chars[rand.Next(chars.Length)];

            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), 1),
                    rand.Next(width), rand.Next(height), rand.Next(width), rand.Next(height));
            }

            Font font = new Font("Arial", 18, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.FromArgb(rand.Next(100), rand.Next(100), rand.Next(100)));
            g.DrawString(captchaText, font, brush, 10, 5);
            g.Dispose();
            return bmp;
        }

        public static bool Validate(string input)
        {
            return string.Equals(input, captchaText, StringComparison.OrdinalIgnoreCase);
        }
    }
}
