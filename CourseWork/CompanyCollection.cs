using CourseWork.Enums;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public static class CompanyCollection
    {
        //список компаний
        public static BindingList<Company> companies = new BindingList<Company>();
        //конструктор
        static CompanyCollection()
        {
            companies = DataBaseRepository.Get();
        }
        /// <summary>
        /// Добавление компании в список
        /// </summary>
        /// <param name="company"></param>
        public static void AddCompany(Company company)
        {
            company.Id = companies.LastOrDefault()?.Id + 1 ?? 1;
            companies.Add(company);

        }
        /// <summary>
        /// Удаление компании по ее ID
        /// </summary>
        public static void DeleteCompany(int id)
        {
            Company foundCompany = companies.FirstOrDefault(x => x.Id == id);
            if (foundCompany != null)
            {
                companies.Remove(foundCompany);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
        /// <summary>
        /// Замена по Id одной кампании на другую
        /// </summary>
        /// <param name="id"></param>
        /// <param name="company"></param>
        public static void ChangeCompany(int id, Company company)
        {
            Company foundCompany = companies.FirstOrDefault(x => x.Id == id);
            if (foundCompany != null)
            {
                company.Id = id;
                companies[(companies.IndexOf(foundCompany))] = company;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
        /// <summary>
        /// Получение информации о компани по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Company GetCompanyById(int id)
        {
            return companies.SingleOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// Нахождение компаний по заданым критериям
        /// </summary>
        /// <param name="company"></param>
        public static BindingList<Company> Search(CompanySearchParameter parameters)
        {
            IEnumerable<Company> companiesCopy = MakeCompaniesCopy();

            //if (!string.IsNullOrEmpty(parameters.Name))
            //{
            //    companiesCopy = companiesCopy.Where(c => string.Equals(c.Name, parameters.Name, StringComparison.CurrentCultureIgnoreCase));
            //}
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                companiesCopy = companiesCopy.Where(c => c.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if (parameters.Category != Category.любой)
            {
                companiesCopy = companiesCopy.Where(c => c.Category == parameters.Category);
            }

            if (parameters.Services != null && parameters.Services.Any())
            {
                companiesCopy = companiesCopy
                    .Where(c => c.Services.Select(s => s.ToLower())
                                          .Intersect(parameters.Services.Select(s => s.ToLower())).Count() >= parameters.Services.Count);
            }

            if (parameters.Specialization != Specialization.любая)
            {
                companiesCopy = companiesCopy.Where(c => c.Specialization == parameters.Specialization);
            }

            if (parameters.Ownership != OwnershipType.любая)
            {
                companiesCopy = companiesCopy.Where(c => c.Ownership == parameters.Ownership);
            }

            if (parameters.Schedules != null && parameters.Schedules.Any())
            {
                parameters.Schedules.ForEach(s =>
                {
                    companiesCopy = companiesCopy.Where(c =>
                            c.Schedules.FirstOrDefault(sc => sc.Day == s.Day)?.StartWorkingTime.ToString().Substring(11, 5) == "00:00" ||
                            c.Schedules.FirstOrDefault(sc => sc.Day == s.Day)?.StartWorkingTime.TimeOfDay <= s.StartWorkingTime.TimeOfDay);

                    companiesCopy = companiesCopy.Where(c =>
                            c.Schedules.FirstOrDefault(sc => sc.Day == s.Day)?.EndWorkingTime.ToString().Substring(11, 5) == "23:59" ||
                            c.Schedules.FirstOrDefault(sc => sc.Day == s.Day)?.EndWorkingTime.TimeOfDay >= s.EndWorkingTime.TimeOfDay);
                });

            }

            //if(parameters.Contacts != null && !string.IsNullOrEmpty(parameters.Contacts.Addres.City))
            //{
            //    companiesCopy = companiesCopy.Where(c => c.Contacts.Addres.City == parameters.Contacts.Addres.City);
            //}

            if (parameters.Contacts != null && !string.IsNullOrEmpty(parameters.Contacts.Addres.City))
            {
                companiesCopy = companiesCopy.Where(c => c.Contacts.Addres.City.ToLower().
                Contains(parameters.Contacts.Addres.City.ToLower()));
            }

            //if (parameters.Contacts != null && !string.IsNullOrEmpty(parameters.Contacts.Addres.Street))
            //{
            //    companiesCopy = companiesCopy.Where(c => c.Contacts.Addres.Street == parameters.Contacts.Addres.Street);
            //}
            if (parameters.Contacts != null && !string.IsNullOrEmpty(parameters.Contacts.Addres.Street))
            {
                companiesCopy = companiesCopy.Where(c => c.Contacts.Addres.Street.ToLower().
                Contains(parameters.Contacts.Addres.Street.ToLower()));
            }

            if (parameters.Contacts != null && parameters.Contacts.Addres.HouseNumber != 0)
            {
                companiesCopy = companiesCopy.Where(c => c.Contacts.Addres.HouseNumber == parameters.Contacts.Addres.HouseNumber);
            }

            if(parameters.Contacts != null && !string.IsNullOrEmpty(parameters.Contacts.Telephone))
            {
                companiesCopy = companiesCopy.Where(c => c.Contacts.Telephone == parameters.Contacts.Telephone);
            }
            BindingList<Company> result = new BindingList<Company>();
            companiesCopy.ToList().ForEach(c => result.Add(c));
            return result;
        }

        private static List<Company> MakeCompaniesCopy()
        {
            List<Company> companiesCopy = new List<Company>();
            for (int i = 0; i < companies.Count; i++)
            {
                companiesCopy.Add(companies[i]);
            }
            return companiesCopy;
        }
    }
}
