namespace SpeechToText
{
    using NAudio.Wave;
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        WaveIn waveIn;
        WaveFileWriter writer;
        string outputFilename = "temp.wav";
        bool ON = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ON == false)
            {
                waveIn = new WaveIn();
                //Дефолтное устройство для записи (если оно имеется)
                waveIn.DeviceNumber = 0;
                //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.RecordingStopped += new EventHandler<NAudio.Wave.StoppedEventArgs>(waveIn_RecordingStopped);
                //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
                label2.Text = "Идет запись...";
                button1.Text = "Стоп";
                waveIn.StartRecording();
                ON = true;
            }
            else
            {
                waveIn.StopRecording();
                label2.Text = "";
                ON = false;
                button1.Text = "Запись";
                //button2_Click(this, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] byteArray = File.ReadAllBytes(outputFilename);

            WebRequest request = WebRequest.Create("https://www.google.com/speech-api/v2/recognize?output=json&lang=ru-RU&key=AIzaSyBOti4mM-6x9WDnZIjIeyEU21OpBXqWBgw");
            request.Method = "POST";
            request.ContentType = "audio/l16; rate=16000"; //"16000";
            request.ContentLength = byteArray.Length;
            request.GetRequestStream().Write(byteArray, 0, byteArray.Length);
                      
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    Result result = ResponseParse(reader.ReadToEnd().Replace("{\"result\":[]}\n", ""));

                    if (result != null)
                    {
                        label1.Text = result.result[0].alternative[result.result_index].transcript;
                    }

                    reader.Close();
                }

                response.Close();
            }
        }

        public static Result ResponseParse(string toParse)
        {
            if (string.IsNullOrEmpty(toParse)) return null;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Result));

            MemoryStream stream1 = new MemoryStream(ASCIIEncoding.UTF8.GetBytes(toParse));

            Result result = (Result)ser.ReadObject(stream1);

            return result;
        }

        //Получение данных из входного буфера и обработка полученных с микрофона данных
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
            }
            else
            {
                //Записываем данные из буфера в файл
                writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
            }
            else
            {
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer = null;
            }
        }
    }
}
