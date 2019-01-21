using System;
namespace OnlineExam.Core.Entities
{
    /// <summary>
    /// Examinees.考生信息
    /// </summary>
    public class Examinees : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string School { get; set; }
    }
}