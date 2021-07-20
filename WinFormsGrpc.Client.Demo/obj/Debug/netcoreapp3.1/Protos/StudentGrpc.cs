// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/student.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc.Server.Demo {
  /// <summary>
  /// 约定需要提供的服务方法
  /// </summary>
  public static partial class StudentService
  {
    static readonly string __ServiceName = "user.StudentService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Grpc.Server.Demo.TokenRequest> __Marshaller_user_TokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.TokenRequest.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.TokenResponse> __Marshaller_user_TokenResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.TokenResponse.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.QueryStudentRequest> __Marshaller_user_QueryStudentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.QueryStudentRequest.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.StudentResponse> __Marshaller_user_StudentResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.StudentResponse.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.QueryAllStudentRequest> __Marshaller_user_QueryAllStudentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.QueryAllStudentRequest.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.UploadImgRequest> __Marshaller_user_UploadImgRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.UploadImgRequest.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.CommonResponse> __Marshaller_user_CommonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.CommonResponse.Parser));
    static readonly grpc::Marshaller<global::Grpc.Server.Demo.AddStudentRequest> __Marshaller_user_AddStudentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Server.Demo.AddStudentRequest.Parser));

    static readonly grpc::Method<global::Grpc.Server.Demo.TokenRequest, global::Grpc.Server.Demo.TokenResponse> __Method_GetToken = new grpc::Method<global::Grpc.Server.Demo.TokenRequest, global::Grpc.Server.Demo.TokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetToken",
        __Marshaller_user_TokenRequest,
        __Marshaller_user_TokenResponse);

    static readonly grpc::Method<global::Grpc.Server.Demo.QueryStudentRequest, global::Grpc.Server.Demo.StudentResponse> __Method_GetStudentByUserName = new grpc::Method<global::Grpc.Server.Demo.QueryStudentRequest, global::Grpc.Server.Demo.StudentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentByUserName",
        __Marshaller_user_QueryStudentRequest,
        __Marshaller_user_StudentResponse);

    static readonly grpc::Method<global::Grpc.Server.Demo.QueryAllStudentRequest, global::Grpc.Server.Demo.StudentResponse> __Method_GetAllStudent = new grpc::Method<global::Grpc.Server.Demo.QueryAllStudentRequest, global::Grpc.Server.Demo.StudentResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllStudent",
        __Marshaller_user_QueryAllStudentRequest,
        __Marshaller_user_StudentResponse);

    static readonly grpc::Method<global::Grpc.Server.Demo.UploadImgRequest, global::Grpc.Server.Demo.CommonResponse> __Method_UploadImg = new grpc::Method<global::Grpc.Server.Demo.UploadImgRequest, global::Grpc.Server.Demo.CommonResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadImg",
        __Marshaller_user_UploadImgRequest,
        __Marshaller_user_CommonResponse);

    static readonly grpc::Method<global::Grpc.Server.Demo.AddStudentRequest, global::Grpc.Server.Demo.StudentResponse> __Method_AddManyStudents = new grpc::Method<global::Grpc.Server.Demo.AddStudentRequest, global::Grpc.Server.Demo.StudentResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "AddManyStudents",
        __Marshaller_user_AddStudentRequest,
        __Marshaller_user_StudentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Server.Demo.StudentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for StudentService</summary>
    public partial class StudentServiceClient : grpc::ClientBase<StudentServiceClient>
    {
      /// <summary>Creates a new client for StudentService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StudentServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StudentService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StudentServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StudentServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StudentServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Grpc.Server.Demo.TokenResponse GetToken(global::Grpc.Server.Demo.TokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Grpc.Server.Demo.TokenResponse GetToken(global::Grpc.Server.Demo.TokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetToken, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Grpc.Server.Demo.TokenResponse> GetTokenAsync(global::Grpc.Server.Demo.TokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Grpc.Server.Demo.TokenResponse> GetTokenAsync(global::Grpc.Server.Demo.TokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetToken, null, options, request);
      }
      /// <summary>
      /// 简单模式，查询
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Grpc.Server.Demo.StudentResponse GetStudentByUserName(global::Grpc.Server.Demo.QueryStudentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentByUserName(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 简单模式，查询
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Grpc.Server.Demo.StudentResponse GetStudentByUserName(global::Grpc.Server.Demo.QueryStudentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStudentByUserName, null, options, request);
      }
      /// <summary>
      /// 简单模式，查询
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Grpc.Server.Demo.StudentResponse> GetStudentByUserNameAsync(global::Grpc.Server.Demo.QueryStudentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentByUserNameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 简单模式，查询
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Grpc.Server.Demo.StudentResponse> GetStudentByUserNameAsync(global::Grpc.Server.Demo.QueryStudentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStudentByUserName, null, options, request);
      }
      /// <summary>
      /// 服务端流模式
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Grpc.Server.Demo.StudentResponse> GetAllStudent(global::Grpc.Server.Demo.QueryAllStudentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 服务端流模式
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Grpc.Server.Demo.StudentResponse> GetAllStudent(global::Grpc.Server.Demo.QueryAllStudentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllStudent, null, options, request);
      }
      /// <summary>
      /// 客户端流模式
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Grpc.Server.Demo.UploadImgRequest, global::Grpc.Server.Demo.CommonResponse> UploadImg(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadImg(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 客户端流模式
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Grpc.Server.Demo.UploadImgRequest, global::Grpc.Server.Demo.CommonResponse> UploadImg(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UploadImg, null, options);
      }
      /// <summary>
      /// 双向流模式
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpc.Server.Demo.AddStudentRequest, global::Grpc.Server.Demo.StudentResponse> AddManyStudents(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddManyStudents(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 双向流模式
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpc.Server.Demo.AddStudentRequest, global::Grpc.Server.Demo.StudentResponse> AddManyStudents(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_AddManyStudents, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StudentServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StudentServiceClient(configuration);
      }
    }

  }
}
#endregion
