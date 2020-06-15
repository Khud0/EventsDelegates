using System;

namespace EventsDelegates
{
    class MailSerivce
    {
        private ILogger logger = new MailLogger();

        public void OnPhotoProcessed(object source, PhotoEventArgs e)
        {
            logger.Log(LogMessageType.Info, $"Your photo \"{e.ProcessedPhoto.Name}\" was processed!");
        }
    }
}
