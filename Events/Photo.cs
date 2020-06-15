namespace EventsDelegates
{
    public enum PhotoFormat
    {
        PNG,
        JPG
    }

    public class Photo
    {
        public string Name { get; set; }
        public PhotoFormat Format { get; private set; }

        public Photo(PhotoFormat format)
        {
            this.Format = format;
        }
    }
}
