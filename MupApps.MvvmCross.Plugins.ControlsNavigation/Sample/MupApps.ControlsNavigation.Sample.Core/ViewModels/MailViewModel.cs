// MailViewModel.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Cirrious.MvvmCross.ViewModels;
using MupApps.ControlsNavigation.Sample.Core.Model;
using MupApps.ControlsNavigation.Sample.Core.Services;

namespace MupApps.ControlsNavigation.Sample.Core.ViewModels
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
