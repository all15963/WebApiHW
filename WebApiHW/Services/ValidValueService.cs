using WebApiPractice.Data;

namespace WebApiPractice.Services
{
    // 實作 驗證傳入數字與DB數字的差異 服務
    public class ValidValueService : IValidValueService
    {
        private readonly DataDbContext _context;

        public ValidValueService(DataDbContext context)
        {
            _context = context;
        }

        // 驗證傳入數字與DB數字的差異
        public List<int> ValidValue(List<int> values)
        {
            var tempDatas = _context.TempDatas.Select(m => m.Value).ToList();

            return tempDatas.Where(v => !values.Contains(v)).ToList();
        }
    }
}
