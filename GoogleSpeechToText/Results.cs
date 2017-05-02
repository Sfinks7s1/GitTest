namespace SpeechToText
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class Results
    {
        [DataMember]
        public Alternative[] alternative { get; set; }

        [DataMember]
        public bool final { get; set; }
    }
}
