using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // delegator that takes photo
        //public delegate void PhotoFilterHandler(Photo photo);

        //WE PASS DELEGATOR IN so any filter can be applied
        // using generic delegator Action<Photo> will do exactly the same thing as creating your own delegator
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}