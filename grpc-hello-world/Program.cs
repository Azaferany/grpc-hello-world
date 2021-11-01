using System.Threading.Tasks;
using grpc_hello_world.Services.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Grpc.Reflection;
using ProtoBuf.Meta;

namespace grpc_hello_world
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var generator = new SchemaGenerator
            {
                ProtoSyntax = ProtoSyntax.Proto3
            };

            var schema = generator.GetSchema<IUserMangerV1>(); // there is also a non-generic overload that takes Type

            Task.Run(async () =>
            {
                await using var writer = new System.IO.StreamWriter("grpc-hello-world-protobuf/services.proto");
                await writer.WriteAsync(schema);
            }).GetAwaiter().GetResult();
            
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}