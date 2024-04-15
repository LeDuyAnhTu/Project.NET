using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BasicMethod<T>
    {
        protected static Database db = new Database();
        public abstract IQueryable LayDanhSach();
        public abstract bool Them(T obj);
        public abstract bool Xoa(string obj);
        public abstract bool Sua(T obj);
    }
}
