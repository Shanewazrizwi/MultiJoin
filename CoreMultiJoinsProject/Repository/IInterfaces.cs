using CoreMultiJoinsProject.Models;
using CoreMultiJoinsProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Repository
{
    public interface IInterfaces
    {
        List<Departments> GetDepartments();
        Departments PostDeparments(Departments departments);

        CreateEmployee PostEmployee(CreateEmployee createEmployee);
        List<EmployeeDetails> GetEmployeeDetails();
        Countries PostCountries(Countries countries);
        CreateState PostState(CreateState CrtStates);
        CreateCities PostCities(CreateCities CrtCities);
        List<Countries> GetCountry();
        List<StateDetails> GetStates();
        List<CitiesDeatils> GetCities();

        List<States> GetStatesById(int id);
        List<Cities> GetCityById(int id);
    }
}
