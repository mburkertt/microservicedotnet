using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Filestore.Interfaces
{
    public interface IFilestoreService
    {
        IEnumerable<File> GetAllFiles();

        IEnumerable<FileStore> GetFileStores();

        File GetFileByID(Guid fileId);

        FileStore GetFileStoreById(Guid filestoreId);

        bool AddFile(File file);

        bool AddFileStore(FileStore fileStore);

        bool RemoveFile(Guid fileId);

        bool RemoveFilestore(Guid filestoreId);

        bool ExecuteJob(Job job);

    }
}
