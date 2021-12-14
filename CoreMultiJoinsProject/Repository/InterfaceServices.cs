using CoreMultiJoinsProject.Models;
using CoreMultiJoinsProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Repository
{
    public class InterfaceServices : IInterfaces
    {
        private ApplicationContext context;
        public InterfaceServices(ApplicationContext _context)
        {
            context = _context;
        }

        public List<CitiesDeatils> GetCities()
        {
            var objGetCities = from city in context.cities
                               join stat in context.states
                               on city.states.Id equals stat.Id
                               select new CitiesDeatils()
                               {
                                   Id=city.Id,
                                   CityName=city.CityName,
                                   CityCode=city.CityCode,
                                   StateCode=stat.StateCode,
                                   StateName=stat.StateName
                                   
                               };
            return objGetCities.ToList();
        }

        public List<Cities> GetCityById(int id)
        {
            var objk = context.cities.Where(e => e.states.Id == id).ToList();
            return objk;
        }

        public List<Countries> GetCountry()
        {
           var objCountries= context.countries.ToList();
           return objCountries;
        }

        public List<Departments> GetDepartments()
        {
            var getDep = context.departments.ToList();
            return getDep;
        }

        public List<Employee> GetEmployee()
        {
            var getEmp = context.employees.ToList();
            return getEmp;
        }

        public List<EmployeeDetails> GetEmployeeDetails()
        {
            var objGetEmpDet = from emp in context.employees
                               join dep in context.departments
                               on emp.departments.Id equals dep.Id
                               select new EmployeeDetails()
                               {
                                   Id=emp.Id,
                                   Name=emp.Name,
                                   Gender=emp.Gender,
                                   Email=emp.Email,
                                   Salary=emp.Salary,
                                   Department=dep.Department
                               };
            return objGetEmpDet.ToList();
        }

        

       

        public List<StateDetails> GetStates()
        {
            var objGetStateDet = from sts in context.states
                                 join cntr in context.countries
                                 on sts.countries.Id equals cntr.Id
                                 select new StateDetails()
                                 {
                                     Id = sts.Id,
                                     StateName = sts.StateName,
                                     StateCode = sts.StateCode,
                                     CountryName = cntr.CountryName
            };
            return objGetStateDet.ToList();
        }

        public List<States> GetStatesById(int id)
        {
            var objk = context.states.Where(e => e.countries.Id == id).ToList();
            return objk;
        }

        public CreateCities PostCities(CreateCities CrtCities)
        {
            var objStateFK = context.states.SingleOrDefault(e => e.Id == CrtCities.statesId);

            var objState = new Cities()
            {
               CityName=CrtCities.CityName,
                CityCode=CrtCities.CityCode,
                states=objStateFK
            };
            context.cities.Add(objState);
            context.SaveChanges();
            return CrtCities;
        }

        public Countries PostCountries(Countries countries)
        {
            context.countries.Add(countries);
            context.SaveChanges();
            return countries;
        }

        public Departments PostDeparments(Departments departments)
        {
            context.departments.Add(departments);
            context.SaveChanges();
            return departments;
        }

        public CreateEmployee PostEmployee(CreateEmployee createEmployee)
        {

            var objDep = context.departments.SingleOrDefault(e => e.Id == createEmployee.departmentsId);

            var objEmp = new Employee()
            {
                Name=createEmployee.Name,
                Gender=createEmployee.Gender,
                Email=createEmployee.Email,
                Salary=createEmployee.Salary,
                departments=objDep

            };

            context.employees.Add(objEmp);
            context.SaveChanges();
            return createEmployee;
        }

        public CreateState PostState(CreateState CrtStates)
        {
           var objCntryFK= context.countries.SingleOrDefault(e => e.Id == CrtStates.countriesId);

           var objState = new States()
            {
               StateName=CrtStates.StateName,
               StateCode=CrtStates.StateCode,
               countries=objCntryFK
            };
            context.states.Add(objState);
            context.SaveChanges();
            return CrtStates;
        }
    }
}
