namespace UserComments
{
    public class Comment
    {
        public string RawComment { get; set; }
        public string SantatisedComment { get; set; } = string.Empty;
    
    }
   
    public Comment(string rawComment)
    {
        RawComment = rawComment;
        
    }
  
}
}
