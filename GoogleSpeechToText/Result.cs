namespace SpeechToText
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class Result
    {
        [DataMember]
        public Results[] result { get; set; }

        [DataMember]
        public int result_index { get; set; }
    }
}
