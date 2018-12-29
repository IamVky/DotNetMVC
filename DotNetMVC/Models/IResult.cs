using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMVC.Models
{
    interface IResult
    {
         int ID { get; set; }
         string Name { get; set; }
         string ErrorText { get; set; }
    }
}
