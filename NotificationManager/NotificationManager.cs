using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Mail;

namespace NotificationManager
{

    public interface INotificationManager
    {
        void SignalProcess(string signalCode);
        void AddAddressForSignals(MailAddress mailAddress);
        void AddAddressForSignals(MailAddress mailAddress, string signalCode);

        void ExcludeAddressFromSig(MailAddress mailAddress);

        void ExcludeAddressFromSig(MailAddress mailAddress, string signalCode);
        static IList<string> GetListSignals()
        {

        }
        void AddSignal(string signalCode)
        {

        }
        static bool CheckAddressSignalCode(MailAddress mailAddress, string signalCode)
        {

        }
    }

    public class NotificationManager : INotificationManager
    {
        public SignalKey key = new SignalKey("signal1");
        IList<SignalKey> AllSignalKeys
        void INotificationManager.SignalProcess(string signalCode)
        {
            foreach(SignalKey key in )
            {

            }
        }
        void INotificationManager.ExcludeAddressFromSig(MailAddress mailAddress)
        {

        }
        void INotificationManager.ExcludeAddressFromSig(MailAddress mailAddress, string signalCode)
        {

        }
        void INotificationManager.AddAddressForSignals(MailAddress mailAddress)
        {

        }
        IList<string> INotificationManager.GetListSignals()
        {

        }
        void INotificationManager.AddSignal(string signalCode)
        {

        }
        void INotificationManager.AddAddressForSignals(MailAddress mailAddress, string signalCode)
        {

        }
        bool INotificationManager.CheckAddressSignalCode(MailAddress mailAddress, string signalCode)
        {
            
        }
    }
}
