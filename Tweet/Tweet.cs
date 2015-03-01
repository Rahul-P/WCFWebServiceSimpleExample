
namespace Tweet
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class Tweet
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PostedBy { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
