using System;
using System.Linq;
using forummvc.Models;

namespace forummvc.DAL.Services
{
    public class ThreadService
    {
        private readonly IThreadRepository _threadRepository;
        public ThreadService(IThreadRepository threadRepository)
        {
            _threadRepository = threadRepository;
        }
    }
}