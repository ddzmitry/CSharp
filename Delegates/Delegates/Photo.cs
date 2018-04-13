namespace Delegates
{
    public class Photo
    {
        // this is like a constructor thah loads up the photo from directory
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
          
        }
    }
}