using System.Runtime.Serialization;
using ProtoBuf;

namespace grpc_hello_world.ViewModels
{
    [ProtoContract]
    public class UserRequest
    {
        [ProtoMember(1)]
        public int Id { get; set; }
    }
}