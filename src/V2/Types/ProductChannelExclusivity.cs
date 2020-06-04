// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/product_channel_exclusivity.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/product_channel_exclusivity.proto</summary>
  public static partial class ProductChannelExclusivityReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/product_channel_exclusivity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductChannelExclusivityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wcm9kdWN0X2NoYW5u",
            "ZWxfZXhjbHVzaXZpdHkucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoEBCh1Qcm9k",
            "dWN0Q2hhbm5lbEV4Y2x1c2l2aXR5RW51bSJgChlQcm9kdWN0Q2hhbm5lbEV4",
            "Y2x1c2l2aXR5Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhIKDlNJ",
            "TkdMRV9DSEFOTkVMEAISEQoNTVVMVElfQ0hBTk5FTBADQvMBCiFjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCHlByb2R1Y3RDaGFubmVsRXhj",
            "bHVzaXZpdHlQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGq",
            "Ah1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYyXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductChannelExclusivityEnum), global::Google.Ads.GoogleAds.V2.Enums.ProductChannelExclusivityEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductChannelExclusivityEnum.Types.ProductChannelExclusivity) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Availability of a product offer.
  /// </summary>
  public sealed partial class ProductChannelExclusivityEnum : pb::IMessage<ProductChannelExclusivityEnum> {
    private static readonly pb::MessageParser<ProductChannelExclusivityEnum> _parser = new pb::MessageParser<ProductChannelExclusivityEnum>(() => new ProductChannelExclusivityEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductChannelExclusivityEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.ProductChannelExclusivityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelExclusivityEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelExclusivityEnum(ProductChannelExclusivityEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelExclusivityEnum Clone() {
      return new ProductChannelExclusivityEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductChannelExclusivityEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductChannelExclusivityEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductChannelExclusivityEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductChannelExclusivityEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the availability of a product offer.
      /// </summary>
      public enum ProductChannelExclusivity {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The item is sold through one channel only, either local stores or online
        /// as indicated by its ProductChannel.
        /// </summary>
        [pbr::OriginalName("SINGLE_CHANNEL")] SingleChannel = 2,
        /// <summary>
        /// The item is matched to its online or local stores counterpart, indicating
        /// it is available for purchase in both ShoppingProductChannels.
        /// </summary>
        [pbr::OriginalName("MULTI_CHANNEL")] MultiChannel = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
