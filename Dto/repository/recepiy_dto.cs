using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.repository
{
    public class recepiy_dto
    {
       
        public int Code { get; set; }
        public string? Name { get; set; }
        public string? Discrib { get; set; }
        public string? Img { get; set; }
        public string? Levels { get; set; }
        public int? Time { get; set; }
        public short? Meals { get; set; }
        public string? Instruction { get; set; }
        public int Codeuser { get; set; }

        //user
         public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? PassWord { get; set; }

    }
}
