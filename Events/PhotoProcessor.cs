using System;
using System.Threading;

namespace EventsDelegates
{
    public class PhotoEventArgs : EventArgs
    {
        public Photo ProcessedPhoto { get; set; }
    }

    public class PhotoProcessor
    {
        private ILogger logger;

        public PhotoProcessor(ILogger logger)
        {
            this.logger = logger;
        }

        public event EventHandler<PhotoEventArgs> PhotoProcessed;

        /// <summary>
        /// This method doesn't make sense, since you would just give other format options based on uploaded photo.
        /// It is added to the solution merely for the test purposes.
        /// </summary>
        /// <param name="photo"></param>
        /// <returns></returns>
        public Photo ConvertToJPG(Photo photo)
        {
            logger.Log(LogMessageType.Info, $"Processing your photo \"{photo.Name}\"...");

            if (photo.Format == PhotoFormat.JPG)
            {
                logger.Log(LogMessageType.Error, $"Photo \"{photo.Name}\" is already in desired format! ({photo.Format})");
                return photo;
            }
            
            Thread.Sleep(1000);
            photo = new Photo(PhotoFormat.JPG) { Name = "PNG Photo" }; 

            OnPhotoProcessed(photo);
            return photo;
        }

        protected virtual void OnPhotoProcessed(Photo processedPhoto)
        {
            if (PhotoProcessed != null)
                PhotoProcessed(this, new PhotoEventArgs() { ProcessedPhoto = processedPhoto } );
        }
    }
}
