using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IDbService
    {
        public List<Doctor> GetDoctors();
        public bool AddDoctor(Doctor d);
        public bool ModifyDoctor(Doctor d);
        public bool DeleteDoctor(Doctor d);
    }
}
