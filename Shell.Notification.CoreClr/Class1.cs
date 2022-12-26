
using System.Runtime.Versioning;

#if WINDOWS
using Microsoft.Windows.AppNotifications.Builder;
using Microsoft.Windows.AppNotifications;
#endif


namespace Shell.Notification.CoreClr
{
    public class Notification
    {

        public void SendNotification()
        {


#if WINDOWS
            WindowsSendNotification();
#else
            if (OperatingSystem.IsLinux())
            {
                
            } else if (OperatingSystem.IsLinux())
            {
            }
#endif
        }

#if WINDOWS
        // [SupportedOSPlatform("windows")]
        public void WindowsSendNotification()
        {
            var notification = new AppNotificationBuilder()
                .AddText("Notification text.")
                .SetScenario(AppNotificationScenario.Reminder)
                .BuildNotification();

            AppNotificationManager.Default.Show(notification);
        }
#endif

    }
}