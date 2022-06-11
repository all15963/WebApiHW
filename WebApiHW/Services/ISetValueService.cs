namespace WebApiPractice.Services
{
    // 新增數字 介面
    public interface ISetValueService
    {
        Task<int> SetValueAsync(List<int> values);
    }
}
