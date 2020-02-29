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
            Doctor doctor = new Doctor();
            doctor.ChangeName("Name");
        }

    }

    public class DatabaseStore
    {
        public string GetDoctorName()
        {
            return "";
        }

        public void SaveDoctorName(string name) 
        {
            
        }
    }

    public class XmlFileStore
    {
        public string GetDoctorName()
        {
            return "";
        }

        public void SaveDoctorName(string name)
        {

        }
    }

    public class CsvFileStore
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

        public string StorageType { get; set; }

        private readonly DatabaseStore _databaseStore = new DatabaseStore();
        private readonly XmlFileStore _xmlFileStore = new XmlFileStore();
        private readonly CsvFileStore _csvFileStore = new CsvFileStore();

        public Doctor()
        {
            
        }

        public void ChangeName(string name)
        {
            _logger.Trace("ChangeName - Enter");

            if (StorageType == "Database")
            {
                _databaseStore.SaveDoctorName(name);
            }
            if (StorageType == "XML")
            {
                _xmlFileStore.SaveDoctorName(name);
            }
            if (StorageType == "CSV")
            {
                _csvFileStore.SaveDoctorName(name);
            }

            _databaseStore.SaveDoctorName(name);

            _logger.Trace("ChangeName - Exit");
        }
    }
}
