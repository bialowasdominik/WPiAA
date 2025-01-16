namespace Flyweight
{
    public interface ITexture
    {
        void Render(int x, int y);
    }

    public class ConcreteTexture : ITexture
    {
        private string _textureFileName;

        public ConcreteTexture(string textureFileName)
        {
            _textureFileName = textureFileName;
            Console.WriteLine($"Wczytano teksturę z pliku: {_textureFileName}");
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Renderowanie tekstury {_textureFileName} na pozycji ({x}, {y})");
        }
    }

    public class TextureFactory
    {
        private Dictionary<string, ITexture> _textures = new Dictionary<string, ITexture>();

        public ITexture GetTexture(string textureFileName)
        {
            if (!_textures.ContainsKey(textureFileName))
            {
                _textures[textureFileName] = new ConcreteTexture(textureFileName);
            }
            return _textures[textureFileName];
        }
    }

    public class GameObject
    {
        private ITexture _texture;
        private int _x;
        private int _y;

        public GameObject(string textureFileName, int x, int y, TextureFactory textureFactory)
        {
            _texture = textureFactory.GetTexture(textureFileName);
            _x = x;
            _y = y;
        }

        public void Render()
        {
            _texture.Render(_x, _y);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TextureFactory textureFactory = new TextureFactory();

            GameObject character1 = new GameObject("hero.png", 10, 20, textureFactory);
            GameObject character2 = new GameObject("hero.png", 15, 25, textureFactory);
            GameObject tree = new GameObject("tree.png", 30, 40, textureFactory);
            GameObject rock = new GameObject("rock.png", 50, 60, textureFactory);

            character1.Render();
            character2.Render();
            tree.Render();
            rock.Render();
        }
    }
}
