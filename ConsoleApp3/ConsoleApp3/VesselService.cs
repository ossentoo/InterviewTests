using System.IO;

namespace ConsoleApp3
{
    public class VesselService
    {
        private readonly IVesselRepository _repository;
        private readonly ILogger _logger;

        public VesselService(IVesselRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public void Add(Vessel vessel)
        {
            _repository.Add(vessel);
            _logger.Log($"Vessel added {vessel.VesselId}");
        }
    }

    public interface IVesselRepository
    {
        void Add(Vessel vessel);
    }


    public class VesselRepository : IVesselRepository
    {
        public void Add(Vessel vessel)
        {
            // add to the repository
        }
    }

    public class Vessel
    {
        public int VesselId { get; set; }
    }

    public interface IFileService
    {
        void Write(string text);
    }

    public class FileService : IFileService
    {
        private readonly string _logfilePath;

        // ideally this setting would be retrieved from ConfigurationManger.Appsetting or similar
        // or injected in as a configuration parameter.
        // It would have to be passed in by the main program at startup.
        public FileService(string logfilePath)
        {
            _logfilePath = logfilePath;
        }
        public void Write(string text)
        {
            File.WriteAllText(_logfilePath, text); ;
        }
    }

    public interface ILogger
    {
        void Log(string logText);
    }

    public class FileLogger : ILogger
    {
        private readonly IFileService _service;

        public FileLogger(IFileService service)
        {
            _service = service;
        }
        public void Log(string logText)
        {
            _service.Write(logText);
        }
    }
}
