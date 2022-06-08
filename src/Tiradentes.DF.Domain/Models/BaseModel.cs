using System;
using System.ComponentModel.DataAnnotations;

namespace Tiradentes.DF.Domain.Models
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
        }

        [Key]
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual DateTime DataCriacao { get; set; } = DateTime.Now;
        public virtual DateTime DataModificacao { get; set; } = DateTime.Now;
    }
}
