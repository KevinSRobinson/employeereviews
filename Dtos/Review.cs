using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{

    public class Review
    {
        public int Id { get; set; }

        public string Comments { get; set; }

        public int Rating { get; set; }

        public DateTime Date { get; set; }


    }
}
