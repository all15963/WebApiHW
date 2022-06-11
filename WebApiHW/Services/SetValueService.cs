using WebApiPractice.Data;

namespace WebApiPractice.Services
{
    // 實作 新增數字 服務
    public class SetValueService : ISetValueService
    {
        private readonly DataDbContext _context;

        public SetValueService(DataDbContext context)
        {
            _context = context;
        }

        // 新增數字到DB
        public async Task<int> SetValueAsync(List<int> values)
        {
            var tempDataList = new List<TempData>();
            foreach (var value in values)
            {
                tempDataList.Add(
                    new TempData
                    {
                        Id = Guid.NewGuid(),
                        Value = value
                    });
            }
            await _context.TempDatas.AddRangeAsync(tempDataList);
            var count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
