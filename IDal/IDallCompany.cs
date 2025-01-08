namespace IDal
{
    public interface IDallCompany:IDallServices<Dto.Company>
    {
        public Task<List<Dto.Company>> Get();
    }
}
