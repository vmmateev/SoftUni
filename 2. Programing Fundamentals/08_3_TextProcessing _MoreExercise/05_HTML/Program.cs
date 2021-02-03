using System;
using System.Text;

namespace _05_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string title = Console.ReadLine();
            sb.AppendLine("<h1>");
            sb.AppendLine(title);
            sb.AppendLine("</h1>");


            string content = Console.ReadLine();
            sb.AppendLine("<article>");
            sb.AppendLine(content);
            sb.AppendLine("</article>");
            string comments = string.Empty;
            while ((comments=Console.ReadLine())!="end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine(comments);
                sb.AppendLine("</div>");
            }
            Console.WriteLine(sb);
        }
    }
}
