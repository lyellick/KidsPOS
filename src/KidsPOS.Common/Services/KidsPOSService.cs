using KidsPOS.Common.Context;
using KidsPOS.Common.Services.IServices;

namespace KidsPOS.Common.Services
{
    public class KidsPOSService : IKidsPOSService
    {
        private readonly KidsPOSContext _context;

        public KidsPOSService(KidsPOSContext context)
        {
            _context = context;
        }
    }
}
