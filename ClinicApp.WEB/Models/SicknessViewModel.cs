using ClinicApp.BLL.DTO;
using System;

namespace ClinicApp.WEB.Models
{
    public class SicknessViewModel
    {
        public Guid Id { get; set; }
        public string SicknessName { get; set; }
        public DateTime DateGetSickness { get; set; }
        public DateTime DateRecovered { get; set; }
        public DoctorDTO Doktor { get; set; }
        public string UsedDrugs { get; set; }
        public string Research { get; set; }
        public string DoktorComment { get; set; }
        public string Symptoms { get; set; }
        public string PatientComplaints { get; set; }
    }
}
