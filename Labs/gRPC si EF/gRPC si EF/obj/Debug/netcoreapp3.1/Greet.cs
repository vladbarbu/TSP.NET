// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gRPC_si_EF {

  /// <summary>Holder for reflection information generated from Protos/greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3JlZXQucHJvdG8SBWdyZWV0Gh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8i",
            "YwoMQ29tbWVudE1vZGVsEhEKCUNvbW1lbnRJZBgBIAEoBRIMCgRUZXh0GAIg",
            "ASgJEhIKClBvc3RQb3N0SWQYAyABKAUSHgoEcG9zdBgEIAEoCzIQLmdyZWV0",
            "LlBvc3RNb2RlbCKRAQoJUG9zdE1vZGVsEg4KBlBvc3RJZBgBIAEoBRITCgtE",
            "ZXNjcmlwdGlvbhgCIAEoCRIOCgZEb21haW4YAyABKAkSKAoERGF0ZRgEIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASJQoIY29tbWVudHMYBSAD",
            "KAsyEy5ncmVldC5Db21tZW50TW9kZWwiGAoGUG9zdElkEg4KBnBvc3RJZBgB",
            "IAEoBSIeCglDb21tZW50SWQSEQoJQ29tbWVudElkGAEgASgFIisKCFBvc3RM",
            "aXN0Eh8KBXBvc3RzGAEgAygLMhAuZ3JlZXQuUG9zdE1vZGVsIhwKCkJvb2xS",
            "ZXN1bHQSDgoGcmVzdWx0GAEgASgIIhsKCUludFJlc3VsdBIOCgZyZXN1bHQY",
            "ASABKAUyrwMKCmdSUENfc2lfRUYSLgoHQWRkUG9zdBIQLmdyZWV0LlBvc3RN",
            "b2RlbBoRLmdyZWV0LkJvb2xSZXN1bHQSMAoKVXBkYXRlUG9zdBIQLmdyZWV0",
            "LlBvc3RNb2RlbBoQLmdyZWV0LlBvc3RNb2RlbBItCgpEZWxldGVQb3N0Eg0u",
            "Z3JlZXQuUG9zdElkGhAuZ3JlZXQuSW50UmVzdWx0Ei4KC0dldFBvc3RCeUlk",
            "Eg0uZ3JlZXQuUG9zdElkGhAuZ3JlZXQuUG9zdE1vZGVsEjYKC0dldEFsbFBv",
            "c3RzEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5Gg8uZ3JlZXQuUG9zdExpc3QS",
            "NAoKQWRkQ29tbWVudBITLmdyZWV0LkNvbW1lbnRNb2RlbBoRLmdyZWV0LkJv",
            "b2xSZXN1bHQSOQoNVXBkYXRlQ29tbWVudBITLmdyZWV0LkNvbW1lbnRNb2Rl",
            "bBoTLmdyZWV0LkNvbW1lbnRNb2RlbBI3Cg5HZXRDb21tZW50QnlJZBIQLmdy",
            "ZWV0LkNvbW1lbnRJZBoTLmdyZWV0LkNvbW1lbnRNb2RlbEINqgIKZ1JQQ19z",
            "aV9FRmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.CommentModel), global::gRPC_si_EF.CommentModel.Parser, new[]{ "CommentId", "Text", "PostPostId", "Post" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.PostModel), global::gRPC_si_EF.PostModel.Parser, new[]{ "PostId", "Description", "Domain", "Date", "Comments" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.PostId), global::gRPC_si_EF.PostId.Parser, new[]{ "PostId_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.CommentId), global::gRPC_si_EF.CommentId.Parser, new[]{ "CommentId_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.PostList), global::gRPC_si_EF.PostList.Parser, new[]{ "Posts" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.BoolResult), global::gRPC_si_EF.BoolResult.Parser, new[]{ "Result" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC_si_EF.IntResult), global::gRPC_si_EF.IntResult.Parser, new[]{ "Result" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommentModel : pb::IMessage<CommentModel> {
    private static readonly pb::MessageParser<CommentModel> _parser = new pb::MessageParser<CommentModel>(() => new CommentModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommentModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel(CommentModel other) : this() {
      commentId_ = other.commentId_;
      text_ = other.text_;
      postPostId_ = other.postPostId_;
      post_ = other.post_ != null ? other.post_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel Clone() {
      return new CommentModel(this);
    }

    /// <summary>Field number for the "CommentId" field.</summary>
    public const int CommentIdFieldNumber = 1;
    private int commentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CommentId {
      get { return commentId_; }
      set {
        commentId_ = value;
      }
    }

    /// <summary>Field number for the "Text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PostPostId" field.</summary>
    public const int PostPostIdFieldNumber = 3;
    private int postPostId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostPostId {
      get { return postPostId_; }
      set {
        postPostId_ = value;
      }
    }

    /// <summary>Field number for the "post" field.</summary>
    public const int PostFieldNumber = 4;
    private global::gRPC_si_EF.PostModel post_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::gRPC_si_EF.PostModel Post {
      get { return post_; }
      set {
        post_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommentModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommentModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CommentId != other.CommentId) return false;
      if (Text != other.Text) return false;
      if (PostPostId != other.PostPostId) return false;
      if (!object.Equals(Post, other.Post)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CommentId != 0) hash ^= CommentId.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (PostPostId != 0) hash ^= PostPostId.GetHashCode();
      if (post_ != null) hash ^= Post.GetHashCode();
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
      if (CommentId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CommentId);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (PostPostId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PostPostId);
      }
      if (post_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Post);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CommentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CommentId);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (PostPostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostPostId);
      }
      if (post_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Post);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommentModel other) {
      if (other == null) {
        return;
      }
      if (other.CommentId != 0) {
        CommentId = other.CommentId;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.PostPostId != 0) {
        PostPostId = other.PostPostId;
      }
      if (other.post_ != null) {
        if (post_ == null) {
          Post = new global::gRPC_si_EF.PostModel();
        }
        Post.MergeFrom(other.Post);
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
          case 8: {
            CommentId = input.ReadInt32();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
          case 24: {
            PostPostId = input.ReadInt32();
            break;
          }
          case 34: {
            if (post_ == null) {
              Post = new global::gRPC_si_EF.PostModel();
            }
            input.ReadMessage(Post);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostModel : pb::IMessage<PostModel> {
    private static readonly pb::MessageParser<PostModel> _parser = new pb::MessageParser<PostModel>(() => new PostModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel(PostModel other) : this() {
      postId_ = other.postId_;
      description_ = other.description_;
      domain_ = other.domain_;
      date_ = other.date_ != null ? other.date_.Clone() : null;
      comments_ = other.comments_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel Clone() {
      return new PostModel(this);
    }

    /// <summary>Field number for the "PostId" field.</summary>
    public const int PostIdFieldNumber = 1;
    private int postId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostId {
      get { return postId_; }
      set {
        postId_ = value;
      }
    }

    /// <summary>Field number for the "Description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Domain" field.</summary>
    public const int DomainFieldNumber = 3;
    private string domain_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Date" field.</summary>
    public const int DateFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "comments" field.</summary>
    public const int CommentsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::gRPC_si_EF.CommentModel> _repeated_comments_codec
        = pb::FieldCodec.ForMessage(42, global::gRPC_si_EF.CommentModel.Parser);
    private readonly pbc::RepeatedField<global::gRPC_si_EF.CommentModel> comments_ = new pbc::RepeatedField<global::gRPC_si_EF.CommentModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::gRPC_si_EF.CommentModel> Comments {
      get { return comments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostId != other.PostId) return false;
      if (Description != other.Description) return false;
      if (Domain != other.Domain) return false;
      if (!object.Equals(Date, other.Date)) return false;
      if(!comments_.Equals(other.comments_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostId != 0) hash ^= PostId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      if (date_ != null) hash ^= Date.GetHashCode();
      hash ^= comments_.GetHashCode();
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
      if (PostId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PostId);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Domain);
      }
      if (date_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Date);
      }
      comments_.WriteTo(output, _repeated_comments_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostId);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      size += comments_.CalculateSize(_repeated_comments_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostModel other) {
      if (other == null) {
        return;
      }
      if (other.PostId != 0) {
        PostId = other.PostId;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Date.MergeFrom(other.Date);
      }
      comments_.Add(other.comments_);
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
          case 8: {
            PostId = input.ReadInt32();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Domain = input.ReadString();
            break;
          }
          case 34: {
            if (date_ == null) {
              Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Date);
            break;
          }
          case 42: {
            comments_.AddEntriesFrom(input, _repeated_comments_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostId : pb::IMessage<PostId> {
    private static readonly pb::MessageParser<PostId> _parser = new pb::MessageParser<PostId>(() => new PostId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostId(PostId other) : this() {
      postId_ = other.postId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostId Clone() {
      return new PostId(this);
    }

    /// <summary>Field number for the "postId" field.</summary>
    public const int PostId_FieldNumber = 1;
    private int postId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostId_ {
      get { return postId_; }
      set {
        postId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostId_ != other.PostId_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostId_ != 0) hash ^= PostId_.GetHashCode();
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
      if (PostId_ != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PostId_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostId_ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostId_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostId other) {
      if (other == null) {
        return;
      }
      if (other.PostId_ != 0) {
        PostId_ = other.PostId_;
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
          case 8: {
            PostId_ = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CommentId : pb::IMessage<CommentId> {
    private static readonly pb::MessageParser<CommentId> _parser = new pb::MessageParser<CommentId>(() => new CommentId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommentId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentId(CommentId other) : this() {
      commentId_ = other.commentId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentId Clone() {
      return new CommentId(this);
    }

    /// <summary>Field number for the "CommentId" field.</summary>
    public const int CommentId_FieldNumber = 1;
    private int commentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CommentId_ {
      get { return commentId_; }
      set {
        commentId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommentId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommentId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CommentId_ != other.CommentId_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CommentId_ != 0) hash ^= CommentId_.GetHashCode();
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
      if (CommentId_ != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CommentId_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CommentId_ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CommentId_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommentId other) {
      if (other == null) {
        return;
      }
      if (other.CommentId_ != 0) {
        CommentId_ = other.CommentId_;
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
          case 8: {
            CommentId_ = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostList : pb::IMessage<PostList> {
    private static readonly pb::MessageParser<PostList> _parser = new pb::MessageParser<PostList>(() => new PostList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostList(PostList other) : this() {
      posts_ = other.posts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostList Clone() {
      return new PostList(this);
    }

    /// <summary>Field number for the "posts" field.</summary>
    public const int PostsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::gRPC_si_EF.PostModel> _repeated_posts_codec
        = pb::FieldCodec.ForMessage(10, global::gRPC_si_EF.PostModel.Parser);
    private readonly pbc::RepeatedField<global::gRPC_si_EF.PostModel> posts_ = new pbc::RepeatedField<global::gRPC_si_EF.PostModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::gRPC_si_EF.PostModel> Posts {
      get { return posts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!posts_.Equals(other.posts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= posts_.GetHashCode();
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
      posts_.WriteTo(output, _repeated_posts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += posts_.CalculateSize(_repeated_posts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostList other) {
      if (other == null) {
        return;
      }
      posts_.Add(other.posts_);
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
            posts_.AddEntriesFrom(input, _repeated_posts_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class BoolResult : pb::IMessage<BoolResult> {
    private static readonly pb::MessageParser<BoolResult> _parser = new pb::MessageParser<BoolResult>(() => new BoolResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoolResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolResult(BoolResult other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoolResult Clone() {
      return new BoolResult(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private bool result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoolResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoolResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != false) hash ^= Result.GetHashCode();
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
      if (Result != false) {
        output.WriteRawTag(8);
        output.WriteBool(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoolResult other) {
      if (other == null) {
        return;
      }
      if (other.Result != false) {
        Result = other.Result;
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
          case 8: {
            Result = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class IntResult : pb::IMessage<IntResult> {
    private static readonly pb::MessageParser<IntResult> _parser = new pb::MessageParser<IntResult>(() => new IntResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IntResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC_si_EF.GreetReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntResult(IntResult other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IntResult Clone() {
      return new IntResult(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IntResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IntResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IntResult other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
          case 8: {
            Result = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code