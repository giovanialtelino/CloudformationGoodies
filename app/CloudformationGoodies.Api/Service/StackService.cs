

using System.Collections;
using System.Threading.Tasks;

namespace CloudformationGoodies.Api.Service
{
    public interface IStackService
    {
        Task<List<Stack>> GetAll();
        Task<Stack> Upsert(Stack stack);
        Task<Stack> Delete(string guid);
    }

    public class StackService : IStackService
    {
        public async Task<Stack> Delete(string guid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Stack>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Stack> Upsert(Stack stack)
        {
            throw new NotImplementedException();
        }
    }
}
