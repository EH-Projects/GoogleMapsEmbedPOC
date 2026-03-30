using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace googleMapInsertPOC.ViewModels
{
    public class MapDataVM
    {
        public string API {  get; set; }
        public string MapID { get; set; }
        public string City { get; set; }
        [Required]
        public int ZIP { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
    }
}