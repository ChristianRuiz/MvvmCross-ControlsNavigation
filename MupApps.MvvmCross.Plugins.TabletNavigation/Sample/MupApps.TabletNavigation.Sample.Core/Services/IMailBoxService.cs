using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MupApps.TabletNavigation.Sample.Core.Model;

namespace MupApps.TabletNavigation.Sample.Core.Services
{
    public interface IMailBoxService
    {
        List<Folder> GetFolders();

        Task<List<Mail>> GetMailsAsync(string folder);

        Task<Mail> GetMailAsync(int mailId);
    }
}
