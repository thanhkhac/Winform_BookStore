using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore.DataAccess
{
    public class DbContextSingleton
    {
        private static BookStoreContext instance;

        private static readonly object lockObject = new object();

        public static BookStoreContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new BookStoreContext();
                        }
                    }
                }
                return instance;
            }
        }

        private DbContextSingleton() { }
    }
}
