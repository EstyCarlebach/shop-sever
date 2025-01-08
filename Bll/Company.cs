namespace Bll
{
    public class Company:IBll.IBlCompany
    {
        IDal.IDallCompany dalC;
        public Company(IDal.IDallCompany c)
        {
            this.dalC = c;
        }
        public async Task<List<Dto.Company>> Get()
        {
            return await dalC.Get();
        }

    }
}
