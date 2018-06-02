// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: lock.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace V3Lockpb {
  /// <summary>
  /// The lock service exposes client-side locking facilities as a gRPC interface.
  /// </summary>
  public static partial class Lock
  {
    static readonly string __ServiceName = "v3lockpb.Lock";

    static readonly grpc::Marshaller<global::V3Lockpb.LockRequest> __Marshaller_LockRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::V3Lockpb.LockRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::V3Lockpb.LockResponse> __Marshaller_LockResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::V3Lockpb.LockResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::V3Lockpb.UnlockRequest> __Marshaller_UnlockRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::V3Lockpb.UnlockRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::V3Lockpb.UnlockResponse> __Marshaller_UnlockResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::V3Lockpb.UnlockResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::V3Lockpb.LockRequest, global::V3Lockpb.LockResponse> __Method_Lock = new grpc::Method<global::V3Lockpb.LockRequest, global::V3Lockpb.LockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Lock",
        __Marshaller_LockRequest,
        __Marshaller_LockResponse);

    static readonly grpc::Method<global::V3Lockpb.UnlockRequest, global::V3Lockpb.UnlockResponse> __Method_Unlock = new grpc::Method<global::V3Lockpb.UnlockRequest, global::V3Lockpb.UnlockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Unlock",
        __Marshaller_UnlockRequest,
        __Marshaller_UnlockResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::V3Lockpb.LockReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Lock</summary>
    public abstract partial class LockBase
    {
      /// <summary>
      /// Lock acquires a distributed shared lock on a given named lock.
      /// On success, it will return a unique key that exists so long as the
      /// lock is held by the caller. This key can be used in conjunction with
      /// transactions to safely ensure updates to etcd only occur while holding
      /// lock ownership. The lock is held until Unlock is called on the key or the
      /// lease associate with the owner expires.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::V3Lockpb.LockResponse> Lock(global::V3Lockpb.LockRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Unlock takes a key returned by Lock and releases the hold on lock. The
      /// next Lock caller waiting for the lock will then be woken up and given
      /// ownership of the lock.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::V3Lockpb.UnlockResponse> Unlock(global::V3Lockpb.UnlockRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Lock</summary>
    public partial class LockClient : grpc::ClientBase<LockClient>
    {
      /// <summary>Creates a new client for Lock</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LockClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Lock that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LockClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LockClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LockClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lock acquires a distributed shared lock on a given named lock.
      /// On success, it will return a unique key that exists so long as the
      /// lock is held by the caller. This key can be used in conjunction with
      /// transactions to safely ensure updates to etcd only occur while holding
      /// lock ownership. The lock is held until Unlock is called on the key or the
      /// lease associate with the owner expires.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::V3Lockpb.LockResponse Lock(global::V3Lockpb.LockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Lock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lock acquires a distributed shared lock on a given named lock.
      /// On success, it will return a unique key that exists so long as the
      /// lock is held by the caller. This key can be used in conjunction with
      /// transactions to safely ensure updates to etcd only occur while holding
      /// lock ownership. The lock is held until Unlock is called on the key or the
      /// lease associate with the owner expires.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::V3Lockpb.LockResponse Lock(global::V3Lockpb.LockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Lock, null, options, request);
      }
      /// <summary>
      /// Lock acquires a distributed shared lock on a given named lock.
      /// On success, it will return a unique key that exists so long as the
      /// lock is held by the caller. This key can be used in conjunction with
      /// transactions to safely ensure updates to etcd only occur while holding
      /// lock ownership. The lock is held until Unlock is called on the key or the
      /// lease associate with the owner expires.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::V3Lockpb.LockResponse> LockAsync(global::V3Lockpb.LockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lock acquires a distributed shared lock on a given named lock.
      /// On success, it will return a unique key that exists so long as the
      /// lock is held by the caller. This key can be used in conjunction with
      /// transactions to safely ensure updates to etcd only occur while holding
      /// lock ownership. The lock is held until Unlock is called on the key or the
      /// lease associate with the owner expires.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::V3Lockpb.LockResponse> LockAsync(global::V3Lockpb.LockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Lock, null, options, request);
      }
      /// <summary>
      /// Unlock takes a key returned by Lock and releases the hold on lock. The
      /// next Lock caller waiting for the lock will then be woken up and given
      /// ownership of the lock.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::V3Lockpb.UnlockResponse Unlock(global::V3Lockpb.UnlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Unlock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unlock takes a key returned by Lock and releases the hold on lock. The
      /// next Lock caller waiting for the lock will then be woken up and given
      /// ownership of the lock.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::V3Lockpb.UnlockResponse Unlock(global::V3Lockpb.UnlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Unlock, null, options, request);
      }
      /// <summary>
      /// Unlock takes a key returned by Lock and releases the hold on lock. The
      /// next Lock caller waiting for the lock will then be woken up and given
      /// ownership of the lock.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::V3Lockpb.UnlockResponse> UnlockAsync(global::V3Lockpb.UnlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnlockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unlock takes a key returned by Lock and releases the hold on lock. The
      /// next Lock caller waiting for the lock will then be woken up and given
      /// ownership of the lock.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::V3Lockpb.UnlockResponse> UnlockAsync(global::V3Lockpb.UnlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Unlock, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LockClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LockClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LockBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Lock, serviceImpl.Lock)
          .AddMethod(__Method_Unlock, serviceImpl.Unlock).Build();
    }

  }
}
#endregion
