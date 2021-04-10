// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac_winter.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ZodiacService.Protos {
  public static partial class ZodiacSignTellerWinter
  {
    static readonly string __ServiceName = "zodiac.ZodiacSignTellerWinter";

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

    static readonly grpc::Marshaller<global::ZodiacService.Protos.DateRequestWinter> __Marshaller_zodiac_DateRequestWinter = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacService.Protos.DateRequestWinter.Parser));
    static readonly grpc::Marshaller<global::ZodiacService.Protos.ZodiacSignWinter> __Marshaller_zodiac_ZodiacSignWinter = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacService.Protos.ZodiacSignWinter.Parser));

    static readonly grpc::Method<global::ZodiacService.Protos.DateRequestWinter, global::ZodiacService.Protos.ZodiacSignWinter> __Method_SayZodiacSign = new grpc::Method<global::ZodiacService.Protos.DateRequestWinter, global::ZodiacService.Protos.ZodiacSignWinter>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayZodiacSign",
        __Marshaller_zodiac_DateRequestWinter,
        __Marshaller_zodiac_ZodiacSignWinter);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ZodiacService.Protos.ZodiacWinterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ZodiacSignTellerWinter</summary>
    public partial class ZodiacSignTellerWinterClient : grpc::ClientBase<ZodiacSignTellerWinterClient>
    {
      /// <summary>Creates a new client for ZodiacSignTellerWinter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZodiacSignTellerWinterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZodiacSignTellerWinter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZodiacSignTellerWinterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZodiacSignTellerWinterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZodiacSignTellerWinterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ZodiacService.Protos.ZodiacSignWinter SayZodiacSign(global::ZodiacService.Protos.DateRequestWinter request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayZodiacSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ZodiacService.Protos.ZodiacSignWinter SayZodiacSign(global::ZodiacService.Protos.DateRequestWinter request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayZodiacSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacService.Protos.ZodiacSignWinter> SayZodiacSignAsync(global::ZodiacService.Protos.DateRequestWinter request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayZodiacSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacService.Protos.ZodiacSignWinter> SayZodiacSignAsync(global::ZodiacService.Protos.DateRequestWinter request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayZodiacSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZodiacSignTellerWinterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZodiacSignTellerWinterClient(configuration);
      }
    }

  }
}
#endregion
