using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetMVC.Models {
    public class Result : IResult {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ErrorText { get; set; }
    }
}