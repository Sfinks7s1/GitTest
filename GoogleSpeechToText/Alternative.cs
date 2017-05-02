namespace SpeechToText
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class Alternative
    {
        [DataMember]
        public string transcript { get; set; }

        [DataMember]
        public string confidence { get; set; }
    }
}
