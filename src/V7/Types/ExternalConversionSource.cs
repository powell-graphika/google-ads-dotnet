// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/external_conversion_source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/external_conversion_source.proto</summary>
  public static partial class ExternalConversionSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/external_conversion_source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExternalConversionSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9leHRlcm5hbF9jb252",
            "ZXJzaW9uX3NvdXJjZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iigUKHEV4dGVy",
            "bmFsQ29udmVyc2lvblNvdXJjZUVudW0i6QQKGEV4dGVybmFsQ29udmVyc2lv",
            "blNvdXJjZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARILCgdXRUJQ",
            "QUdFEAISDQoJQU5BTFlUSUNTEAMSCgoGVVBMT0FEEAQSEwoPQURfQ0FMTF9N",
            "RVRSSUNTEAUSGAoUV0VCU0lURV9DQUxMX01FVFJJQ1MQBhIQCgxTVE9SRV9W",
            "SVNJVFMQBxISCg5BTkRST0lEX0lOX0FQUBAIEg4KCklPU19JTl9BUFAQCRIS",
            "Cg5JT1NfRklSU1RfT1BFThAKEhMKD0FQUF9VTlNQRUNJRklFRBALEhYKEkFO",
            "RFJPSURfRklSU1RfT1BFThAMEhAKDFVQTE9BRF9DQUxMUxANEgwKCEZJUkVC",
            "QVNFEA4SEQoNQ0xJQ0tfVE9fQ0FMTBAPEg4KClNBTEVTRk9SQ0UQEBITCg9T",
            "VE9SRV9TQUxFU19DUk0QERIfChtTVE9SRV9TQUxFU19QQVlNRU5UX05FVFdP",
            "UksQEhIPCgtHT09HTEVfUExBWRATEh0KGVRISVJEX1BBUlRZX0FQUF9BTkFM",
            "WVRJQ1MQFBIWChJHT09HTEVfQVRUUklCVVRJT04QFRIdChlTVE9SRV9TQUxF",
            "U19ESVJFQ1RfVVBMT0FEEBcSDwoLU1RPUkVfU0FMRVMQGBISCg5TRUFSQ0hf",
            "QURTXzM2MBAZEhEKDUdPT0dMRV9IT1NURUQQGxIOCgpGTE9PRExJR0hUEB0S",
            "HAoYQU5BTFlUSUNTX1NFQVJDSF9BRFNfMzYwEB8SGwoXRklSRUJBU0VfU0VB",
            "UkNIX0FEU18zNjAQIULyAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3",
            "LmVudW1zQh1FeHRlcm5hbENvbnZlcnNpb25Tb3VyY2VQcm90b1ABWkJnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjcvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WNy5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY3XEVudW1z6gIh",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.ExternalConversionSourceEnum), global::Google.Ads.GoogleAds.V7.Enums.ExternalConversionSourceEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.ExternalConversionSourceEnum.Types.ExternalConversionSource) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the external conversion source that is
  /// associated with a ConversionAction.
  /// </summary>
  public sealed partial class ExternalConversionSourceEnum : pb::IMessage<ExternalConversionSourceEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExternalConversionSourceEnum> _parser = new pb::MessageParser<ExternalConversionSourceEnum>(() => new ExternalConversionSourceEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExternalConversionSourceEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.ExternalConversionSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalConversionSourceEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalConversionSourceEnum(ExternalConversionSourceEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExternalConversionSourceEnum Clone() {
      return new ExternalConversionSourceEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExternalConversionSourceEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExternalConversionSourceEnum other) {
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExternalConversionSourceEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExternalConversionSourceEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The external conversion source that is associated with a ConversionAction.
      /// </summary>
      public enum ExternalConversionSource {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversion that occurs when a user navigates to a particular webpage
        /// after viewing an ad; Displayed in Google Ads UI as 'Website'.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 2,
        /// <summary>
        /// Conversion that comes from linked Google Analytics goal or transaction;
        /// Displayed in Google Ads UI as 'Analytics'.
        /// </summary>
        [pbr::OriginalName("ANALYTICS")] Analytics = 3,
        /// <summary>
        /// Website conversion that is uploaded through ConversionUploadService;
        /// Displayed in Google Ads UI as 'Import from clicks'.
        /// </summary>
        [pbr::OriginalName("UPLOAD")] Upload = 4,
        /// <summary>
        /// Conversion that occurs when a user clicks on a call extension directly on
        /// an ad; Displayed in Google Ads UI as 'Calls from ads'.
        /// </summary>
        [pbr::OriginalName("AD_CALL_METRICS")] AdCallMetrics = 5,
        /// <summary>
        /// Conversion that occurs when a user calls a dynamically-generated phone
        /// number (by installed javascript) from an advertiser's website after
        /// clicking on an ad; Displayed in Google Ads UI as 'Calls from website'.
        /// </summary>
        [pbr::OriginalName("WEBSITE_CALL_METRICS")] WebsiteCallMetrics = 6,
        /// <summary>
        /// Conversion that occurs when a user visits an advertiser's retail store
        /// after clicking on a Google ad;
        /// Displayed in Google Ads UI as 'Store visits'.
        /// </summary>
        [pbr::OriginalName("STORE_VISITS")] StoreVisits = 7,
        /// <summary>
        /// Conversion that occurs when a user takes an in-app action such as a
        /// purchase in an Android app;
        /// Displayed in Google Ads UI as 'Android in-app action'.
        /// </summary>
        [pbr::OriginalName("ANDROID_IN_APP")] AndroidInApp = 8,
        /// <summary>
        /// Conversion that occurs when a user takes an in-app action such as a
        /// purchase in an iOS app;
        /// Displayed in Google Ads UI as 'iOS in-app action'.
        /// </summary>
        [pbr::OriginalName("IOS_IN_APP")] IosInApp = 9,
        /// <summary>
        /// Conversion that occurs when a user opens an iOS app for the first time;
        /// Displayed in Google Ads UI as 'iOS app install (first open)'.
        /// </summary>
        [pbr::OriginalName("IOS_FIRST_OPEN")] IosFirstOpen = 10,
        /// <summary>
        /// Legacy app conversions that do not have an AppPlatform provided;
        /// Displayed in Google Ads UI as 'Mobile app'.
        /// </summary>
        [pbr::OriginalName("APP_UNSPECIFIED")] AppUnspecified = 11,
        /// <summary>
        /// Conversion that occurs when a user opens an Android app for the first
        /// time; Displayed in Google Ads UI as 'Android app install (first open)'.
        /// </summary>
        [pbr::OriginalName("ANDROID_FIRST_OPEN")] AndroidFirstOpen = 12,
        /// <summary>
        /// Call conversion that is uploaded through ConversionUploadService;
        /// Displayed in Google Ads UI as 'Import from calls'.
        /// </summary>
        [pbr::OriginalName("UPLOAD_CALLS")] UploadCalls = 13,
        /// <summary>
        /// Conversion that comes from a linked Firebase event;
        /// Displayed in Google Ads UI as 'Firebase'.
        /// </summary>
        [pbr::OriginalName("FIREBASE")] Firebase = 14,
        /// <summary>
        /// Conversion that occurs when a user clicks on a mobile phone number;
        /// Displayed in Google Ads UI as 'Phone number clicks'.
        /// </summary>
        [pbr::OriginalName("CLICK_TO_CALL")] ClickToCall = 15,
        /// <summary>
        /// Conversion that comes from Salesforce;
        /// Displayed in Google Ads UI as 'Salesforce.com'.
        /// </summary>
        [pbr::OriginalName("SALESFORCE")] Salesforce = 16,
        /// <summary>
        /// Conversion that comes from in-store purchases recorded by CRM;
        /// Displayed in Google Ads UI as 'Store sales (data partner)'.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_CRM")] StoreSalesCrm = 17,
        /// <summary>
        /// Conversion that comes from in-store purchases from payment network;
        /// Displayed in Google Ads UI as 'Store sales (payment network)'.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_PAYMENT_NETWORK")] StoreSalesPaymentNetwork = 18,
        /// <summary>
        /// Codeless Google Play conversion;
        /// Displayed in Google Ads UI as 'Google Play'.
        /// </summary>
        [pbr::OriginalName("GOOGLE_PLAY")] GooglePlay = 19,
        /// <summary>
        /// Conversion that comes from a linked third-party app analytics event;
        /// Displayed in Google Ads UI as 'Third-party app analytics'.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS")] ThirdPartyAppAnalytics = 20,
        /// <summary>
        /// Conversion that is controlled by Google Attribution.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ATTRIBUTION")] GoogleAttribution = 21,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant data
        /// uploads. Displayed in Google Ads UI as 'Store sales (direct upload)'.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_DIRECT_UPLOAD")] StoreSalesDirectUpload = 23,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant
        /// data uploads and/or from in-store purchases using cards from payment
        /// networks. Displayed in Google Ads UI as 'Store sales'.
        /// </summary>
        [pbr::OriginalName("STORE_SALES")] StoreSales = 24,
        /// <summary>
        /// Conversions imported from Search Ads 360 Floodlight data.
        /// </summary>
        [pbr::OriginalName("SEARCH_ADS_360")] SearchAds360 = 25,
        /// <summary>
        /// Conversions that track local actions from Google's products and services
        /// after interacting with an ad.
        /// </summary>
        [pbr::OriginalName("GOOGLE_HOSTED")] GoogleHosted = 27,
        /// <summary>
        /// Conversions reported by Floodlight tags.
        /// </summary>
        [pbr::OriginalName("FLOODLIGHT")] Floodlight = 29,
        /// <summary>
        /// Conversions that come from Google Analytics specifically for Search Ads
        /// 360. Displayed in Google Ads UI as Analytics (SA360).
        /// </summary>
        [pbr::OriginalName("ANALYTICS_SEARCH_ADS_360")] AnalyticsSearchAds360 = 31,
        /// <summary>
        /// Conversion that comes from a linked Firebase event for Search Ads 360.
        /// </summary>
        [pbr::OriginalName("FIREBASE_SEARCH_ADS_360")] FirebaseSearchAds360 = 33,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
