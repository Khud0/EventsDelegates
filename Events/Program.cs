using System;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor(new ConsoleLogger());
            var mailService = new MailSerivce();
            var notificationService = new NotificationService();

            photoProcessor.PhotoProcessed += mailService.OnPhotoProcessed;
            photoProcessor.PhotoProcessed += notificationService.OnPhotoProcessed;

            photoProcessor.ConvertToJPG(new Photo(PhotoFormat.PNG) { Name = "PNG Photo"});
            photoProcessor.ConvertToJPG(new Photo(PhotoFormat.JPG) { Name = "JPG Photo"});
        }
    }
}
