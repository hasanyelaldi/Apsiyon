using System;
namespace Apsiyon.App
{
    public interface ILogger
    {
        void Add(string message, object obj);
    }
}
