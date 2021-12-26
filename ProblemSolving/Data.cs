using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

public class Data
{
    //static void Main(string[] args)
    //{
    //    MyDataStore ds = new MyDataStore(new Logger());
    //    ds.Create("shahd", "123");
    //    ds.Create("hossa", "123");

    //    ds.TryRead("shahd", out string data);
    //    ds.Update("mof", "");
    //    ds.TryRead("hkhk", out string data2);
    //    ds.Update("shahd", "");
    //    ds.TryRead("shahd", out string data3);
    //    ds.Delete("shahd");


    //}

    public interface IDataStore
    {
        bool Create(string key, string data);
        bool TryRead(string key, out string data);
        bool Update(string key, string data);
        bool Delete(string key);
    }


    public class MyDataStore : IDataStore
    {

        private Dictionary<string, string> store;
        private ILogger _logger;
        public MyDataStore(ILogger logger)
        {
            _logger = logger;
            store = new Dictionary<string, string>();
        }

        public bool Delete(string key)
        {
            bool success;
            try
            {
                _logger.Write($"MyDataStore: Call - Remove(‘{key}’)");

                if (store.TryGetValue(key, out string val))
                {
                    store.Remove(key);
                    success = true;
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ removed");
                }
                else
                {
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ does not exist");
                    success = false;
                }

            }
            catch (Exception ex)
            {
                _logger.Write($"MyDataStore: Result -  an exception had occurred " + ex.Message);
                success = false;

            }
            return success;
        }

        public bool TryRead(string key, out string data)
        {
            data = null;
            bool success;
            try
            {
                _logger.Write($"MyDataStore: Call - Read(‘{key}’)");

                if (store.TryGetValue(key, out string val))
                {
                    data = val;
                    success = true;
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ returned");
                }
                else
                {
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ does not exist");
                    success = false;
                }

            }
            catch (Exception ex)
            {
                _logger.Write($"MyDataStore: Result -  an exception had occurred " + ex.Message);
                success = false;

            }
            return success;
        }

        public bool Update(string key, string data)
        {
            bool success;
            try
            {

                _logger.Write($"MyDataStore: Call - Update(‘{key}’, ‘{data}’)");

                if (store.TryGetValue(key, out string val))
                {
                    store[key] = data;
                    success = true;
                    _logger.Write($"MyDataStore: Result - Entry with key {key} update with data {data}");
                }
                else
                {
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ does not exist");
                    success = false;
                }

            }
            catch (Exception ex)
            {
                _logger.Write($"MyDataStore: Result -  an exception had occurred " + ex.Message);
                success = false;

            }
            return success;
        }

        public bool Create(string key, string data)
        {
            bool success;
            try
            {
                _logger.Write($"MyDataStore: Call - Create(‘{key}’, ‘{data}’)");

                if (!store.TryGetValue(key, out string val))
                {
                    store.Add(key, data);
                    success = true;
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ and data ‘{data}’ created");
                }
                else
                {
                    _logger.Write($"MyDataStore: Result - Entry with key ‘{key}’ already existing");
                    success = false;
                }
            }
            catch (OutOfMemoryException ex)
            {
                _logger.Write($"MyDataStore: Result - an out of memory exception had occurred " + ex.Message);
                success = false;
            }

            catch (Exception ex)
            {
                _logger.Write($"MyDataStore: Result - an exception had occurred " + ex.Message);
                success = false;
            }
            return success;
        }
    }

    public interface ILogger
    {
        void Write(string message);
    }

    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}


