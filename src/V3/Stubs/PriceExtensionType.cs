// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/price_extension_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/price_extension_type.proto</summary>
  public static partial class PriceExtensionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/price_extension_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceExtensionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9wcmljZV9leHRlbnNp",
            "b25fdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i6wEKFlByaWNlRXh0ZW5z",
            "aW9uVHlwZUVudW0i0AEKElByaWNlRXh0ZW5zaW9uVHlwZRIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIKCgZCUkFORFMQAhIKCgZFVkVOVFMQAxIN",
            "CglMT0NBVElPTlMQBBIRCg1ORUlHSEJPUkhPT0RTEAUSFgoSUFJPRFVDVF9D",
            "QVRFR09SSUVTEAYSEQoNUFJPRFVDVF9USUVSUxAHEgwKCFNFUlZJQ0VTEAgS",
            "FgoSU0VSVklDRV9DQVRFR09SSUVTEAkSEQoNU0VSVklDRV9USUVSUxAKQuwB",
            "CiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXNCF1ByaWNlRXh0",
            "ZW5zaW9uVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9lbnVtcztlbnVtc6ICA0dB",
            "QaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVudW1zygIdR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjNcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.PriceExtensionTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.PriceExtensionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.PriceExtensionTypeEnum.Types.PriceExtensionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing types for a price extension.
  /// </summary>
  public sealed partial class PriceExtensionTypeEnum : pb::IMessage<PriceExtensionTypeEnum> {
    private static readonly pb::MessageParser<PriceExtensionTypeEnum> _parser = new pb::MessageParser<PriceExtensionTypeEnum>(() => new PriceExtensionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceExtensionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.PriceExtensionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionTypeEnum(PriceExtensionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionTypeEnum Clone() {
      return new PriceExtensionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceExtensionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceExtensionTypeEnum other) {
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
    public void MergeFrom(PriceExtensionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PriceExtensionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Price extension type.
      /// </summary>
      public enum PriceExtensionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The type for showing a list of brands.
        /// </summary>
        [pbr::OriginalName("BRANDS")] Brands = 2,
        /// <summary>
        /// The type for showing a list of events.
        /// </summary>
        [pbr::OriginalName("EVENTS")] Events = 3,
        /// <summary>
        /// The type for showing locations relevant to your business.
        /// </summary>
        [pbr::OriginalName("LOCATIONS")] Locations = 4,
        /// <summary>
        /// The type for showing sub-regions or districts within a city or region.
        /// </summary>
        [pbr::OriginalName("NEIGHBORHOODS")] Neighborhoods = 5,
        /// <summary>
        /// The type for showing a collection of product categories.
        /// </summary>
        [pbr::OriginalName("PRODUCT_CATEGORIES")] ProductCategories = 6,
        /// <summary>
        /// The type for showing a collection of related product tiers.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TIERS")] ProductTiers = 7,
        /// <summary>
        /// The type for showing a collection of services offered by your business.
        /// </summary>
        [pbr::OriginalName("SERVICES")] Services = 8,
        /// <summary>
        /// The type for showing a collection of service categories.
        /// </summary>
        [pbr::OriginalName("SERVICE_CATEGORIES")] ServiceCategories = 9,
        /// <summary>
        /// The type for showing a collection of related service tiers.
        /// </summary>
        [pbr::OriginalName("SERVICE_TIERS")] ServiceTiers = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
