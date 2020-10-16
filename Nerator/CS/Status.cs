using System;

namespace Nerator.CS
{
    public static class Status
    {
        private const string _DefaultStatus = "Uygulama işleyişi sorunsuz bir şekilde devam etmektedir.";
        public static string DefaultStatus => _DefaultStatus;

        private static string _Message = _DefaultStatus;
        public static string Message
        {
            get => _Message;
            set
            {
                _Message = value;
                ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
        }

        private static long _ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        public static long ChangedStatus
        {
            get => _ChangedStatus;
            set => _ChangedStatus = value;
        }
    }
}