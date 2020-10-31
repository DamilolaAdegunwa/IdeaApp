using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaApp.Core.Enum
{
    public enum AttachmentTypes
    {
        PICTURE = 0,
        PDF = 1,
        WORD_DOC = 2,
        EXCEL_DOC = 3,
        GIF = 4,
    }
    public enum NotificationType
    {
        PRIVATE_MESSAGE = 0,
        UPCOMING_EVENT = 1,
        NEW_CONNECTION = 2,
    }
    public enum ReactionType
    {
        UPVOTE = 0,
        DOWNVOTE = 1
    }
    public enum BrainstormSessionMemberBadge
    {
        STUDENT = 0,
        SPONSORER = 1,
        PROFESSIONAL = 2,

    }
}
