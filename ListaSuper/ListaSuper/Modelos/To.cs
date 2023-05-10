using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSuper.Modelos
{
    public class To
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
