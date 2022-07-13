namespace Business.Interfaces
{
    public interface IAutoManager
    {
        public Task<AutoVM> CreateAsync(AutoVM obj);
        public Task<AutoVM> UpdateAsync(AutoVM obj);
        public Task<int> DeleteAsync(int id);
        public Task<AutoVM> GetAsync(int id);
        public Task<IEnumerable<AutoVM>> GetAllAsync();
    }
}
