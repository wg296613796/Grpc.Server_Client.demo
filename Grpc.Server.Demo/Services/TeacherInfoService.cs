using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grpc.Server.Demo
{
    public class TeacherInfoService : TeacherService.TeacherServiceBase
    {
        public override Task GetAllTeacher(IAsyncStreamReader<TeacherInfo> requestStream, IServerStreamWriter<TeacherResponse> responseStream, ServerCallContext context)
        {
            return base.GetAllTeacher(requestStream, responseStream, context);
        }

        public override Task<TeacherResponse> GetTeachers(TeacherInfo request, ServerCallContext context)
        {
            return base.GetTeachers(request, context);
        }
    }
}
