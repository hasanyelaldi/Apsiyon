using System;
namespace Apsiyon.App.Models
{
    
        public class Error : IModel
        {
            public int Id { get; set; }
            public ErrorLog errorLog { get; set; }
            public string Description { get; set; }
        }

}
