// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/hotel_group_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/hotel_group_view_service.proto</summary>
  public static partial class HotelGroupViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/hotel_group_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelGroupViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9ob3RlbF9ncm91",
            "cF92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LnNlcnZpY2VzGjhnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMv",
            "aG90ZWxfZ3JvdXBfdmlldy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9hcGkv",
            "ZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJv",
            "dG8iYgoYR2V0SG90ZWxHcm91cFZpZXdSZXF1ZXN0EkYKDXJlc291cmNlX25h",
            "bWUYASABKAlCL+BBAvpBKQonZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0hv",
            "dGVsR3JvdXBWaWV3MoQCChVIb3RlbEdyb3VwVmlld1NlcnZpY2USzQEKEUdl",
            "dEhvdGVsR3JvdXBWaWV3EjouZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2Vy",
            "dmljZXMuR2V0SG90ZWxHcm91cFZpZXdSZXF1ZXN0GjEuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjMucmVzb3VyY2VzLkhvdGVsR3JvdXBWaWV3IkmC0+STAjMS",
            "MS92My97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKi9ob3RlbEdyb3VwVmll",
            "d3MvKn3aQQ1yZXNvdXJjZV9uYW1lGhvKQRhnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb21CgQIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNl",
            "c0IaSG90ZWxHcm91cFZpZXdTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL3Nl",
            "cnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjMuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWM1xTZXJ2aWNl",
            "c+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpTZXJ2aWNlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.HotelGroupViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetHotelGroupViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetHotelGroupViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [HotelGroupViewService.GetHotelGroupView][google.ads.googleads.v3.services.HotelGroupViewService.GetHotelGroupView].
  /// </summary>
  public sealed partial class GetHotelGroupViewRequest : pb::IMessage<GetHotelGroupViewRequest> {
    private static readonly pb::MessageParser<GetHotelGroupViewRequest> _parser = new pb::MessageParser<GetHotelGroupViewRequest>(() => new GetHotelGroupViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHotelGroupViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.HotelGroupViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelGroupViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelGroupViewRequest(GetHotelGroupViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelGroupViewRequest Clone() {
      return new GetHotelGroupViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the Hotel Group View to fetch.
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
      return Equals(other as GetHotelGroupViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHotelGroupViewRequest other) {
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
    public void MergeFrom(GetHotelGroupViewRequest other) {
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
