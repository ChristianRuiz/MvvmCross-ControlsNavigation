using Cirrious.MvvmCross.ViewModels;
using MupApps.TabletNavigation.Sample.Core.Model;
using MupApps.TabletNavigation.Sample.Core.Services;

namespace MupApps.TabletNavigation.Sample.Core.ViewModels
{
    public class MailViewModel : MvxViewModel
    {
        private readonly IMailBoxService _mailBoxService;

        public MailViewModel(IMailBoxService mailBoxService)
        {
            _mailBoxService = mailBoxService;
        }

        private Mail _mail;
        public Mail Mail
        {
            get { return _mail; }
            set { _mail = value; RaisePropertyChanged(() => Mail); }
        }

        public async void Init(Mail mail)
        {
            Mail = await _mailBoxService.GetMailAsync(mail.Id);
        }
    }
}
