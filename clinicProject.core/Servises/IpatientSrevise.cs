using clinicProject.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Servises
{
    public interface IpatientSrevise
    {
        public Task<List<ClassPatient>> GetClassdPatientAsync();
        public Task<ClassPatient> AddPatientAsync(ClassPatient doctor);
    }
}
