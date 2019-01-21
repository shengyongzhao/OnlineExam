using System;
using OnlineExam.Core.Interfaces;
namespace OnlineExam.Core.Entities
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
