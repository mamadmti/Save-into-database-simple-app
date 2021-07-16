using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Model
{
    public class Context:DbContext
    {
        public DbSet <birthday> birthdaydbset { set; get; }
    }
}
