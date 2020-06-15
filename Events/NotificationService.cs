using System;

namespace EventsDelegates
{
    class NotificationService
    {
        private ILogger logger = new NotificationLogger();

        public void OnPhotoProcessed(object source, PhotoEventArgs e)
        {
            logger.Log(LogMessageType.Info, "Photo was processed successfully, come check it out!");
        }
    }
}
