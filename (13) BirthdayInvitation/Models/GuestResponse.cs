using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetingAppMvc.Models
{
    public class GuestResponse
    {
        public virtual String Name
        { get; set; }
        public virtual String Email
        { get; set; }
        public virtual String ContactNo
        { get; set; }
        public virtual Boolean WillAttend
        { get; set; }
        public virtual Boolean Veg
        { get; set; }
    }
}