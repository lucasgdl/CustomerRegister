using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Entity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Boolean Active { get; private set; }

        public Entity()
        {
            var now = DateTime.Now;

            Id = Guid.NewGuid();
            CreatedAt = now;
            UpdatedAt = now;
            Active = true;
        }

        public void SetActive(bool active)
        {
            Active = active;
        }
    }
}
