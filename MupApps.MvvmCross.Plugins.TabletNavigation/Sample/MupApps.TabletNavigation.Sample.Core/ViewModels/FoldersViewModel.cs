using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;
using MupApps.TabletNavigation.Sample.Core.Model;
using MupApps.TabletNavigation.Sample.Core.Services;

namespace MupApps.TabletNavigation.Sample.Core.ViewModels
{
    public class FoldersViewModel : MvxViewModel
    {
        private readonly IMailBoxService _mailBoxService;

        public FoldersViewModel(IMailBoxService mailBoxService)
        {
            _mailBoxService = mailBoxService;
        }

        private Folder _selectedFolder;
        public Folder SelectedFolder
        {
            get { return _selectedFolder; }
            set 
            { 
                _selectedFolder = value; 
                RaisePropertyChanged(() => SelectedFolder);
                if (_selectedFolder != null)
                    ShowViewModel<FolderViewModel>(_selectedFolder);
            }
        }

        private List<Folder> _folders;
        public List<Folder> Folders
        {
            get { return _folders; }
            set { _folders = value; RaisePropertyChanged(() => Folders); }
        }

        public void Init()
        {
            Folders = _mailBoxService.GetFolders();
        }
    }
}
