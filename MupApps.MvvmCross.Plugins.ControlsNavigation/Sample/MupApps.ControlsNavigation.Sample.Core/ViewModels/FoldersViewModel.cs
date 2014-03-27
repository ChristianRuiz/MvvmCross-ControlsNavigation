// FoldersViewModel.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;
using MupApps.ControlsNavigation.Sample.Core.Model;
using MupApps.ControlsNavigation.Sample.Core.Services;

namespace MupApps.ControlsNavigation.Sample.Core.ViewModels
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

        public IMvxCommand NavigateToSettingsCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SettingsViewModel>());
            }
        }
    }
}
