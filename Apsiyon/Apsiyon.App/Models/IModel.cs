using System;
using System.ComponentModel.DataAnnotations;

namespace Apsiyon.App
{
    public interface IModel
    {
        [Key]
        int Id { get; set; }
    }
}
