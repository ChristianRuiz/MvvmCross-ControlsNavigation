using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;
using MupApps.TabletNavigation.Sample.Core.Model;
using MupApps.TabletNavigation.Sample.Core.Services;

namespace MupApps.TabletNavigation.Sample.Core.ViewModels
{
    public class FolderViewModel : MvxViewModel
    {
        private readonly IMailBoxService _mailBoxService;

        public FolderViewModel(IMailBoxService mailBoxService)
        {
            _mailBoxService = mailBoxService;
        }

        private Folder _folder;
        public Folder Folder
        {
            get { return _folder; }
            set
            {
                _folder = value;
                RaisePropertyChanged(() => Folder);
            }
        }

        private Mail _selectedMail;
        public Mail SelectedMail
        {
            get { return _selectedMail; }
            set
            {
                _selectedMail = value; 
                RaisePropertyChanged(() => SelectedMail);
                if (_selectedMail != null)
                    ShowViewModel<MailViewModel>(_selectedMail);
            }
        }

        private List<Mail> _mails;
        public List<Mail> Mails
        {
            get { return _mails; }
            set { _mails = value; RaisePropertyChanged(() => Mails); }
        }

        public async void Init(Folder folder)
        {
            Folder = folder;
            Mails = await _mailBoxService.GetMailsAsync(folder.Name);
        }
    }
}
