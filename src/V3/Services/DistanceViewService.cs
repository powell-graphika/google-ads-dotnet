// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/distance_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/distance_view_service.proto</summary>
  public static partial class DistanceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/distance_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DistanceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9kaXN0YW5jZV92",
            "aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNl",
            "cnZpY2VzGjVnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvZGlz",
            "dGFuY2Vfdmlldy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRf",
            "YmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8iXgoW",
            "R2V0RGlzdGFuY2VWaWV3UmVxdWVzdBJECg1yZXNvdXJjZV9uYW1lGAEgASgJ",
            "Qi3gQQL6QScKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9EaXN0YW5jZVZp",
            "ZXcy+gEKE0Rpc3RhbmNlVmlld1NlcnZpY2USxQEKD0dldERpc3RhbmNlVmll",
            "dxI4Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLkdldERpc3Rh",
            "bmNlVmlld1JlcXVlc3QaLy5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5yZXNv",
            "dXJjZXMuRGlzdGFuY2VWaWV3IkeC0+STAjESLy92My97cmVzb3VyY2VfbmFt",
            "ZT1jdXN0b21lcnMvKi9kaXN0YW5jZVZpZXdzLyp92kENcmVzb3VyY2VfbmFt",
            "ZRobykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tQv8BCiRjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjMuc2VydmljZXNCGERpc3RhbmNlVmlld1NlcnZp",
            "Y2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjMvc2VydmljZXM7c2VydmljZXOiAgNHQUGq",
            "AiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WMy5TZXJ2aWNlc8oCIEdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYzXFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjM6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.DistanceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [DistanceViewService.GetDistanceView][google.ads.googleads.v3.services.DistanceViewService.GetDistanceView].
  /// </summary>
  public sealed partial class GetDistanceViewRequest : pb::IMessage<GetDistanceViewRequest> {
    private static readonly pb::MessageParser<GetDistanceViewRequest> _parser = new pb::MessageParser<GetDistanceViewRequest>(() => new GetDistanceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetDistanceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.DistanceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDistanceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDistanceViewRequest(GetDistanceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDistanceViewRequest Clone() {
      return new GetDistanceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the distance view to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetDistanceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetDistanceViewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetDistanceViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code