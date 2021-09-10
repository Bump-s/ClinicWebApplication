using ClinicApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL.DTO
{
    public class SicknessDTO
    {
        public Guid Id { get; set; }
        public string SicknessName { get; set; }
        public DateTime DateGetSickness { get; set; }
        public DateTime DateRecovered { get; set; }
        public Doctor Doktor { get; set; }
        public string UsedDrugs { get; set; }
        public string Research { get; set; }
        public string DoktorComment { get; set; }
        public string Symptoms { get; set; }
        public string PatientComplaints { get; set; }
    }
}
