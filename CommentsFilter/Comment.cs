
    class Comment
    {

    public Comment(string rawComments, string safeComment){ }
         
        public string RawComment { get; set; }
        public string santatisedComment { get; set; } = string.Empty;

    public Comment(string rawComments)
    {
        RawComment = rawComments;
    }
    
    }



// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.purgomalum.com")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.purgomalum.com", IsNullable = false)]
public partial class PurgoMalum
{

    private string resultField;

    /// <remarks/>
    public string result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }
}

