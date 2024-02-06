using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Model
{
    public enum Specialization
    {
        ORTHO, PEDIA, ENT, DENTAL, POLY
    }

    public class Doctor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Specialization Specialization { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
