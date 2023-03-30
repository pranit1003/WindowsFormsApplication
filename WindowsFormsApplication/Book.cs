using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    [Serializable]
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookPrice { get; set; }
        public string BookAuthor { get; set; }
        public int BookEdition { get; set; }
        public int BookPublication { get; set; }

    }
}
