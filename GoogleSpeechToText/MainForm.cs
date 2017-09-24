namespace SpeechToText
{
    using NAudio.Wave;
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        WaveIn waveIn;
        WaveFileWriter writer;
        string outputFilename = "temp.wav";
        bool ON;
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (this.ON == false)
            {
                this.waveIn = new WaveIn { DeviceNumber = 0 };
                //Дефолтное устройство для записи (если оно имеется)
                //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                this.waveIn.DataAvailable += this.waveIn_DataAvailable;
                this.waveIn.RecordingStopped += this.waveIn_RecordingStopped;
                //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                this.waveIn.WaveFormat = new WaveFormat(16000, 1);
                this.writer = new WaveFileWriter(this.outputFilename, this.waveIn.WaveFormat);
                this.label2.Text = "Идет запись...";
                this.btnRecord.Text = "Стоп";
                this.waveIn.StartRecording();
                this.ON = true;
            }
            else
            {
                this.waveIn.StopRecording();
                this.label2.Text = "";
                this.ON = false;
                this.btnRecord.Text = "Запись";
            }
        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            byte[] byteArray = File.ReadAllBytes(this.outputFilename);

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
                        this.label1.Text = result.result[0].alternative[result.result_index].transcript;
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

            MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(toParse));

            Result result = (Result)ser.ReadObject(stream1);

            return result;
        }

        //Получение данных из входного буфера и обработка полученных с микрофона данных
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(this.waveIn_DataAvailable), sender, e);
            }
            else
            {
                //Записываем данные из буфера в файл
                this.writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(this.waveIn_RecordingStopped), sender, e);
            }
            else
            {
                this.waveIn.Dispose();
                this.waveIn = null;
                this.writer.Close();
                this.writer = null;
            }
        }
    }
}
