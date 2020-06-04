// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/payments_account_service.proto
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

namespace Google.Ads.GoogleAds.V1.Services {
  /// <summary>
  /// Service to provide payments accounts that can be used to set up consolidated
  /// billing.
  /// </summary>
  public static partial class PaymentsAccountService
  {
    static readonly string __ServiceName = "google.ads.googleads.v1.services.PaymentsAccountService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest> __Marshaller_google_ads_googleads_v1_services_ListPaymentsAccountsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse> __Marshaller_google_ads_googleads_v1_services_ListPaymentsAccountsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest, global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse> __Method_ListPaymentsAccounts = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest, global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPaymentsAccounts",
        __Marshaller_google_ads_googleads_v1_services_ListPaymentsAccountsRequest,
        __Marshaller_google_ads_googleads_v1_services_ListPaymentsAccountsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V1.Services.PaymentsAccountServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PaymentsAccountService</summary>
    [grpc::BindServiceMethod(typeof(PaymentsAccountService), "BindService")]
    public abstract partial class PaymentsAccountServiceBase
    {
      /// <summary>
      /// Returns all payments accounts associated with all managers
      /// between the login customer ID and specified serving customer in the
      /// hierarchy, inclusive.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse> ListPaymentsAccounts(global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PaymentsAccountService</summary>
    public partial class PaymentsAccountServiceClient : grpc::ClientBase<PaymentsAccountServiceClient>
    {
      /// <summary>Creates a new client for PaymentsAccountService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PaymentsAccountServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PaymentsAccountService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PaymentsAccountServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PaymentsAccountServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PaymentsAccountServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns all payments accounts associated with all managers
      /// between the login customer ID and specified serving customer in the
      /// hierarchy, inclusive.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse ListPaymentsAccounts(global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPaymentsAccounts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all payments accounts associated with all managers
      /// between the login customer ID and specified serving customer in the
      /// hierarchy, inclusive.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse ListPaymentsAccounts(global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPaymentsAccounts, null, options, request);
      }
      /// <summary>
      /// Returns all payments accounts associated with all managers
      /// between the login customer ID and specified serving customer in the
      /// hierarchy, inclusive.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPaymentsAccountsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all payments accounts associated with all managers
      /// between the login customer ID and specified serving customer in the
      /// hierarchy, inclusive.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPaymentsAccounts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PaymentsAccountServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PaymentsAccountServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PaymentsAccountServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListPaymentsAccounts, serviceImpl.ListPaymentsAccounts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PaymentsAccountServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListPaymentsAccounts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsRequest, global::Google.Ads.GoogleAds.V1.Services.ListPaymentsAccountsResponse>(serviceImpl.ListPaymentsAccounts));
    }

  }
}
#endregion
