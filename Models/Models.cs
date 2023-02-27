using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
   

    public class Doctor
    {
        public int Id { get; set; }


        public string Name { get; set; }
       
        public string Speciality { get; set; }
        public float Experience { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }

    }

    public class EcomContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }

    public class Patient
    {
        public int Id { get; set; }
        public string PName { get; set; }
       
        public string Disease { get; set; }
        public string PatientMobile { get; set; }
        public int PatientAge { get; set; }
        public Gender PatientGender { get; set; }
        public string PatientBloodGroup { get; set; }
        public string City { get; set; }
    }
  
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Department
    {
        public int Id { get; set; }
        public string DepartName { get; set; }
    }

    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey("Pid")]
        public int PatientId { get; set; }
        public Patient Pid { get; set; }
        [ForeignKey("Did")]
        public int DoctorId { get; set; }
        public Doctor Did { get; set; }
        [ForeignKey("Deptid")]
        public int DepartId { get; set; }
        public Department Deptid { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string slot { get; set; }

    }

    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public string User { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
       

    }

}