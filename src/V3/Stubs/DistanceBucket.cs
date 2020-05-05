// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/distance_bucket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/distance_bucket.proto</summary>
  public static partial class DistanceBucketReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/distance_bucket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DistanceBucketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9kaXN0YW5jZV9idWNr",
            "ZXQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIq0EChJEaXN0YW5jZUJ1Y2tldEVu",
            "dW0ilgQKDkRpc3RhbmNlQnVja2V0Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5L",
            "Tk9XThABEg8KC1dJVEhJTl83MDBNEAISDgoKV0lUSElOXzFLTRADEg4KCldJ",
            "VEhJTl81S00QBBIPCgtXSVRISU5fMTBLTRAFEg8KC1dJVEhJTl8xNUtNEAYS",
            "DwoLV0lUSElOXzIwS00QBxIPCgtXSVRISU5fMjVLTRAIEg8KC1dJVEhJTl8z",
            "MEtNEAkSDwoLV0lUSElOXzM1S00QChIPCgtXSVRISU5fNDBLTRALEg8KC1dJ",
            "VEhJTl80NUtNEAwSDwoLV0lUSElOXzUwS00QDRIPCgtXSVRISU5fNTVLTRAO",
            "Eg8KC1dJVEhJTl82MEtNEA8SDwoLV0lUSElOXzY1S00QEBIPCgtCRVlPTkRf",
            "NjVLTRAREhMKD1dJVEhJTl8wXzdNSUxFUxASEhAKDFdJVEhJTl8xTUlMRRAT",
            "EhEKDVdJVEhJTl81TUlMRVMQFBISCg5XSVRISU5fMTBNSUxFUxAVEhIKDldJ",
            "VEhJTl8xNU1JTEVTEBYSEgoOV0lUSElOXzIwTUlMRVMQFxISCg5XSVRISU5f",
            "MjVNSUxFUxAYEhIKDldJVEhJTl8zME1JTEVTEBkSEgoOV0lUSElOXzM1TUlM",
            "RVMQGhISCg5XSVRISU5fNDBNSUxFUxAbEhIKDkJFWU9ORF80ME1JTEVTEBxC",
            "6AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0ITRGlzdGFu",
            "Y2VCdWNrZXRQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZW51bXM7ZW51bXOiAgNHQUGq",
            "Ah1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMy5FbnVtc8oCHUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYzXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjM6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.DistanceBucketEnum), global::Google.Ads.GoogleAds.V3.Enums.DistanceBucketEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.DistanceBucketEnum.Types.DistanceBucket) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for distance buckets of a user’s distance from an advertiser’s
  /// location extension.
  /// </summary>
  public sealed partial class DistanceBucketEnum : pb::IMessage<DistanceBucketEnum> {
    private static readonly pb::MessageParser<DistanceBucketEnum> _parser = new pb::MessageParser<DistanceBucketEnum>(() => new DistanceBucketEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DistanceBucketEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.DistanceBucketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceBucketEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceBucketEnum(DistanceBucketEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceBucketEnum Clone() {
      return new DistanceBucketEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DistanceBucketEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DistanceBucketEnum other) {
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
    public void MergeFrom(DistanceBucketEnum other) {
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
    /// <summary>Container for nested types declared in the DistanceBucketEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The distance bucket for a user’s distance from an advertiser’s location
      /// extension.
      /// </summary>
      public enum DistanceBucket {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// User was within 700m of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_700M")] Within700M = 2,
        /// <summary>
        /// User was within 1KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_1KM")] Within1Km = 3,
        /// <summary>
        /// User was within 5KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_5KM")] Within5Km = 4,
        /// <summary>
        /// User was within 10KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_10KM")] Within10Km = 5,
        /// <summary>
        /// User was within 15KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_15KM")] Within15Km = 6,
        /// <summary>
        /// User was within 20KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_20KM")] Within20Km = 7,
        /// <summary>
        /// User was within 25KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_25KM")] Within25Km = 8,
        /// <summary>
        /// User was within 30KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_30KM")] Within30Km = 9,
        /// <summary>
        /// User was within 35KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_35KM")] Within35Km = 10,
        /// <summary>
        /// User was within 40KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_40KM")] Within40Km = 11,
        /// <summary>
        /// User was within 45KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_45KM")] Within45Km = 12,
        /// <summary>
        /// User was within 50KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_50KM")] Within50Km = 13,
        /// <summary>
        /// User was within 55KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_55KM")] Within55Km = 14,
        /// <summary>
        /// User was within 60KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_60KM")] Within60Km = 15,
        /// <summary>
        /// User was within 65KM of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_65KM")] Within65Km = 16,
        /// <summary>
        /// User was beyond 65KM of the location.
        /// </summary>
        [pbr::OriginalName("BEYOND_65KM")] Beyond65Km = 17,
        /// <summary>
        /// User was within 0.7 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_0_7MILES")] Within07Miles = 18,
        /// <summary>
        /// User was within 1 mile of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_1MILE")] Within1Mile = 19,
        /// <summary>
        /// User was within 5 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_5MILES")] Within5Miles = 20,
        /// <summary>
        /// User was within 10 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_10MILES")] Within10Miles = 21,
        /// <summary>
        /// User was within 15 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_15MILES")] Within15Miles = 22,
        /// <summary>
        /// User was within 20 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_20MILES")] Within20Miles = 23,
        /// <summary>
        /// User was within 25 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_25MILES")] Within25Miles = 24,
        /// <summary>
        /// User was within 30 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_30MILES")] Within30Miles = 25,
        /// <summary>
        /// User was within 35 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_35MILES")] Within35Miles = 26,
        /// <summary>
        /// User was within 40 miles of the location.
        /// </summary>
        [pbr::OriginalName("WITHIN_40MILES")] Within40Miles = 27,
        /// <summary>
        /// User was beyond 40 miles of the location.
        /// </summary>
        [pbr::OriginalName("BEYOND_40MILES")] Beyond40Miles = 28,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
