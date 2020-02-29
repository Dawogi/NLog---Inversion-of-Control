using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Diagnostics;

namespace HelloNLog
{
    class Program
    {

        static void Main(string[] args)
        {
            Doctor doctor = new Doctor(new XmlFileStore());
            doctor.ChangeName("Name");
        }

    }
    public interface IStore
    {
        static ILogger _logger;
        string GetDoctorName();
        void SaveDoctorName(string name);
    }


    public class DatabaseStore : IStore
    {
        public string GetDoctorName()
        {
            return "";
        }

        public void SaveDoctorName(string name) 
        {
            
        }
    }
    public class XmlFileStore : IStore
    {
        public string GetDoctorName()
        {
            return "";
        }

        public void SaveDoctorName(string name)
        {

        }
    }
    public class CsvFileStore : IStore
    {
        public string GetDoctorName()
        {
            return "";
        }

        public void SaveDoctorName(string name)
        {

        }
    }

    public class Doctor
    {
        private static ILogger _logger = LogManager.GetCurrentClassLogger();

        private readonly IStore _store;

        public Doctor(IStore store)
        {
            _store = store;
        }

        public void ChangeName(string name)
        {
            _logger.Trace("ChangeName - Enter");

            _store.SaveDoctorName(name);

            _logger.Trace("ChangeName - Exit");
        }
    }
}
