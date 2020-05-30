using Aula118.Entities.Enums;

namespace Aula118.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        internal WorkerLevel Level { get; set; }
    }
}
