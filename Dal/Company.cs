
using Dal.models;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class Company : IDal.IDallCompany
    {
        //public async Task<List<Dto.Company>> Get()
        //{
        //    throw new NotImplementedException();
        //}
        models.ShopContext db;
        public Company(ShopContext db)
        {
            this.db = db;
        }
        public async Task<List<Dto.Company>> Get()
        {
          
            //בעת שליפת הקורסים דאג לשלוף גם את פרטי המסלול/מחלקה שלהם כי נרצה להשתמש בשם המחלקה
            //SQLב Join כתבנו  C#בInclude עבור פעולת ה
            //Include כדי לחסוך שליפות . אם כן רוצים את פרטי טבלת האב מבצעים Depart=null מראש שדה הניווט 
            var q = await db.Companies.ToListAsync();
            //courseDto של מיקרוסופט שחזר לי בפקודה הקודמת לאוסף מסוג course המרת האסף מסוג 
            //1. המרה ידנית שאנחנו כתבנו ובה נשתמש כעת
            return Converters.Company.ToListCourseDto(q);
            //2.ספריה מוכנה שעדין לא למדנוauto mapper  המרה בעזרת 
        }

    }
}
