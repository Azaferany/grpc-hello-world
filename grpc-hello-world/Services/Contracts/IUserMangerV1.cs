using System.Threading;
using System.Threading.Tasks;
using grpc_hello_world.ViewModels;
using ProtoBuf.Grpc.Configuration;

namespace grpc_hello_world.Services.Contracts
{
    [Service("grpc_hello_world.v1.UserManger")]
    public interface IUserMangerV1
    {
        [Operation]
        ValueTask<UserResult> GetUserAsync(UserRequest request, CancellationToken cancellationToken = default);
    }
}