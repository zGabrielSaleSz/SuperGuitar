namespace SuperGuitar.Core.Guitar
{
    public class GuitarNeck
    {
        public GuitarString[] Strings = new GuitarString[6];

        private static GuitarNeck _instance = null;
        private GuitarNeck()
        {
            
        }

        public static GuitarNeck GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GuitarNeck();
            }
            return _instance;
        }
    }
}
