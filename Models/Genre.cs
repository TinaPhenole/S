using System.Runtime.Serialization;
namespace SFF_Komplettering
{
    public enum Genre
    {
        [EnumMember(Value = "Action Movie")]
        Action,
        [EnumMember(Value = "Horror Movie")]
        Horror,
        [EnumMember(Value = "Comedy Movie")]
        Comedy,
        [EnumMember(Value = "Drama Movie")]
        Drama,
        [EnumMember(Value = "Historic Movie")]
        Historic,
        [EnumMember(Value = "Classic Movie")]
        Classic,
        [EnumMember(Value = "TrueStory Movie")]
        TrueStory
    }
}