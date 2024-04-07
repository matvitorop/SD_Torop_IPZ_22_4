namespace FlyWeight
{
    public class BookToHTMLConverterNoFW
    {
        private FlyweightFactory _flyweightFactory = new FlyweightFactory();
        public string ConvertToHTML(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            LightElementNodeNoFW body = new LightElementNodeNoFW("body", "inline", "closing", new List<string>());

            // Перший рядок як заголовок h1
            if (lines.Length > 0)
            {
                LightElementNodeNoFW h1 = new LightElementNodeNoFW("h1", "inline", "closing", new List<string>());
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
                    LightElementNodeNoFW h2 = new LightElementNodeNoFW("h2", "inline", "closing", new List<string>());
                    h2.addChild(new LightTextNode(line));
                    node = h2;
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    // Рядок починається з пробільного символу - blockquote
                    LightElementNodeNoFW blockquote = new LightElementNodeNoFW("blockquote", "inline", "closing", new List<string>());
                    blockquote.addChild(new LightTextNode(line.Trim()));
                    node = blockquote;
                }
                else
                {
                    // Всі інші рядки - елемент p
                    LightElementNodeNoFW p = new LightElementNodeNoFW("p", "inline", "closing", new List<string>());
                    p.addChild(new LightTextNode(line));
                    node = p;
                }

                body.addChild(node);
            }

            return body.OuterHTML();
        }
    }
}
