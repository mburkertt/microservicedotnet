using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.PersistenceLayer.Interfaces
{
    interface IPersistenceLayerService
    {
        IEnumerable<File> GetAllFiles();

        IEnumerable<FileStore> GetFileStores();

        IEnumerable<Job> GetAllJobs();

        File GetFileByID(Guid fileId);

        FileStore GetFileStoreById(Guid filestoreId);

        Job GetJobById(Guid jobId);

        bool AddFile(File file);

        bool AddFileStore(FileStore fileStore);

        bool AddJob(Job job);

        bool RemoveFile(Guid fileId);

        bool RemoveFilestore(Guid filestoreId);

        bool RemoveJob(Guid jobId);
    }
}
