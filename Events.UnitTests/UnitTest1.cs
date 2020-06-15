using NUnit.Framework;
using System;

namespace EventsDelegates.UnitTests
{
    public class PhotoProcessorTests
    {
        [Test]
        public void ConvertToJPG_JPGPhotoSupplied_ReturnsSamePhoto()
        {
            var processor = new PhotoProcessor(new FakeLogger());
            Photo photo = new Photo(PhotoFormat.JPG);
            Photo newPhoto = processor.ConvertToJPG(photo);

            Assert.AreEqual(photo, newPhoto);
        }

    }

    public class FakeLogger : ILogger
    {
        public void Log(LogMessageType type, string text)
        {
            Console.WriteLine(text);
        }
    }
}