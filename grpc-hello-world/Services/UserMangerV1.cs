using System;
using System.Threading;
using System.Threading.Tasks;
using grpc_hello_world.Services.Contracts;
using grpc_hello_world.ViewModels;

namespace grpc_hello_world.Services
{
    public class UserMangerV1 : IUserMangerV1
    {
        public async ValueTask<UserResult> GetUserAsync(UserRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                await Task.Delay(5000, cancellationToken);

            }
            catch (Exception e)
            { }
            
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("IsCancellationRequested");
                return null;
            }
            return null;
        }
    }
}