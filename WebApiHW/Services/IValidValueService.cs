namespace WebApiPractice.Services
{
    // 驗證傳入數字與DB數字的差異 介面
    public interface IValidValueService
    {
        List<int> ValidValue(List<int> values);
    }
}
