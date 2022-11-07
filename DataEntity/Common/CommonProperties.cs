using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntity.Common
{
    public abstract class CommonProperties<T>
    {
        public DateTime CreationTime { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public DateTime? LastModifiedUserId { get; set; }
        public DateTime DeletionTime { get; set; }
        [Key]
        public T Id { get; set; }
    }
    public class CommonProperties : CommonProperties<string>
    {
        public CommonProperties()
        {
            Id = new Guid().ToString();
        }
    }
}

