namespace FlyWeight
{
    public class BookToHTMLConverter
    {
        private FlyweightFactory _flyweightFactory = new FlyweightFactory();
        public string ConvertToHTML(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            LightElementNode body = new LightElementNode("body", "inline", "closing", new List<string>(), _flyweightFactory);

            // Перший рядок як заголовок h1
            if (lines.Length > 0)
            {
                LightElementNode h1 = new LightElementNode("h1", "inline", "closing", new List<string>(), _flyweightFactory);
                h1.addChild(new LightTextNode(lines[0]));
                body.addChild(h1);
            }

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                LightNode node;
                if (line.Length < 20)
                {
                    // Рядок менше 20 символів - елемент h2
                    LightElementNode h2 = new LightElementNode("h2", "inline", "closing", new List<string>(), _flyweightFactory);
                    h2.addChild(new LightTextNode(line));
                    node = h2;
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    // Рядок починається з пробільного символу - blockquote
                    LightElementNode blockquote = new LightElementNode("blockquote", "inline", "closing", new List<string>(), _flyweightFactory);
                    blockquote.addChild(new LightTextNode(line.Trim()));
                    node = blockquote;
                }
                else
                {
                    // Всі інші рядки - елемент p
                    LightElementNode p = new LightElementNode("p", "inline", "closing", new List<string>(), _flyweightFactory);
                    p.addChild(new LightTextNode(line));
                    node = p;
                }

                body.addChild(node);
            }

            return body.OuterHTML();
        }
    }
}
