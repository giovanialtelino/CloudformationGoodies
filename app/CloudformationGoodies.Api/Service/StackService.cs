

using System.Collections;

namespace CloudformationGoodies.Api.Service
{
    public interface IStackService
    {
        List<Stack> GetAll();
        Stack Upsert(Stack stack);
        Stack Delete(string guid);
    }

    public class StackService : IStackService
    {
        public Stack Delete(string guid)
        {
            throw new NotImplementedException();
        }

        public List<Stack> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stack Upsert(Stack stack)
        {
            throw new NotImplementedException();
        }
    }
}
