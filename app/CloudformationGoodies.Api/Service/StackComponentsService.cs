using CloudformationGoodies.Shared.Model;

namespace CloudformationGoodies.Api.Service
{
    public interface IStackComponentsService
    {
        List<StackComponent> GetAll();
        StackComponent Upsert(StackComponent stack);
        StackComponent Delete(string guid);
        String GetCode(string guid);
    }

    public class StackComponentsService : IStackComponentsService
    {
        public StackComponent Delete(string guid)
        {
            throw new NotImplementedException();
        }

        public List<StackComponent> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetCode(string guid)
        {
            throw new NotImplementedException();
        }

        public StackComponent Upsert(StackComponent stack)
        {
            throw new NotImplementedException();
        }
    }
}
