using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Converters
{
    public class Company
    {
        public static Dto.Company ToCompanyDto(models.Company c)
        {
            Dto.Company cNew = new Dto.Company();
            cNew.CompId = c.CompId;
            cNew.CompName= c.CompName;
            return cNew;
        }

        public static List<Dto.Company> ToListCourseDto(List<models.Company> lc)
        {
            List<Dto.Company> lnew = new List<Dto.Company>();
            foreach (models.Company c in lc)
            {
                lnew.Add(ToCompanyDto(c));
            }
            return lnew;
        }

        public static models.Company ToCompany(Dto.Company c)
        {
            models.Company cNew = new models.Company();
            cNew.CompId = c.CompId;
            cNew.CompName = c.CompName;       
            return cNew;
        }
    }
}
