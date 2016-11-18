// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Quests/Quest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests
{

    /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/Quest.proto</summary>
    public static partial class QuestReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Data/Quests/Quest.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static QuestReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CiJQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0LnByb3RvEhZQT0dPUHJv",
                  "dG9zLkRhdGEuUXVlc3RzGiBQT0dPUHJvdG9zL0VudW1zL1F1ZXN0VHlwZS5w",
                  "cm90bxonUE9HT1Byb3Rvcy9EYXRhL1F1ZXN0cy9EYWlseVF1ZXN0LnByb3Rv",
                  "InEKBVF1ZXN0Ei8KCnF1ZXN0X3R5cGUYASABKA4yGy5QT0dPUHJvdG9zLkVu",
                  "dW1zLlF1ZXN0VHlwZRI3CgtkYWlseV9xdWVzdBgCIAEoCzIiLlBPR09Qcm90",
                  "b3MuRGF0YS5RdWVzdHMuRGFpbHlRdWVzdGIGcHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::POGOProtos.Enums.QuestTypeReflection.Descriptor, global::POGOProtos.Data.Quests.DailyQuestReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.Quest), global::POGOProtos.Data.Quests.Quest.Parser, new[]{ "QuestType", "DailyQuest" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class Quest : pb::IMessage<Quest>
    {
        private static readonly pb::MessageParser<Quest> _parser = new pb::MessageParser<Quest>(() => new Quest());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Quest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Data.Quests.QuestReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Quest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Quest(Quest other) : this()
        {
            questType_ = other.questType_;
            DailyQuest = other.dailyQuest_ != null ? other.DailyQuest.Clone() : null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Quest Clone()
        {
            return new Quest(this);
        }

        /// <summary>Field number for the "quest_type" field.</summary>
        public const int QuestTypeFieldNumber = 1;
        private global::POGOProtos.Enums.QuestType questType_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Enums.QuestType QuestType
        {
            get { return questType_; }
            set
            {
                questType_ = value;
            }
        }

        /// <summary>Field number for the "daily_quest" field.</summary>
        public const int DailyQuestFieldNumber = 2;
        private global::POGOProtos.Data.Quests.DailyQuest dailyQuest_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Quests.DailyQuest DailyQuest
        {
            get { return dailyQuest_; }
            set
            {
                dailyQuest_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Quest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Quest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (QuestType != other.QuestType) return false;
            if (!object.Equals(DailyQuest, other.DailyQuest)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (QuestType != 0) hash ^= QuestType.GetHashCode();
            if (dailyQuest_ != null) hash ^= DailyQuest.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (QuestType != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)QuestType);
            }
            if (dailyQuest_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(DailyQuest);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (QuestType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)QuestType);
            }
            if (dailyQuest_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyQuest);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Quest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.QuestType != 0)
            {
                QuestType = other.QuestType;
            }
            if (other.dailyQuest_ != null)
            {
                if (dailyQuest_ == null)
                {
                    dailyQuest_ = new global::POGOProtos.Data.Quests.DailyQuest();
                }
                DailyQuest.MergeFrom(other.DailyQuest);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            questType_ = (global::POGOProtos.Enums.QuestType)input.ReadEnum();
                            break;
                        }
                    case 18:
                        {
                            if (dailyQuest_ == null)
                            {
                                dailyQuest_ = new global::POGOProtos.Data.Quests.DailyQuest();
                            }
                            input.ReadMessage(dailyQuest_);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code