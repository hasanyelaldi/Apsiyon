using System;
using System.ComponentModel.DataAnnotations;

namespace Apsiyon.App.Models
{
    public class ErrorLog : IModel
    {
        public int Id { get; set; }
        public string Description { get; set;}
        public string ObjString{get;set;}
    }
}
