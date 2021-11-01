using ProtoBuf;

namespace grpc_hello_world.ViewModels
{
    [ProtoContract]
    public class UserResult
    {
        [ProtoMember(1)]
        public int Id { get; set; }
        
        [ProtoMember(2)]
        public string UserName { get; set; }
        
        [ProtoMember(3)]
        public string Email { get; set; }
    }
}