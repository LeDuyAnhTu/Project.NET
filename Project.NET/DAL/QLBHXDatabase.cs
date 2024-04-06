/*
 * Date: 06/04/2024
 * Author: Lê Duy Anh Tú
 * Modified: 06/04/2024 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLBHXDatabase
    {
        //Properties
        private QLBHXDataContext db = null;
        private string connectString = Directory.GetCurrentDirectory() + @"\db\QLBHX.MDF";

        //Constructor
        public QLBHXDatabase()
        {
            db = new QLBHXDataContext(connectString);
        }

        //Getter
        public QLBHXDataContext DB
        {
            get { return db; }
        }
    }
}
