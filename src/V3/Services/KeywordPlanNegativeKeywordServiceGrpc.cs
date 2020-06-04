// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/keyword_plan_negative_keyword_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage Keyword Plan negative keywords.
  /// </summary>
  public static partial class KeywordPlanNegativeKeywordService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.KeywordPlanNegativeKeywordService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest> __Marshaller_google_ads_googleads_v3_services_GetKeywordPlanNegativeKeywordRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword> __Marshaller_google_ads_googleads_v3_resources_KeywordPlanNegativeKeyword = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest> __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanNegativeKeywordsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse> __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanNegativeKeywordsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword> __Method_GetKeywordPlanNegativeKeyword = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlanNegativeKeyword",
        __Marshaller_google_ads_googleads_v3_services_GetKeywordPlanNegativeKeywordRequest,
        __Marshaller_google_ads_googleads_v3_resources_KeywordPlanNegativeKeyword);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse> __Method_MutateKeywordPlanNegativeKeywords = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanNegativeKeywords",
        __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanNegativeKeywordsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanNegativeKeywordsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.KeywordPlanNegativeKeywordServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanNegativeKeywordService</summary>
    [grpc::BindServiceMethod(typeof(KeywordPlanNegativeKeywordService), "BindService")]
    public abstract partial class KeywordPlanNegativeKeywordServiceBase
    {
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeyword(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan negative keywords. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywords(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanNegativeKeywordService</summary>
    public partial class KeywordPlanNegativeKeywordServiceClient : grpc::ClientBase<KeywordPlanNegativeKeywordServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanNegativeKeywordService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public KeywordPlanNegativeKeywordServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanNegativeKeywordService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public KeywordPlanNegativeKeywordServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected KeywordPlanNegativeKeywordServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected KeywordPlanNegativeKeywordServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanNegativeKeyword(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlanNegativeKeyword, null, options, request);
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanNegativeKeywordAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlanNegativeKeyword, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan negative keywords. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanNegativeKeywords(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan negative keywords. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanNegativeKeywords, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan negative keywords. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanNegativeKeywordsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan negative keywords. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanNegativeKeywords, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override KeywordPlanNegativeKeywordServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanNegativeKeywordServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KeywordPlanNegativeKeywordServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlanNegativeKeyword, serviceImpl.GetKeywordPlanNegativeKeyword)
          .AddMethod(__Method_MutateKeywordPlanNegativeKeywords, serviceImpl.MutateKeywordPlanNegativeKeywords).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanNegativeKeywordServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetKeywordPlanNegativeKeyword, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanNegativeKeywordRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanNegativeKeyword>(serviceImpl.GetKeywordPlanNegativeKeyword));
      serviceBinder.AddMethod(__Method_MutateKeywordPlanNegativeKeywords, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanNegativeKeywordsResponse>(serviceImpl.MutateKeywordPlanNegativeKeywords));
    }

  }
}
#endregion
