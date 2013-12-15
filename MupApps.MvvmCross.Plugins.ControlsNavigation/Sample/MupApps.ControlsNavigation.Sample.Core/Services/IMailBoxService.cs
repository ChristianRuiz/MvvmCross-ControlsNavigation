using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MupApps.ControlsNavigation.Sample.Core.Model;

namespace MupApps.ControlsNavigation.Sample.Core.Services
{
    public interface IMailBoxService
    {
        List<Folder> GetFolders();

        Task<List<Mail>> GetMailsAsync(string folder);

        Task<Mail> GetMailAsync(int mailId);
    }
}
