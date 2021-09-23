// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test_service.proto
// </auto-generated>
// Original file comments:
//
// Copyright 2016 Google Inc. All Rights Reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file or at
// https://developers.google.com/open-source/licenses/bsd
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Api.Gax.Grpc.IntegrationTests {
  public static partial class TestService
  {
    static readonly string __ServiceName = "google.api.gax.grpc.integration_tests.TestService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest> __Marshaller_google_api_gax_grpc_integration_tests_SimpleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse> __Marshaller_google_api_gax_grpc_integration_tests_SimpleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest, global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse> __Method_DoSimple = new grpc::Method<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest, global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoSimple",
        __Marshaller_google_api_gax_grpc_integration_tests_SimpleRequest,
        __Marshaller_google_api_gax_grpc_integration_tests_SimpleResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Api.Gax.Grpc.IntegrationTests.TestServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TestService</summary>
    [grpc::BindServiceMethod(typeof(TestService), "BindService")]
    public abstract partial class TestServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse> DoSimple(global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TestService</summary>
    public partial class TestServiceClient : grpc::ClientBase<TestServiceClient>
    {
      /// <summary>Creates a new client for TestService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TestServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TestService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TestServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TestServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TestServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse DoSimple(global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DoSimple(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse DoSimple(global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DoSimple, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse> DoSimpleAsync(global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DoSimpleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse> DoSimpleAsync(global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DoSimple, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override TestServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TestServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TestServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DoSimple, serviceImpl.DoSimple).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TestServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DoSimple, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Api.Gax.Grpc.IntegrationTests.SimpleRequest, global::Google.Api.Gax.Grpc.IntegrationTests.SimpleResponse>(serviceImpl.DoSimple));
    }

  }
}
#endregion