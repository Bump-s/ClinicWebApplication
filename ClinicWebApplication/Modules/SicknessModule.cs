using ClinicWebApplication.Entities;
using System;
using System.Collections.Generic;

namespace ClinicWebApplication.Modules
{
    public class SicknessModule
    {
        public Sickness CreateSickness(string sicknessName, DateTime dateRecovery,
            Doktor doktor, string usedDrugs = "", string research = "", string doktorComment = "",
            string symptoms = "", string patientComplaints = "")
        {
            var sickness = new Sickness()
            {
                DateGetSickness = DateTime.Now,
                DateRecovered = dateRecovery,
                Doktor = doktor,
                DoktorComment = doktorComment,
                UsedDrugs = usedDrugs,
                SicknessName = sicknessName,
                Symptoms = symptoms,
                PatientComplaints = patientComplaints,
                Research = research,
            };

            return sickness;
        }
    }
}
