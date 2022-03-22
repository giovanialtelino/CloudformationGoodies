using CloudformationGoodies.Shared.Model;

namespace CloudformationGoodies.Api.Service
{
    public interface IStackComponentsService
    {
        Task<List<StackComponent>> GetAll();
        Task<StackComponent> Upsert(StackComponent stack);
        Task<StackComponent> Delete(string guid);
        Task<String> GetCode(string guid);
    }

    public class StackComponentsService : IStackComponentsService
    {
        public async Task<StackComponent> Delete(string guid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StackComponent>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetCode(string guid)
        {
            throw new NotImplementedException();
        }

        public async Task<StackComponent> Upsert(StackComponent stack)
        {
            throw new NotImplementedException();
        }
    }
}
